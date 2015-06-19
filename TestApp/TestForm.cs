using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedConn;

namespace TestApp
{
    public partial class TestForm : Form
    {
        RemoteConn Remote;
        RemoteObj ActiveProject;
        RemoteObj ActiveObject;
        RemoteParam ActiveParameter;

        public TestForm()
        {
            InitializeComponent();
            Remote = new RemoteConn();
            Remote.MessageReceived += MessageReceived; // register for receiving messages from server
        }
        
        // any message we receive from the server will come here.
        void MessageReceived(string eventName, object args)
        {

            if (eventName == "Error")
            {
                txtStatusWindow.AppendText("Remote Error: " + (string)args + ".\n");
            }
            else if (eventName == "UserLoginSuccess") 
            {
                // user logged in successfully, app ready to use
            }
            else if (eventName == "AppJoined")
            {
                // you logged into a remote app with your credentials
            }
            else if (eventName == "AppLeft")
            {
                // you logged out of a remote app
            } 
            else if (eventName == "AppProjectOpen")
            {
                // you opened a project on a remote app
            } 
            else if (eventName == "AppLabel") 
            {
                // a remote app changed its label (labels are used to identify different apps)
            } 
            else if (eventName == "AppDirectMsg") 
            {
                // a remote app sent direct message to this app
            } 
            else if (eventName == "AppProjectUpdated") 
            {
                // a remote app (and possibly a different user) updated the project you currently have open.
            }
            else if (eventName == "AppProjectDeleted")
            {
                // a remote app (and possibly a different user) deleted the project you currently have open.
            }
            else
            {
                txtStatusWindow.AppendText("Received unknown event " + eventName + " from server. \n");
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // let's enable/disable this form based on the login status of the user
            CheckIfUserLoggedIn();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // ask brim object to log the user in
            // brim object will display the login screen.
            Remote.UserLogin();
            
            // after the login process, check if user really logged in and adjust the form. 
            CheckIfUserLoggedIn();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // ask brim object to log the user out
            Remote.UserLogout();

            // after the logout process, check if user really logged out and adjust the form. 
            CheckIfUserLoggedIn();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            // you have access to logged in user's first and last name
            MessageBox.Show("You are currently logged in as " + Remote.UserFirstName() + " " + Remote.UserLastName() + ".");
        }

        void CheckIfUserLoggedIn()
        {
            // ask brim object is user really logged in
            // enable/disable controls on the form accordingly

            if (Remote.UserIsAuth())
            {
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
                btnUserInfo.Enabled = true;
                panelOperations.Enabled = true;
                PopulateProjectList();
            } 
            else
            {
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                btnUserInfo.Enabled = false;
                panelOperations.Enabled = false;
            }
        }

        void PopulateProjectList()
        {
            // get the list of this user's projects from the remote server
            RemoteObj projects = Remote.GetProjects();

            listProjects.DisplayMember = "Text";
            listProjects.ValueMember = "Value";

            // populate the combobox with the project names

            var items = new List<object>();
            for(int i=0; i < projects.Objects.Count(); i++)
            {
                items.Add(new { Text = projects.Objects.Get(i).Name, Value = projects.Objects.Get(i).ID });
            }

            listProjects.DataSource = items;
            listProjects.SelectedIndex = 0;
        }

        // if user selects a project form the project list
        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeObjects.Nodes.Clear();

            string prjID = (string)listProjects.SelectedValue;

            // open the project user selected
            RemoteObj project = Remote.OpenProject(prjID);

            // get the objects of the currently open project
            this.ActiveProject = Remote.GetObject(prjID);

            // populate the project tree with the objects (and their parameters)
            TreeNode t = new TreeNode();
            treeObjects.Nodes.Add(t);
            PopulateProjectTree(this.ActiveProject, t);
            treeObjects.SelectedNode = t;
        }

        
        private void PopulateProjectTree(RemoteObj o, TreeNode t)
        {
            string objID = "";
            string objName = "";
            string objType = "";

            for (int i = 0; i < o.Params.Count(); i++ )
            {
                RemoteParam p = o.Params.Get(i);
                if (p.Name == "ID") objID = p.Value.AsText();
                if (p.Name == "N") objName = p.Value.AsText();
                if (p.Name == "T") objType = p.Value.AsText();
                
                TreeNode pt = new TreeNode();
                pt.Name = p.Parent.GetID() + "_" + p.Name;
                t.Nodes.Add(pt);
                pt.Text = p.Name + " = " + p.Value.AsText();
                pt.Tag = p.Name;
            }

            t.Text = objName + "(" + objType + ")";
            t.Tag = objID;

            for (int i = 0; i < o.Objects.Count(); i++ )
            {
                TreeNode st = new TreeNode();
                t.Nodes.Add(st);
                t.Name = o.Objects.Get(i).GetID();
                PopulateProjectTree(o.Objects.Get(i), st);
            }
        }

        // create a new project.
        private void btnNewPrj_Click(object sender, EventArgs e)
        {
            string projectName = "New Project";
            if (Utils.ShowInputDialog("Project Name", ref projectName) == System.Windows.Forms.DialogResult.OK)
            {
                // check if user already has a project with this name
                // there is nothing wrong with having projects with the same
                // name -- it is just confusing. 
                RemoteObj projects = Remote.GetProjects();
                for (int i = 0; i < projects.Objects.Count(); i++)
                {
                    if (projects.Objects.Get(i).Name == projectName)
                    {
                        MessageBox.Show("Sorry you already have a project with this name. Try again.");
                        return;
                    }
                }

                RemoteObj res = Remote.CreateProject(projectName);
                this.PopulateProjectList();
                listProjects.SelectedValue = res.GetID();

            }
        }

        private void treeObjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0) 
            {
                // parameter node
                string objectID = (string)e.Node.Parent.Tag; 
                string paramName = (string)e.Node.Tag; 
                RemoteObj o = this.ActiveProject.GetObject(objectID);
                RemoteParam p = o.GetParam(paramName);
                this.ActiveParameter = p;
                this.ActiveObject = null;
                this.DisplayParamEditPanel(p);
            }
            else 
            {
                // object node
                string objectID = (string)e.Node.Tag;
                RemoteObj o = this.ActiveProject.GetObject(objectID);
                this.ActiveParameter = null;
                this.ActiveObject = o;
                this.DisplayParamEditObj(o);
            }
            
        }

        private void DisplayParamEditPanel(RemoteParam p)
        {
            panelObj.Visible = false;
            panelParam.Visible = true;

            txtParamName.Text = p.Name;
            txtParamDesc.Text = p.Desc;
            
            txtExpression.Text = p.Expr;
            txtValue.Text = p.Value.AsText();

            if (p.Type.ToLower() == "number")
                listParamType.SelectedIndex = 0; // numeric type
            else
                listParamType.SelectedIndex = 1; // text type

            listParamUnitType.SelectedIndex = RemoteParam.StringToUnitType(p.UType);
            txtUnitCategory.Text = p.UCat;
            
            listRole.SelectedIndex = (p.DisplayRole == "userinput" ? 1 : 0);
            txtUnitCategory.Text = p.DisplayCategory;
            if (p.DisplayWidth == null)
                listDisplayWidth.SelectedIndex = 1;
            else
                listDisplayWidth.SelectedIndex = int.Parse(p.DisplayWidth);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ActiveParameter == null) return;
            RemoteParam p = this.ActiveParameter;

            p.Name = txtParamName.Text;
            p.Desc = txtParamDesc.Text;

            p.Expr = txtExpression.Text;
            p.Type = (listParamType.SelectedIndex == 0 ? "number" : "text");
            p.UType = RemoteParam.UnitTypeToString(listParamUnitType.SelectedIndex);

            p.UCat = txtUnitCategory.Text;

            p.DisplayRole = (listRole.SelectedIndex == 1 ? "userinput" : "none");

            p.DisplayCategory = txtUnitCategory.Text;
            p.DisplayWidth = (listDisplayWidth.SelectedIndex == 1 ? null : listDisplayWidth.SelectedIndex.ToString());

            p.Update();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            this.DisplayParamEditPanel(this.ActiveParameter);
        }

        private void DisplayParamEditObj(RemoteObj o)
        {
            panelObj.Visible = true;
            panelParam.Visible = false;
        }

        private void btnDeleteParam_Click(object sender, EventArgs e)
        {
            if (this.ActiveParameter == null) return;
            RemoteParam p = this.ActiveParameter;
            Remote.DeleteParam(p.Parent.GetID(), p.Name);
            foreach (TreeNode n in treeObjects.Nodes.Find(p.Parent.GetID() + "_" + p.Name, true))
            {
                n.Remove();
            }
        }

        private void btnAddObj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void btnCreateParam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }
    }
}


