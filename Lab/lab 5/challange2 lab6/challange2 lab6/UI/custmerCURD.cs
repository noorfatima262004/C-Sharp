using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.BL;
using challange2_lab6.DL;

namespace challange2_lab6.UI
{
    class custmerCURD
    {
        public static void elseforUser1()
        {
            Console.WriteLine();
            Console.WriteLine(" No Product Available. Try again later!!!!");
            Console.ReadLine();
        }
        public static custmer buyproducts()
        {
            string pname;
            Console.WriteLine();
            Console.Write(" Enter product name you want to buy:");
            pname = Console.ReadLine();
            int quantity;
            Console.Write(" Enter quantity:");
            quantity = int.Parse(Console.ReadLine());
            custmer obj = new custmer(pname, quantity);
            return obj;
        }
        public static void elseforquantity()
        {
            Console.WriteLine();
            Console.WriteLine(" Not Enough stock available. Try again later !!!!");
        }
        public static void elseforprodutavalaible()
        {
            Console.WriteLine();
            Console.WriteLine(" Product not fouud. Plz enter valid product name");
        }
        public static void generateinvoice(float tax)
        {
            Console.WriteLine();
            Console.WriteLine(" Total bill after sale tax to be applied is: " + tax);
        }

        
        public static void viewallproductheaderUser()
        {
            Console.WriteLine();
            Console.WriteLine("          All Products");
            Console.WriteLine();
            Console.WriteLine("Name \t  Category  \t  Price");
        }
        public static void displayoption1User(product p)
        {
            Console.WriteLine(p.pname + "\t" + p.category + "\t" + p.price);
        }
    }
       
    
}
