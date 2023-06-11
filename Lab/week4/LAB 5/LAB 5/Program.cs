using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_5.BL;

namespace LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // t1();
            t2();

        }
        public static void t1()
        {
            List<student> student = new List<student>();
            student objStu = new student();
            int option = 0;

            while (option != 5)
            {
                option = menu();
                Console.Clear();
                if (option == 1)
                {

                    addS(student);
                }
                if (option == 2)
                {
                    objStu.viewdata(student);
                }
                if (option == 3)
                {
                    meritC(student);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    checkS(student);
                    Console.ReadKey();
                }

                Console.Clear();
            }

        }
        public static int menu()
        {
            int choice = 0;
            Console.WriteLine("Press 1 To Add Student Details");
            Console.WriteLine("Press 2 To View Student Details");
            Console.WriteLine("Press 3 To Calculate Merit");
            Console.WriteLine("Press 4 To See Students Scholarship Status");
            Console.Write("Enter Your Choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void addS(List<student> student)
        {
            Console.Clear();
            student objinout = new student();

            Console.WriteLine("Enter Your Name : ");
            objinout.sname = Console.ReadLine();
            Console.WriteLine("Enter Your RollNo : ");
            objinout.RollNo = Console.ReadLine();
            Console.WriteLine("Enter Your CGPA : ");
            objinout.cpga = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Matric Marks : ");
            objinout.mmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Fsc marks : ");
            objinout.fmarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Ecat marks : ");
            objinout.emarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your homeTown : ");
            objinout.hometown = Console.ReadLine();
            Console.WriteLine("Enter if you are hostilde(hostilide) : ");
            objinout.ishostelide = Console.ReadLine();
            student.Add(objinout);
        }
        public static void meritC(List<student> student)
        {

            for (int x = 0; x < student.Count; x++)
            {
                student[x].meritcalculator();
                Console.WriteLine("Name of Student is: " + student[x].sname);
                Console.WriteLine("Merit is: " + student[x].merit);
            }
        }
        public static void checkS(List<student> student)
        {
            for (int x = 0; x < student.Count; x++)
            {
                student[x].isScholarship();
                if (student[x].scholarship == true)
                {
                    Console.WriteLine("Eligible");
                }
                else
                {
                    Console.WriteLine(" Not Eligible");
                }

            }
        }
       
        static void t2()
        {

            List<customer> customers = new List<customer>();
            List<product> product = new List<product>();
            int option;
            customer customer = new customer();
            product products = new product();
        
            do
            {
                option = menu1();
                if (option == 1)
                {
                    Console.ReadLine();
                    Console.Clear();
                    customer = takeInPutForInformation();
                    storeInformationInList(customers, customer);
                    Console.ReadKey();

                }
                else if (option == 2)
                {
                    Console.Clear();
                    products = addProducts();
                    customer.storeInList(products);
                    Console.ReadKey();

                }
                else if (option == 3)
                {
                    Console.Clear();
                    viewCustmerInformation(customers);
                    Console.ReadKey();

                }
                else if (option == 4)
                {
                    Console.Clear();
                    product = customer.getAllProduct();
                    viewAllProduct(product);
                    Console.ReadKey();

                }
                else if (option == 5)
                { 
                    Console.Clear();
                float tex = products.calculateText(customer);
                    viewTex(tex);
                    Console.ReadKey();

                }

            }
            while (option != 6);
            Console.ReadKey();
        }
        public static int menu1()
        {
            Console.Clear();
            Console.WriteLine("1.enter information of customer:");
            Console.WriteLine("2.enter products:");
            Console.WriteLine("3.view customer information:");
            Console.WriteLine("4.view total purchased:");
            Console.WriteLine("5.calculate tex:");
            Console.WriteLine("6.exit:");

            int option = int.Parse(Console.ReadLine());
            return option;

        }
        public static customer takeInPutForInformation()
        {
            customer customer = new customer();
            Console.WriteLine("enter your name: ");
            customer.custmerName = Console.ReadLine();
            Console.WriteLine("enter your contact number: ");
            customer.custmerContact = Console.ReadLine();
            Console.WriteLine("enter your adress: ");
            customer.custmerAdress = Console.ReadLine();
            return customer;

        }
        public static void storeInformationInList(List<customer> cus, customer custmer)
        {
            cus.Add(custmer);
        }
        public static product addProducts()
        {
            product products = new product();
            Console.WriteLine("enter product name:");
            products.name = Console.ReadLine();
            Console.WriteLine("enter product category:");
            products.category = Console.ReadLine();
            Console.WriteLine("enter product price:");

            products.price = float.Parse(Console.ReadLine());
            return products;

        }
        public static void viewCustmerInformation(List<customer> custmers)
        {
            Console.WriteLine("name\t\tcontact\t\t\tadress:");
            foreach (customer storedCust in custmers)
            {
                Console.WriteLine(storedCust.custmerName + "\t\t" + storedCust.custmerContact + "\t\t" + storedCust.custmerAdress);
            }
        }
        public static void viewAllProduct(List<product> pro)
        {
            Console.WriteLine("name\t\tCetagory\t\t\tprice:");
            foreach (product storedPro in pro)
            {
                Console.WriteLine(storedPro.name + "\t\t" + storedPro.category + "\t\t" + storedPro.price);
            }
        }
        public static void viewTex(float tex)
        {
            Console.WriteLine("total tex is:" + tex);
        }
    }
}
    