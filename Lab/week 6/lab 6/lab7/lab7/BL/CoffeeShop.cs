using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.BL
{
    class CoffeeShop
    {
        public string name;
        public List<MenuItem> menuofshop =new List<MenuItem>() ;
        public List<string> ordereditems = new List<string>();

        public CoffeeShop()
        {

        }
        public CoffeeShop(string name)
        {
            this.name = name;
        }
    }
}
