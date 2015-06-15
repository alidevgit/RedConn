using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RedConn
{
    [ComVisibleAttribute(true)]
    public class OBrIM
    {
        LoginForm browser;

        public OBrIM()
        {
            this.browser = new LoginForm();
            this.browser.ShowDialog();
            this.browser.Explorer.ObjectForScripting = this;
        }

        public bool UserIsAuth()
        {
            return this.UserFirstName() != null;
        }

        public string UserFirstName()
        {
            var ret = RemoteSend("UserInfo");
            if (ret == null) return null;
            if (ret.Success) return ret.FirstName;
            return null;
        }

        public string UserLastName()
        {
            var ret = RemoteSend("UserInfo");
            if (ret == null) return null;
            if (ret.Success) return ret.LastName;
            return null;
        }

        public void UserLogin()
        {
            browser.ShowLogin();
        }

        public bool UserLogout()
        {
            var ret = RemoteSend("UserLogout");
            return true;
        }

        public OBrIMObj GetProjects() 
        {
            var ret = RemoteSend("PrjList");
            return ret;
        }

        public OBrIMObj OpenProject(string prjID)
        {
            var ret = RemoteSend("PrjOpen", prjID);
            return ret;
        }

        public OBrIMObj GetObject(string objID)
        {
            var ret = RemoteSend("ObjGet", objID);
            return ret;
        }


        public void RemoteReceive(string eventName)
        {
            if (eventName == "UserLoginSuccess")
            {
                browser.Hide();
            }
        }

        public OBrIMObj RemoteSend(string method, string arg0 = null)
        {
            string s = (string)this.browser.Explorer.Document.InvokeScript("APIConn", new object[] { method, arg0 });
            if (s == null) { 
                return null;
            }

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var o = (Dictionary<string, object>) serializer.DeserializeObject(s);
            OBrIMObj ret = new OBrIMObj();
            ret.Parse(o);
            return ret;
        }

    }
}
