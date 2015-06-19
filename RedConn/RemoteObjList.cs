using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class RemoteObjList
    {
        private List<RemoteObj> items = new List<RemoteObj>();

        public RemoteObj Get(int index)
        {
            return items[index];
        }

        public void Add(RemoteObj item)
        {
            items.Add(item);
        }

        public void Set(int index, RemoteObj item)
        {
            items[index] = item;
        }

        public void Remove(RemoteObj item)
        {
            items.Remove(item);
        }

        public int Count()
        {
            return items.Count;
        }
    }
}
