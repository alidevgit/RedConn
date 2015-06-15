using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RedConn
{
    [ComVisible(true)]
    public class OBrIMParam
    {
        public string Name = null;
        public string Expr = null;
        public string Type = null;
        public string Ref = null;
        public string UType = null;
        public string UCat = null;
        
        public OBrIMValue Value;
        
        public string Error = null;
        
        internal void Parse(Dictionary<string, object> data)
        {
            if (data.ContainsKey("name")) this.Name = (string)data["name"];
            if (data.ContainsKey("expr")) this.Expr = Convert.ToString(data["expr"]);
            
            if (data.ContainsKey("type")) this.Type = (string)data["type"];
            if (data.ContainsKey("ref")) this.Ref = (string)data["ref"];
            if (data.ContainsKey("utype")) this.UType = (string)data["utype"];
            if (data.ContainsKey("ucat")) this.UCat = (string)data["ucat"];

            if (data.ContainsKey("value"))
            {
                this.Value = new OBrIMValue();
                this.Value.Parse(data["value"]);
            }

            if (data.ContainsKey("error"))
            {
                if (data["error"] is Dictionary<string, Object>)
                {
                    Dictionary<string, Object> d = (Dictionary<string, Object>)data["error"];
                    this.Error = (string)d["description"];
                }
                else
                {
                    this.Error = (string)data["error"];
                }
            }
        }

    }
}
