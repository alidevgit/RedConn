using System;
using System.Collections.Generic;
using System.Text;

namespace RedConn
{
    public class OBrIMParamList
    {
        private List<OBrIMParam> items = new List<OBrIMParam>();

        public OBrIMParam Get(int index)
        {
            return items[index];
        }

        public void Add(OBrIMParam item)
        {
            items.Add(item);
        }

        public void Set(int index, OBrIMParam item)
        {
            items[index] = item;
        }

        public void Remove(OBrIMParam item)
        {
            items.Remove(item);
        }

        public int Count()
        {
            return items.Count;
        }
    }
}
