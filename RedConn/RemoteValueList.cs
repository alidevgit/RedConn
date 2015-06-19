using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class RemoteValueList
    {
        private List<RemoteValue> items = new List<RemoteValue>();

        public RemoteValue Get(int index)
        {
            return items[index];
        }

        public void Add(RemoteValue item)
        {
            items.Add(item);
        }

        public void Set(int index, RemoteValue item)
        {
            items[index] = item;
        }

        public void Remove(RemoteValue item)
        {
            items.Remove(item);
        }

        public int Count()
        {
            return items.Count;
        }
    }
}
