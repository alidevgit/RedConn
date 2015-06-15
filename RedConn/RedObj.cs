using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class OBrIMObj
    {
        public bool Success;
        public string Error;
        public string ID;
        public string Name;

        public string FirstName;
        public string LastName;
        public string Email;

        public OBrIMObjList Objects = new OBrIMObjList();
        public OBrIMParamList Params = new OBrIMParamList();
        
        internal void Parse(Dictionary<string, object> data) 
        {
            if (data.ContainsKey("status")) this.Success = ((string)data["status"]) == "success";
            if (data.ContainsKey("error")) this.Error = (string) data["error"];
            if (data.ContainsKey("id")) this.ID = (string) data["id"];
            if (data.ContainsKey("name")) this.Name = (string)data["name"];

            if (data.ContainsKey("firstname")) this.FirstName = (string)data["firstname"];
            if (data.ContainsKey("lastname")) this.LastName = (string)data["lastname"];
            if (data.ContainsKey("email")) this.Email = (string)data["email"];

            if (data.ContainsKey("objects")) {
                object[] objects = (object[]) data["objects"];
                for(int i=0; i < objects.Length; i++)
                {
                    OBrIMObj o = new OBrIMObj();
                    o.Parse((Dictionary<string, object>)objects[i]);
                    this.Objects.Add(o);
                }
            }

            if (data.ContainsKey("params"))
            {
                object[] parameters = (object[])data["params"];
                for (int i = 0; i < parameters.Length; i++)
                {
                    OBrIMParam p = new OBrIMParam();
                    p.Parse((Dictionary<string, object>)parameters[i]);
                    this.Params.Add(p);
                }
            }
        }
    }
}


