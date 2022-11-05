using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBO_1315_2021_lab1
{
    internal class Item
    {
        public int value;
        public Item? next;

        public Item(int value, Item? next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
}
