using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5.BL
{
    class customer
    {
        public string custmerName;
        public string custmerAdress;
        public string custmerContact;
        public List<product> products = new List<product>();
        public customer()
        {

        }
        public List<product> getAllProduct()
        {
            return products;
        }
        public void storeInList(product p)
        {
            products.Add(p);
        
    }
       
    }
}
