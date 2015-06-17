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
        public OBrIMObj GetProjects()  { var ret = RemoteSend("PrjList"); return ret; }
        public OBrIMObj OpenProject(string prjID) { var ret = RemoteSend("PrjOpen", prjID); return ret; }
        public OBrIMObj CreateProject(string projectTitle) { var ret = RemoteSend("PrjCreate", projectTitle); return ret; }
        public OBrIMObj UpdateProjectFromXML(string xml) { var ret = RemoteSend("PrjUpdateXML", xml); return ret; }
        public OBrIMObj DeleteProject(string prjID) { var ret = RemoteSend("PrjDelete", prjID); return ret; }

        public OBrIMObj CreateObject(string parentID, string objType, string objName) { var ret = RemoteSend("ObjCreate", parentID, objType, objName); return ret; }
        public OBrIMObj GetObject(string objID) { var ret = RemoteSend("ObjGet", objID); return ret; }
        public OBrIMObj DeleteObject(string objID) { var ret = RemoteSend("ObjRemove", objID); return ret; }

        public OBrIMObj CreateParam(string objID, string paramName, string paramType, string paramValue, string paramDesc, string paramUnit, string paramUnitCategory) { var ret = RemoteSend("ParamCreate", objID, paramName, paramType, paramValue, paramDesc, paramUnit, paramUnitCategory); return ret; }
        public OBrIMObj GetParam(string objID, string paramName) { var ret = RemoteSend("ParamGet", objID, paramName); return ret; }
        public OBrIMObj SetParamValue(string objID, string paramName, string paramValue) { var ret = RemoteSend("ParamSet", objID, paramName, paramValue); return ret; }
        public OBrIMObj RemoveParam(string objID, string paramName) { var ret = RemoteSend("ParamRemove", objID, paramName); return ret; }

        public OBrIMObj RemoteSend(string method, string arg0 = null, string arg1 = null, string arg2 = null, string arg3 = null, string arg4 = null, string arg5 = null, string arg6 = null)
        {
            string s = (string)this.browser.Explorer.Document.InvokeScript("APIConn", new object[] { method, arg0, arg1, arg2, arg3, arg4, arg5, arg6 });
            if (s == null) { 
                return null;
            }

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var o = (Dictionary<string, object>) serializer.DeserializeObject(s);
            OBrIMObj ret = new OBrIMObj();
            ret.Parse(o);
            return ret;
        }
        
        public void RemoteReceive(string eventName)
        {
            if (eventName == "UserLoginSuccess")
            {
                browser.Hide();
            }
        }
    }
}
