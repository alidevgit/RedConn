using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class OBrIMObjList
    {
        private List<OBrIMObj> items = new List<OBrIMObj>();

        public OBrIMObj Get(int index)
        {
            return items[index];
        }

        public void Add(OBrIMObj item)
        {
            items.Add(item);
        }

        public void Set(int index, OBrIMObj item)
        {
            items[index] = item;
        }

        public void Remove(OBrIMObj item)
        {
            items.Remove(item);
        }

        public int Count()
        {
            return items.Count;
        }
    }
}
