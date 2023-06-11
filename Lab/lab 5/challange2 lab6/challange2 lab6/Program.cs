using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.BL;
using challange2_lab6.UI;
using challange2_lab6.DL;

namespace challange2_lab6
{
    class Program
    {

        static void Main()
        {

            MuserList.Readdata();
            string op;
            do
            {
                op = MuserCURD.menu();
                if (op == "1")
                {
                    Console.Clear();
                    Muser data = MuserCURD.signIN();
                    if (data != null)
                    {
                        data = MuserList.checkuser(data);
                        if (data == null)
                        {

                            Console.WriteLine("Invalid User");

                        }
                        else if (data.rolecheck())
                        {
                            Console.WriteLine("Admin Menu ");
                            string op1 = " ";
                            while (op1 != "6")
                            {
                                op1 = MuserCURD.Adminmenu();
                                if (op1 == "1")
                                {
                                    product data1 = productCURD.addProduct();
                                    if (data1 != null)
                                    {
                                        productList.addintoLists(data1);
                                    }
                                }
                                else if (op1 == "2")
                                {
                                    productList.productView();
                                    Console.ReadLine();

                                }
                                else if (op1 == "3")
                                {
                                    productCURD.taxcalu();
                                    Console.ReadLine();

                                }
                                else if (op1 == "4")
                                {
                                    productCURD.thershold();
                                    Console.ReadLine();

                                }
                                else if (op1 == "5")
                                {
                                    product products = productList.highest();
                                    productCURD.highest(products);
                                    Console.ReadLine();

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("User Menu ");

                            string op2 = " ";
                            while (op2 != "4")
                            {
                                op2 = MuserCURD.Usermenu();
                                if (op2 == "1")
                                {
                                    custmer cus = new custmer();
                                    Console.Clear();
                                    productList.productView();
                                    int count = productList.displayproductUser();
                                    if (count == 0)
                                    {
                                        custmerCURD.elseforUser1();
                                    }
                                    Console.ReadKey();
                                }

                                else if (op2 == "2")
                                {
                                    Console.Clear();
                                    custmer Orderedproduct = custmerCURD.buyproducts();
                                    bool availa = productList.validtionondata(Orderedproduct);
                                    if (availa)
                                    {
                                        bool quan = productList.validationonquantity(Orderedproduct);
                                        if (quan)
                                        {
                                            productList.addproductincustmerlist(Orderedproduct);
                                            productList.decreasedquantity(Orderedproduct);
                                        }
                                        else
                                        {
                                            custmerCURD.elseforquantity();
                                        }
                                    }
                                    Console.ReadKey();
                                    Console.ReadKey();
                                }
                                else if (op2 == "3")
                                {
                                    custmer s = new custmer();
                                    Console.Clear();
                                    custmerCURD.generateinvoice(productList.generateinvoicebill(s));
                                }
                                Console.Read();
                                Console.ReadKey();

                            }
                        }
                    }
                }

                else if (op == "2")
                {
                    Console.Clear();
                    Muser data2 = MuserCURD.signUp();
                    if (data2 != null)
                    {
                        MuserList.addUserInList(data2);
                        MuserList.WriteInFile(data2);
                    }
                }

                Console.ReadLine();
            }
            while (op != "3");
            {
              
            }
        }   
    }
}
   