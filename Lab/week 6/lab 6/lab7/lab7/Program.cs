using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7.BL;
using lab7.DL;
using lab7.UI;

namespace lab7
{
    class Program
    {
        public static void Main()
        {
            selftask1();
            Selftask2();
            Selftask3();
            Main1();
        }
        public static void selftask1()
        {

            student s1 = new student("Noor", 43, 175);
            student s2 = new student("Hufsa", 21, 211);
            student s3 = new student("Fatima", 22, 157);
            List<student> studentL = new List<student>() { s1, s2, s3 };
            List<student> sortL = studentL.OrderBy(o => o.rollN).ToList();
            Console.WriteLine("Name \t Roll No \t Ecat Marks");
            foreach (student s in sortL)
            {
                Console.WriteLine("{0} \t {1} \t\t {2} ", s.name, s.rollN, s.ecatM);
            }
            Console.Read();
        }
        public static void Selftask2()
        {
            List<string> name = new List<string>() { "Noor", "HUfsa", "leena", "Danish", "Bilal" };
            name.Sort();
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            List<float> num = new List<float>() { 1.2F, 2.5F, 5F };
            num.Sort();
            foreach (float f in num)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
        public static void Selftask3()
        {
            student s1 = new student("Noor", 43, 175);
            student s2 = new student("Leena", 21, 211);
            student s3 = new student("Hufsa", 22, 157);
            List<student> studentL = new List<student>() { s1, s2, s3 };
            List<student> sortL = studentL.OrderByDescending(o => o.rollN).ToList();
            Console.WriteLine("Name \t Roll No \t Ecat Marks");
            foreach (student s in sortL)
            {
                Console.WriteLine("{0} \t {1} \t\t {2} ", s.name, s.rollN, s.ecatM);
            }
            Console.Read();
        }



        public static void Main1()
        {
            CoffeeShop obj = CoffeeShopUI.name();
            string op = " ";
            while (op != "9")
            {
                op = CoffeeShopUI.menu(obj.name);
                Console.Clear();
                if (op == "1")
                {
                    MenuItem m = CoffeeShopUI.inputformenu();
                    CoffeeShopDL.addinlist(obj, m);
                }
                else if (op == "2")
                {
                    MenuItem m = CoffeeShopDL.productwithcheapestprice(obj);
                    CoffeeShopUI.viewcheapest(m);
                }
                else if (op == "3")
                {
                    CoffeeShopUI.viewdrinkmenu(obj);
                }
                else if (op == "4")
                {
                    CoffeeShopUI.viewfoodmenu(obj);
                }
                else if (op == "5")
                {
                    MenuItem m = CoffeeShopUI.addoredered();
                    bool check = CoffeeShopDL.checkavaliablity(obj, m);
                    if (check == true)
                    {
                        CoffeeShopDL.addproductintoorderedlist(obj, m);
                        Console.WriteLine("The ordered is added.");
                    }
                    else
                    {
                        CoffeeShopUI.ordernotavailable();
                    }
                }
                else if (op == "6")
                {
                    bool check = CoffeeShopDL.orderfullyavailablility(obj);
                    if (check == true)
                    {
                        CoffeeShopDL.readyorder(obj);
                        // CoffeeShopDL.remove(obj);

                    }
                    else
                    {
                        CoffeeShopUI.elseforfulldfillodered();
                    }
                }
                else if (op == "7")
                {
                    CoffeeShopDL.vieworder(obj);

                }
                else if (op == "8")
                {
                    float price = CoffeeShopDL.calculatetotal(obj);
                    Console.WriteLine("The total price is : " + price);
                }
                Console.ReadLine();
            }
        }

    }
}
