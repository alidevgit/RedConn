using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RedConn
{
    public delegate void MessageReceivedEventHandler(string eventName, object args);

    [ComVisibleAttribute(true)]
    public class RemoteConn
    {
        LoginForm browser;

        public event MessageReceivedEventHandler MessageReceived;

        public RemoteConn()
        {
            this.browser = new LoginForm();
            this.browser.ShowDialog();
            this.browser.Explorer.ObjectForScripting = this;
        }

        public bool UserIsAuth() { return this.UserFirstName() != null; }

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

        public void UserLogin() { browser.ShowLogin(); }
        public bool UserLogout() { var ret = RemoteSend("UserLogout"); return true; }
        public RemoteObj GetProjects()  { var ret = RemoteSend("PrjList"); return ret; }
        public RemoteObj OpenProject(string prjID) { var ret = RemoteSend("PrjOpen", prjID); return ret; }
        public RemoteObj CreateProject(string projectTitle) { var ret = RemoteSend("PrjCreate", projectTitle); return ret; }
        public RemoteObj UpdateProjectFromXML(string xml) { var ret = RemoteSend("PrjUpdateXML", xml); return ret; }
        public RemoteObj DeleteProject(string prjID) { var ret = RemoteSend("PrjDelete", prjID); return ret; }

        public RemoteObj CreateObject(string parentID, string objType, string objName) { var ret = RemoteSend("ObjCreate", parentID, objType, objName); return ret; }
        public RemoteObj GetObject(string objID) { var ret = RemoteSend("ObjGet", objID); return ret; }
        public RemoteObj DeleteObject(string objID) { var ret = RemoteSend("ObjRemove", objID); return ret; }

        public RemoteObj CreateParam(string objID, string paramName, string paramType, string paramValue, string paramDesc, string paramUnit, string paramUnitCategory) { var ret = RemoteSend("ParamCreate", objID, paramName, paramType, paramValue, paramDesc, paramUnit, paramUnitCategory); return ret; }
        public RemoteObj GetParam(string objID, string paramName) { var ret = RemoteSend("ParamGet", objID, paramName); return ret; }
        public RemoteObj SetParamValue(string objID, string paramName, string paramValue) { var ret = RemoteSend("ParamSet", objID, paramName, paramValue); return ret; }
        public RemoteObj DeleteParam(string objID, string paramName) { var ret = RemoteSend("ParamRemove", objID, paramName); return ret; }

        public RemoteObj SetMyAppLabel(string label) { var ret = RemoteSend("AppSetLabel", label); return ret; }
        public RemoteObj GetConnectedApps(bool byProject) { var ret = RemoteSend("AppGetClients", (byProject ? "project" : "team")); return ret; }
        public RemoteObj SendMsgToConnectedApp(string client, string action, string arguments) { var ret = RemoteSend("AppSendMsg", client, action, arguments); return ret; }

        public RemoteObj RemoteSend(string method, string arg0 = null, string arg1 = null, string arg2 = null, string arg3 = null, string arg4 = null, string arg5 = null, string arg6 = null)
        {
            string s = (string)this.browser.Explorer.Document.InvokeScript("APIConn", new object[] { method, arg0, arg1, arg2, arg3, arg4, arg5, arg6 });
            if (s == null) { 
                return null;
            }

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var o = (Dictionary<string, object>) serializer.DeserializeObject(s);
            RemoteObj ret = new RemoteObj(this, null);
            ret.Parse(o);
            return ret;
        }
        
        public void RemoteReceive(string eventName, object args)
        {
            if (eventName == "UserLoginSuccess")
            {
                //browser.Hide();
            }

            if (this.MessageReceived != null)
            {
                this.MessageReceived(eventName, args);
            }
        }
    }
}
