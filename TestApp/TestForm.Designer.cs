namespace TestApp
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.treeObjects = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 52);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(16, 74);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 52);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(16, 133);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(165, 52);
            this.btnUserInfo.TabIndex = 2;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.treeObjects);
            this.panelOperations.Controls.Add(this.label1);
            this.panelOperations.Controls.Add(this.listProjects);
            this.panelOperations.Location = new System.Drawing.Point(189, 15);
            this.panelOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(780, 526);
            this.panelOperations.TabIndex = 6;
            // 
            // treeObjects
            // 
            this.treeObjects.Location = new System.Drawing.Point(4, 60);
            this.treeObjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeObjects.Name = "treeObjects";
            this.treeObjects.Size = new System.Drawing.Size(339, 464);
            this.treeObjects.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Projects";
            // 
            // listProjects
            // 
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(4, 26);
            this.listProjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(339, 24);
            this.listProjects.TabIndex = 6;
            this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 555);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panelOperations.ResumeLayout(false);
            this.panelOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.TreeView treeObjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listProjects;
    }
}