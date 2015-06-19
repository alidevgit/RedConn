using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class RemoteValue
    {
        private object value;

        internal void Parse(object v)
        {
            if (v == null) return;

            if (!v.GetType().IsArray)
            {
                this.value = v;
                return;
            }

            RemoteValueList list = new RemoteValueList();
            object[] a = (object[])v;
            for(int i=0; i < a.Length; i++)
            {
                RemoteValue sv = new RemoteValue();
                sv.Parse(a[i]);
                list.Add(sv);
            }

            this.value = list;
        }

        public string AsText()
        {
            return Convert.ToString(this.value);
        }

        public double AsNumber()
        {
            try
            {
                return Convert.ToDouble(this.value);
            } 
            catch(Exception e)
            {
                return 0;
            }
        }

        public RemoteValueList AsList()
        {
            try
            {
                return (RemoteValueList)this.value;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool IsText()
        {
            return this.value.GetType() == typeof(string);
        }

        public bool IsList()
        {
            return this.value.GetType() == typeof(RemoteValueList);
        }

        public bool IsNumber()
        {
            return this.value.GetType() == typeof(int) ||
                   this.value.GetType() == typeof(double);
        }
    }
}
