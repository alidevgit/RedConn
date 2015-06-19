using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class RemoteObj
    {
        public bool Success;
        public string Error;
        public string ID;
        public string Name;

        public string FirstName;
        public string LastName;
        public string Email;

        public RemoteObjList Objects = new RemoteObjList();
        public RemoteParamList Params = new RemoteParamList();

        private RemoteConn Conn;
        private RemoteObj Parent;

        public RemoteObj(RemoteConn conn, RemoteObj parent)
        {
            this.Conn = conn;
            this.Parent = parent;
        }

        public string GetID() { return this.GetParam("ID").Expr; }
        public string GetName() { return this.GetParam("N").Expr; }
        public string GetType() { return this.GetParam("T").Expr; }

        internal void Parse(Dictionary<string, object> data) 
        {
            if (data.ContainsKey("status")) this.Success = ((string)data["status"]) == "success";
            if (data.ContainsKey("error")) this.Error = (string) data["error"];
            
            if (data.ContainsKey("id"))  this.ID = (string) data["id"];
            
            if (data.ContainsKey("name")) this.Name = (string)data["name"];

            if (data.ContainsKey("firstname")) this.FirstName = (string)data["firstname"];
            if (data.ContainsKey("lastname")) this.LastName = (string)data["lastname"];
            if (data.ContainsKey("email")) this.Email = (string)data["email"];

            if (data.ContainsKey("params"))
            {
                object[] parameters = (object[])data["params"];
                for (int i = 0; i < parameters.Length; i++)
                {
                    RemoteParam p = new RemoteParam(this.Conn, this);
                    p.Parse((Dictionary<string, object>)parameters[i]);
                    this.Params.Add(p);
                }
            }

            if (data.ContainsKey("objects")) {
                object[] objects = (object[]) data["objects"];
                for(int i=0; i < objects.Length; i++)
                {
                    RemoteObj o = new RemoteObj(this.Conn, this);
                    o.Parse((Dictionary<string, object>)objects[i]);
                    this.Objects.Add(o);
                }
            }
        }
    
        public RemoteObj GetObject(string ID){
            if (this.GetParam("ID").Value.AsText() == ID) return this;
            
            for (int i = 0; i < this.Objects.Count(); i++)
            {
                RemoteObj o = this.Objects.Get(i).GetObject(ID);
                if (o != null) return o;
            }

            return null;
        }

        public RemoteParam GetParam(string parameterName)
        {
            for (int i = 0; i < this.Params.Count(); i++)
            {
                RemoteParam p = this.Params.Get(i);
                if (p.Name == parameterName) return p;
            }

            return null;
        }
    }
}


