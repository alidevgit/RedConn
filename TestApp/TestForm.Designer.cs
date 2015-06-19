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
            this.btnNewPrj = new System.Windows.Forms.Button();
            this.treeObjects = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.panelParam = new System.Windows.Forms.Panel();
            this.lbl16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParamCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listDisplayWidth = new System.Windows.Forms.ComboBox();
            this.listRole = new System.Windows.Forms.ComboBox();
            this.listParamUnitType = new System.Windows.Forms.ComboBox();
            this.listParamType = new System.Windows.Forms.ComboBox();
            this.btnDeleteParam = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParamDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblParamType = new System.Windows.Forms.Label();
            this.txtParamName = new System.Windows.Forms.TextBox();
            this.lblParamName = new System.Windows.Forms.Label();
            this.panelObj = new System.Windows.Forms.Panel();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            this.btnCreateParam = new System.Windows.Forms.Button();
            this.btnAddObj = new System.Windows.Forms.Button();
            this.txtStatusWindow = new System.Windows.Forms.RichTextBox();
            this.panelOperations.SuspendLayout();
            this.panelParam.SuspendLayout();
            this.panelObj.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(165, 52);
            this.btnUserInfo.TabIndex = 2;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.btnNewPrj);
            this.panelOperations.Controls.Add(this.treeObjects);
            this.panelOperations.Controls.Add(this.label1);
            this.panelOperations.Controls.Add(this.listProjects);
            this.panelOperations.Controls.Add(this.panelObj);
            this.panelOperations.Controls.Add(this.panelParam);
            this.panelOperations.Location = new System.Drawing.Point(189, 15);
            this.panelOperations.Margin = new System.Windows.Forms.Padding(4);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(780, 526);
            this.panelOperations.TabIndex = 6;
            // 
            // btnNewPrj
            // 
            this.btnNewPrj.Location = new System.Drawing.Point(280, 26);
            this.btnNewPrj.Name = "btnNewPrj";
            this.btnNewPrj.Size = new System.Drawing.Size(63, 24);
            this.btnNewPrj.TabIndex = 11;
            this.btnNewPrj.Text = "New";
            this.btnNewPrj.UseVisualStyleBackColor = true;
            this.btnNewPrj.Click += new System.EventHandler(this.btnNewPrj_Click);
            // 
            // treeObjects
            // 
            this.treeObjects.Location = new System.Drawing.Point(4, 60);
            this.treeObjects.Margin = new System.Windows.Forms.Padding(4);
            this.treeObjects.Name = "treeObjects";
            this.treeObjects.Size = new System.Drawing.Size(339, 464);
            this.treeObjects.TabIndex = 8;
            this.treeObjects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeObjects_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Projects";
            // 
            // listProjects
            // 
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(4, 26);
            this.listProjects.Margin = new System.Windows.Forms.Padding(4);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(269, 24);
            this.listProjects.TabIndex = 6;
            this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
            // 
            // panelParam
            // 
            this.panelParam.Controls.Add(this.lbl16);
            this.panelParam.Controls.Add(this.label9);
            this.panelParam.Controls.Add(this.txtValue);
            this.panelParam.Controls.Add(this.txtExpression);
            this.panelParam.Controls.Add(this.label8);
            this.panelParam.Controls.Add(this.txtParamCategory);
            this.panelParam.Controls.Add(this.label7);
            this.panelParam.Controls.Add(this.listDisplayWidth);
            this.panelParam.Controls.Add(this.listRole);
            this.panelParam.Controls.Add(this.listParamUnitType);
            this.panelParam.Controls.Add(this.listParamType);
            this.panelParam.Controls.Add(this.btnDeleteParam);
            this.panelParam.Controls.Add(this.btnRevert);
            this.panelParam.Controls.Add(this.btnUpdate);
            this.panelParam.Controls.Add(this.label6);
            this.panelParam.Controls.Add(this.label5);
            this.panelParam.Controls.Add(this.txtUnitCategory);
            this.panelParam.Controls.Add(this.label4);
            this.panelParam.Controls.Add(this.label3);
            this.panelParam.Controls.Add(this.txtParamDesc);
            this.panelParam.Controls.Add(this.label2);
            this.panelParam.Controls.Add(this.lblParamType);
            this.panelParam.Controls.Add(this.txtParamName);
            this.panelParam.Controls.Add(this.lblParamName);
            this.panelParam.Location = new System.Drawing.Point(351, 60);
            this.panelParam.Name = "panelParam";
            this.panelParam.Size = new System.Drawing.Size(416, 463);
            this.panelParam.TabIndex = 10;
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Location = new System.Drawing.Point(233, 134);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(43, 16);
            this.lbl16.TabIndex = 27;
            this.lbl16.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Location = new System.Drawing.Point(236, 153);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(168, 22);
            this.txtValue.TabIndex = 25;
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(16, 153);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(195, 22);
            this.txtExpression.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Expression";
            // 
            // txtParamCategory
            // 
            this.txtParamCategory.Location = new System.Drawing.Point(206, 344);
            this.txtParamCategory.Name = "txtParamCategory";
            this.txtParamCategory.Size = new System.Drawing.Size(195, 22);
            this.txtParamCategory.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Display Category";
            // 
            // listDisplayWidth
            // 
            this.listDisplayWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDisplayWidth.FormattingEnabled = true;
            this.listDisplayWidth.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.listDisplayWidth.Location = new System.Drawing.Point(16, 389);
            this.listDisplayWidth.Name = "listDisplayWidth";
            this.listDisplayWidth.Size = new System.Drawing.Size(388, 24);
            this.listDisplayWidth.TabIndex = 20;
            // 
            // listRole
            // 
            this.listRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRole.FormattingEnabled = true;
            this.listRole.Items.AddRange(new object[] {
            "None",
            "User Input"});
            this.listRole.Location = new System.Drawing.Point(16, 342);
            this.listRole.Name = "listRole";
            this.listRole.Size = new System.Drawing.Size(184, 24);
            this.listRole.TabIndex = 19;
            // 
            // listParamUnitType
            // 
            this.listParamUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listParamUnitType.FormattingEnabled = true;
            this.listParamUnitType.Items.AddRange(new object[] {
            "None",
            "Length (ex. in)",
            "Force (ex. kip)",
            "Angle (ex. rad)",
            "Temperature (ex. F)",
            "Moment (ex. kip-in)",
            "Stress (ex. kip/in^2)",
            "Density (ex. kip/in^3)",
            "PerTemperature (ex. 1/F)",
            "Area (ex. in^2)",
            "Inertia (ex. in^4)",
            "Velocity (ex. in/sec)",
            "Acceleration (ex. in/sec^2)",
            "ForcePerLength (ex. kip/in)",
            "MomentPerLength (ex. kip-in/in)",
            "Volume (ex. in^3)",
            "Curvature (ex. 1/in)",
            "Warp (ex. in^6)"});
            this.listParamUnitType.Location = new System.Drawing.Point(16, 246);
            this.listParamUnitType.Name = "listParamUnitType";
            this.listParamUnitType.Size = new System.Drawing.Size(388, 24);
            this.listParamUnitType.TabIndex = 18;
            // 
            // listParamType
            // 
            this.listParamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listParamType.FormattingEnabled = true;
            this.listParamType.Items.AddRange(new object[] {
            "number",
            "text"});
            this.listParamType.Location = new System.Drawing.Point(16, 108);
            this.listParamType.Name = "listParamType";
            this.listParamType.Size = new System.Drawing.Size(388, 24);
            this.listParamType.TabIndex = 17;
            // 
            // btnDeleteParam
            // 
            this.btnDeleteParam.Location = new System.Drawing.Point(259, 13);
            this.btnDeleteParam.Name = "btnDeleteParam";
            this.btnDeleteParam.Size = new System.Drawing.Size(145, 37);
            this.btnDeleteParam.TabIndex = 16;
            this.btnDeleteParam.Text = "Delete Parameter";
            this.btnDeleteParam.UseVisualStyleBackColor = true;
            this.btnDeleteParam.Click += new System.EventHandler(this.btnDeleteParam_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(217, 420);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(187, 31);
            this.btnRevert.TabIndex = 15;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Apply";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Display Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Display Role";
            // 
            // txtUnitCategory
            // 
            this.txtUnitCategory.Location = new System.Drawing.Point(16, 295);
            this.txtUnitCategory.Name = "txtUnitCategory";
            this.txtUnitCategory.Size = new System.Drawing.Size(388, 22);
            this.txtUnitCategory.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit Type";
            // 
            // txtParamDesc
            // 
            this.txtParamDesc.Location = new System.Drawing.Point(16, 199);
            this.txtParamDesc.Name = "txtParamDesc";
            this.txtParamDesc.Size = new System.Drawing.Size(388, 22);
            this.txtParamDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // lblParamType
            // 
            this.lblParamType.AutoSize = true;
            this.lblParamType.Location = new System.Drawing.Point(13, 88);
            this.lblParamType.Name = "lblParamType";
            this.lblParamType.Size = new System.Drawing.Size(40, 16);
            this.lblParamType.TabIndex = 2;
            this.lblParamType.Text = "Type";
            // 
            // txtParamName
            // 
            this.txtParamName.Location = new System.Drawing.Point(16, 61);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(388, 22);
            this.txtParamName.TabIndex = 1;
            // 
            // lblParamName
            // 
            this.lblParamName.AutoSize = true;
            this.lblParamName.Location = new System.Drawing.Point(13, 40);
            this.lblParamName.Name = "lblParamName";
            this.lblParamName.Size = new System.Drawing.Size(45, 16);
            this.lblParamName.TabIndex = 0;
            this.lblParamName.Text = "Name";
            // 
            // panelObj
            // 
            this.panelObj.Controls.Add(this.btnDeleteObject);
            this.panelObj.Controls.Add(this.btnCreateParam);
            this.panelObj.Controls.Add(this.btnAddObj);
            this.panelObj.Location = new System.Drawing.Point(351, 60);
            this.panelObj.Name = "panelObj";
            this.panelObj.Size = new System.Drawing.Size(416, 114);
            this.panelObj.TabIndex = 9;
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Location = new System.Drawing.Point(206, 13);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(198, 37);
            this.btnDeleteObject.TabIndex = 2;
            this.btnDeleteObject.Text = "Delete Object";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            this.btnDeleteObject.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreateParam
            // 
            this.btnCreateParam.Location = new System.Drawing.Point(13, 61);
            this.btnCreateParam.Name = "btnCreateParam";
            this.btnCreateParam.Size = new System.Drawing.Size(391, 37);
            this.btnCreateParam.TabIndex = 1;
            this.btnCreateParam.Text = "Create Parameter";
            this.btnCreateParam.UseVisualStyleBackColor = true;
            this.btnCreateParam.Click += new System.EventHandler(this.btnCreateParam_Click);
            // 
            // btnAddObj
            // 
            this.btnAddObj.Location = new System.Drawing.Point(13, 14);
            this.btnAddObj.Name = "btnAddObj";
            this.btnAddObj.Size = new System.Drawing.Size(187, 37);
            this.btnAddObj.TabIndex = 0;
            this.btnAddObj.Text = "Create Object";
            this.btnAddObj.UseVisualStyleBackColor = true;
            this.btnAddObj.Click += new System.EventHandler(this.btnAddObj_Click);
            // 
            // txtStatusWindow
            // 
            this.txtStatusWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStatusWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStatusWindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStatusWindow.Location = new System.Drawing.Point(0, 548);
            this.txtStatusWindow.Name = "txtStatusWindow";
            this.txtStatusWindow.ReadOnly = true;
            this.txtStatusWindow.Size = new System.Drawing.Size(985, 86);
            this.txtStatusWindow.TabIndex = 7;
            this.txtStatusWindow.Text = "";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 634);
            this.Controls.Add(this.txtStatusWindow);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.Text = "Remote Connection Test App";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panelOperations.ResumeLayout(false);
            this.panelOperations.PerformLayout();
            this.panelParam.ResumeLayout(false);
            this.panelParam.PerformLayout();
            this.panelObj.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox txtStatusWindow;
        private System.Windows.Forms.Panel panelObj;
        private System.Windows.Forms.Button btnCreateParam;
        private System.Windows.Forms.Button btnAddObj;
        private System.Windows.Forms.Panel panelParam;
        private System.Windows.Forms.Label lblParamType;
        private System.Windows.Forms.TextBox txtParamName;
        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParamDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnDeleteObject;
        private System.Windows.Forms.Button btnDeleteParam;
        private System.Windows.Forms.ComboBox listParamType;
        private System.Windows.Forms.ComboBox listParamUnitType;
        private System.Windows.Forms.Button btnNewPrj;
        private System.Windows.Forms.ComboBox listRole;
        private System.Windows.Forms.ComboBox listDisplayWidth;
        private System.Windows.Forms.TextBox txtParamCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lbl16;
    }
}