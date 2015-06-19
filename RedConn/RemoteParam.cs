using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RedConn
{
    [ComVisible(true)]
    public class RemoteParam
    {
        public string Name = null;
        public string Expr = null;
        public string Type = null;
        public string Ref = null;
        public string UType = null;
        public string UCat = null;
        public string Desc = null;
        public string DisplayCategory = null;
        public string DisplayRole = null;
        public string DisplayWidth = null;

        public RemoteValue Value;
        
        public string Error = null;

        private RemoteConn Conn;
        public RemoteObj Parent;

        public RemoteParam(RemoteConn conn, RemoteObj parent)
        {
            this.Conn = conn;
            this.Parent = parent;
        }
        
        public void SetValue(string expr) {
            this.Expr = expr;
            this.Conn.SetParamValue(this.Parent.GetID(), this.Name, expr);
        }

        public void Update()
        {
            RemoteObj res = this.Conn.CreateParam(this.Parent.GetID(), this.Name, this.Type, this.Expr, this.Desc, this.UType, this.UCat);
        }

        internal void Parse(Dictionary<string, object> data)
        {
            if (data.ContainsKey("name")) this.Name = (string)data["name"];
            if (data.ContainsKey("expr")) this.Expr = Convert.ToString(data["expr"]);
            if (data.ContainsKey("desc")) this.Desc = (string)data["ucat"];
            if (data.ContainsKey("displaycat")) this.DisplayCategory = (string)data["displaycat"];
            if (data.ContainsKey("displayrole")) this.DisplayRole = (string)data["displayrole"];
            if (data.ContainsKey("displaywidth")) this.DisplayWidth = data["displaywidth"].ToString();

            if (data.ContainsKey("type")) this.Type = (string)data["type"];
            if (data.ContainsKey("ref")) this.Ref = (string)data["ref"];
            if (data.ContainsKey("utype")) this.UType = (string)data["utype"];
            if (data.ContainsKey("ucat")) this.UCat = (string)data["ucat"];
            
            if (data.ContainsKey("value"))
            {
                this.Value = new RemoteValue();
                this.Value.Parse(data["value"]);
            }

            if (data.ContainsKey("error"))
            {
                this.Error = (string)data["error"];
            }
        }


        public static string UnitTypeToString(int u) {
            if (u == 0) return "None";
            if (u == 1) return "Length";
            if (u == 2) return "Force";
            if (u == 3) return "Angle";
            if (u == 4) return "Temperature";
            if (u == 5) return "Moment";
            if (u == 6) return "Stress";
            if (u == 7) return "Density";
            if (u == 8) return "PerTemperature";
            if (u == 9) return "Inertia";
            if (u == 10) return "Velocity";
            if (u == 11) return "Acceleration";
            if (u == 12) return "ForcePerLength";
            if (u == 13) return "MomentPerLength";
            if (u == 14) return "Volume";
            if (u == 15) return "Curvature";
            if (u == 16) return "Warp";
            return "None";
        }

        public static int StringToUnitType(string u)
        {
            if (u == null) return 0;

            u = u.ToLower();
            if (u == "none") return 0;
            if (u == "length") return 1;
            if (u == "force") return 2;
            if (u == "angle") return 3;
            if (u == "temperature") return 4;
            if (u == "moment") return 5;
            if (u == "stress") return 6;
            if (u == "density") return 7;
            if (u == "pertemperature") return 8;
            if (u == "inertia") return 9;
            if (u == "velocity") return 10;
            if (u == "acceleration") return 11;
            if (u == "forceperlength") return 12;
            if (u == "momentperlength") return 13;
            if (u == "volume") return 14;
            if (u == "curvature") return 15;
            if (u == "warp") return 16;
            return 0;
        }

    }
}
