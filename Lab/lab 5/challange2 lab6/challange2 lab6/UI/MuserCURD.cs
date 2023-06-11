using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.BL;
using challange2_lab6.DL;

namespace challange2_lab6.UI
{
    class MuserCURD
    {
       public static string menu()
        {
            Console.Clear();

            string option;
            Console.WriteLine("Press 1 to Sign In");
            Console.WriteLine("Press 2 to Sign Up");
            Console.WriteLine("Press 3 to Exit");
            option = Console.ReadLine();
            return option;
        }
       public static string Adminmenu()
        {
            string option;
            Console.Clear();
            Console.WriteLine("Press 1 Add Products");
            Console.WriteLine("Press 2 View All products");
            Console.WriteLine("Press 3 to FInd the products with highest price");
            Console.WriteLine("Press 4 View sales Tax of All products");
            Console.WriteLine("Press 5 to order products");
            Console.WriteLine("Press 6 eXIT");
            option = Console.ReadLine();
            return option;
        }
        public static string Usermenu()
        {
            string option;
            Console.Clear();
            Console.WriteLine("Press 1 View All products");
            Console.WriteLine("Press 2 to Buy Products");
            Console.WriteLine("Press 3 to Generate Invoice");
            Console.WriteLine("Press 4 Exit");
            option = Console.ReadLine();
            return option;
        }
        public static Muser signIN()
        {
            string name;
            string pass;
            Console.Write("Enter your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter your password : ");
            pass = Console.ReadLine();
            Muser obj = new Muser(name, pass);
            return obj;
        }
        public static Muser signUp()
        {
            string name;
            string pass;
            string role;
            Console.Write("Enter your Name : ");
            name = Console.ReadLine();
            Console.Write("Enter your password : ");
            pass = Console.ReadLine();
            Console.Write("Enter your Role : ");
            role = Console.ReadLine();
            Muser obj = new Muser(name, pass , role);
            return obj;
        }
        
    }
}
