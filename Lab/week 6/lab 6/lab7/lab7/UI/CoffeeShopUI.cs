using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7.BL;
using lab7.DL;

namespace lab7.UI
{
    class CoffeeShopUI
    {
        public static string menu(string name)
        {
            Console.Clear();
            string option = " ";
            Console.WriteLine("Welcome to the  " + name + "'s  Coffe Shop");
            Console.WriteLine();
            Console.WriteLine(" 1. Add a menu item");
            Console.WriteLine(" 2. View the Cheapest menu in the menu");
            Console.WriteLine(" 3. View the drink's menu");
            Console.WriteLine(" 4. View the food's menu");
            Console.WriteLine(" 5. Add Order");
            Console.WriteLine(" 6. Fullfill the Order");
            Console.WriteLine(" 7. View the Orders's List");
            Console.WriteLine(" 8. Total Payable Amount");
            Console.WriteLine(" 9. Exit");
            Console.Write(" Enter your Choice: ");
            option = Console.ReadLine();
            return option;
        }
        public static CoffeeShop name()
        {
            string name;
            Console.Write("Enter the name of Shop :");
            name = Console.ReadLine();
            CoffeeShop nameofshop = new CoffeeShop(name);
            return nameofshop;
        }
        public static MenuItem inputformenu()
        {
            Console.WriteLine();
            Console.Write(" Enter name of the product: ");
            string name = Console.ReadLine();
            Console.Write(" ENter type of product: ");
            string type = Console.ReadLine();
            Console.Write(" Enter price of product: ");
            float price = float.Parse(Console.ReadLine());
            MenuItem obj = new MenuItem(name, type, price);
            return obj;
        }
        public static void viewcheapest(MenuItem obj)
        {
            Console.WriteLine();
            Console.WriteLine(" Name\tType\tPrice");
            Console.WriteLine();
            Console.WriteLine(obj.name + " \t" + obj.type + "\t" + obj.price);
        }
        public static void viewdrinkmenu(CoffeeShop obj)
        {
            Console.WriteLine("Name\tType\tPrice");
            Console.WriteLine();
            for (int x = 0; x < obj.menuofshop.Count; x++)
            {
                if (obj.menuofshop[x].type.ToLower() == "drink")
                {
                    Console.WriteLine(obj.menuofshop[x].name + "\t" + obj.menuofshop[x].type + "\t" + obj.menuofshop[x].price);
                }
            }
        }
        public static void viewfoodmenu(CoffeeShop obj)
        {
            Console.WriteLine("Name\tType\tPrice");
            Console.WriteLine();
            for (int x = 0; x < obj.menuofshop.Count; x++)
            {
                if (obj.menuofshop[x].type.ToLower() == "food")
                {
                    Console.WriteLine(obj.menuofshop[x].name + "\t" + obj.menuofshop[x].type + "\t" + obj.menuofshop[x].price);
                }
            }
        }
        public static MenuItem addoredered()
        {
            Console.WriteLine();
            Console.Write(" Enter the name of product: ");
            string name = Console.ReadLine();
            MenuItem obj = new MenuItem(name);
            return obj;
        }
        public static void ordernotavailable()
        {
            Console.WriteLine();
            Console.WriteLine(" The item is currently unavailable");
        }
        public static void elseforfulldfillodered()
        {
            Console.WriteLine();
            Console.WriteLine(" All Ordered has been fullfilled");
        }
        public static void readyorder(string shop)
        {
            Console.WriteLine();
            Console.WriteLine("Your " + shop + " is prepared .");
        }
       
        public static void printorderlist(int x, string shop)
        {
            Console.WriteLine(x + ". " + shop);
        }

    }
}
