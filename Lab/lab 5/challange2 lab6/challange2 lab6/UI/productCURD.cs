using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.BL;
using challange2_lab6.DL;

namespace challange2_lab6.UI
{
    class productCURD
    {
        public static product addProduct()
        {
            Console.Clear();
            Console.Write("ENter name of Product: ");
            string name = Console.ReadLine();
            Console.Write("ENter category: ");
            string category = Console.ReadLine();
            Console.Write("ENter Price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("ENter Quantity: ");
            int quantityS = int.Parse(Console.ReadLine());
            Console.Write("ENter Minmum: ");
            int quantityM = int.Parse(Console.ReadLine());
            product objP = new product(name, category, price, quantityS, quantityM);
            return objP;
        }
        public static void taxcalu()
        {
            float taxes;
            Console.Clear();

            taxes = productList.taxPrice();
            Console.WriteLine(" Tax Price is: " + taxes);


        }
        public static void productView(product p)
        {
            Console.WriteLine();
            Console.WriteLine("                 All Products                 ");
            Console.WriteLine();
            Console.WriteLine("Name \tCategory\tPrice\tStock\tTHreshold value");
            Console.WriteLine();
        }
        public static void displayallproduct(product p)
        {
            Console.WriteLine(p.pname + "\t" + p.category + "\t" + p.price + "\t" + p.Stockquantity + "\t" + p.minimumquantity);
            Console.ReadLine();
        }
    
        public static void highest(product p)
        {
            Console.WriteLine();
            Console.WriteLine("          Product With highest Price               ");
            Console.WriteLine();
            Console.WriteLine("Name \tCategory\tPrice\tStock");
            Console.WriteLine();
            Console.WriteLine(p.pname + "\t" + p.category + "\t" + p.price + "\t" + p.Stockquantity);
        }
       public static void thershold()
        {
            Console.Clear();
          
                string order = productList.orderproduct();
            if (order != " ")
            {
                Console.WriteLine("item to be order :  " + order);
            }


            Console.ReadKey();
        }
    }
}
