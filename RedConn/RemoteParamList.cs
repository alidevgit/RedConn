using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class RemoteParamList
    {
        private List<RemoteParam> items = new List<RemoteParam>();

        public RemoteParam Get(int index)
        {
            return items[index];
        }

        public void Add(RemoteParam item)
        {
            items.Add(item);
        }

        public void Set(int index, RemoteParam item)
        {
            items[index] = item;
        }

        public void Remove(RemoteParam item)
        {
            items.Remove(item);
        }

        public int Count()
        {
            return items.Count;
        }
    }
}
