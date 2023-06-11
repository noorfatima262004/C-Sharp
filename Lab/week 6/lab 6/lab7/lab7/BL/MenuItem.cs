using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.BL
{
    class MenuItem
    {
        public string name;
        public string type;
        public float price;
        public MenuItem()
        {

        }
        public MenuItem(string name, string type, float price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public MenuItem(string name)
        {
            this.name = name;
        }
    }

}
