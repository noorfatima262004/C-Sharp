using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.DL;
using challange2_lab6.UI;

namespace challange2_lab6.BL
{
    class custmer
    {
        
        public string proname;
        public int quantity;
        public List<custmer> products;
        public custmer()
        {

        }
        public custmer(string proname , int quantity)
        {
            this.proname = proname;
            this.quantity = quantity;
            products = new List<custmer>();
        }
        

       
    }
}
