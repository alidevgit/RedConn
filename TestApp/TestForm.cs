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
        OBrIM brim;

        public TestForm()
        {
            InitializeComponent();
            brim = new OBrIM();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            CheckIfUserLoggedIn();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            brim.UserLogin();
            CheckIfUserLoggedIn();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            brim.UserLogout();
            CheckIfUserLoggedIn();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are currently logged in as " + brim.UserFirstName() + " " + brim.UserLastName() + ".");
        }

        void CheckIfUserLoggedIn()
        {
            if (brim.UserIsAuth())
            {
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;
                btnUserInfo.Enabled = true;
                panelOperations.Enabled = true;
                SetupUserProjects();
            } 
            else
            {
                btnLogin.Enabled = true;
                btnLogout.Enabled = false;
                btnUserInfo.Enabled = false;
                panelOperations.Enabled = false;
            }
        }

        void SetupUserProjects()
        {
            OBrIMObj projects = brim.GetProjects();

            listProjects.DisplayMember = "Text";
            listProjects.ValueMember = "Value";

            var items = new List<object>();
            for(int i=0; i < projects.Objects.Count(); i++)
            {
                items.Add(new { Text = projects.Objects.Get(i).Name, Value = projects.Objects.Get(i).ID });
            }

            listProjects.DataSource = items;
            listProjects.SelectedIndex = 0;
        }

        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeObjects.Nodes.Clear();

            string prjID = (string)listProjects.SelectedValue;

            OBrIMObj project = brim.OpenProject(prjID);

            var o = brim.GetObject(prjID);

            TreeNode t = new TreeNode();
            treeObjects.Nodes.Add(t);
            PopulateTreeForParam(o, t);
        }

        
        private void PopulateTreeForParam(OBrIMObj o, TreeNode t)
        {
            string objID = "";
            string objName = "";
            string objType = "";

            for (int i = 0; i < o.Params.Count(); i++ )
            {
                OBrIMParam p = o.Params.Get(i);
                if (p.Name == "ID") objID = p.Value.AsText();
                if (p.Name == "N") objName = p.Value.AsText();
                if (p.Name == "T") objType = p.Value.AsText();
                
                TreeNode pt = new TreeNode();
                t.Nodes.Add(pt);
                pt.Text = p.Name + " = " + p.Value.AsText();
            }

            t.Text = objName + "(" + objType + ")";
            t.Tag = objID;

            for (int i = 0; i < o.Objects.Count(); i++ )
            {
                TreeNode st = new TreeNode();
                t.Nodes.Add(st);
                PopulateTreeForParam(o.Objects.Get(i), st);
            }
        }

        

    }
}

