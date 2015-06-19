using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedConn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            IE.Navigate("https://150617-dot-starkappcloud.appspot.com/app/?api=1");
            while (IE.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        public void ShowLogin()
        {
            IE.Refresh()
            mShowAllowed = true;
            this.ShowDialog();
        }

        private bool mShowAllowed = false;
        protected override void SetVisibleCore(bool value)
        {
            if (!mShowAllowed) value = false;
            base.SetVisibleCore(value);
        }

        public WebBrowser Explorer
        {
            get { return this.IE; }
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

    }
}
