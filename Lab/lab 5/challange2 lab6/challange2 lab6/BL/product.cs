using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.DL;
using challange2_lab6.UI;

namespace challange2_lab6.BL
{
    class product
    {
        public product()
        {

        }
        public product(string name , string  category, float price , int Stockquantity , int minimumquantity)
        {
            this.pname = name;
            this.category = category;
            this.price = price;
            this.minimumquantity = minimumquantity;
            this.Stockquantity= Stockquantity;
        }
        public string pname;
        public string category;
        public float price;
        public int minimumquantity;
        public int Stockquantity;
        public float tax;
    }
}
