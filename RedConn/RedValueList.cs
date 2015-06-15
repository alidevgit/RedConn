using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class OBrIMValueList
    {
        private List<OBrIMValue> items = new List<OBrIMValue>();

        public OBrIMValue Get(int index)
        {
            return items[index];
        }

        public void Add(OBrIMValue item)
        {
            items.Add(item);
        }

        public void Set(int index, OBrIMValue item)
        {
            items[index] = item;
        }

        public void Remove(OBrIMValue item)
        {
            items.Remove(item);
        }

        public int Count()
        {
            return items.Count;
        }
    }
}
