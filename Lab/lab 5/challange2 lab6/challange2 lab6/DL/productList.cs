using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.BL;
using challange2_lab6.UI;

namespace challange2_lab6.DL
{
    class productList
    {
        static List<custmer> cus = new List<custmer>();
        static List<product> products = new List<product>();
        public static void addintoLists(product P)
        {
            products.Add(P);
        }
        public static void productView()
        {
            Console.WriteLine();
            for (int x = 0; x < products.Count; x++)
            {
                productCURD.displayallproduct(products[x]);
            }
        }
        public static product highest()
        {
            float highest = 0;
            float current = 0;
            int index = 0;
            for (int x = 0; x < products.Count; x++)
            {
                current = products[x].price;
                if (highest < current)
                {
                    highest = current;
                    index = x;
                }
            }
            return products[index];

        }
        public static float taxPrice()
        {
            float tax = 0;
            foreach (product pro in products)
            {
                if (pro.category == "grocery")
                {
                    tax = pro.price * 10 / 100;
                }
                if (pro.category == "fruits")
                {
                    tax = (pro.price * 5) / 100;
                }
                else
                {
                    tax = pro.price * 15 / 100;
                }
            }
            return tax;
        }
        public static string orderproduct()
        {
            string order = " ";
            foreach (product pro in products)
                if (pro.minimumquantity < 10)
                {
                    order = pro.pname;
                }

            return order;
        }
        public static int displayproductUser()
        {
            return products.Count;
        }
        public static void addproductincustmerlist(custmer cust)
        {
            cus.Add(cust);
        }
        public static int displayproductUser(custmer cus)
        {
            int count = 0;
            for (int x = 0; x < products.Count; x++)
            {
                custmerCURD.displayoption1User(products[x]);
                count++;
            }
            return count;
        }
        public static void decreasedquantity(custmer p)
        {
            for (int x = 0; x < products.Count; x++)
            {
                if (products[x].pname == p.proname)
                {
                    products[x].Stockquantity = products[x].Stockquantity - p.quantity;
                }
            }
        }
        public static bool validtionondata(custmer p)
        {
            bool check = false;
            for (int x = 0; x < products.Count; x++)
            {
                if (p.proname == products[x].pname)
                {
                    check = true;
                }
            }
            return check;
        }
        public static bool validationonquantity(custmer p)
        {
            bool check = false;
            for (int x = 0; x < products.Count; x++)
            {
                if (p.proname == products[x].pname)
                {
                    if (p.quantity < products[x].Stockquantity)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }
        public static float generateinvoicebill(custmer s)
        {
            float total = 0;
            for (int x = 0; x < products.Count; x++)
            {
                if (s.proname == products[x].pname)
                {

                    total = products[x].price * s.quantity;
                    Console.WriteLine("Total:" + total);
                    Console.ReadLine();
                    total = total - (products[x].tax * s.quantity);

                }
            }
            return total;
        }
    }
}
