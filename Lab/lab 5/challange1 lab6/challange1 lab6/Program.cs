using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange1.lab6.BL;
using challange1.lab6.UI;

namespace challange1.lab6
{
    class Program
    {
        static line data = new line();
        static mypoint data1 = new mypoint();
        static void Main()
        {
            int y = 0;
            string op = " ";
            do
            {
                op = curd.menu();
                if (op == "1")
                {
                    Console.Clear();
                    data = curd.makeLine();
                }
                else if (op == "2")
                {
                    Console.Clear();
                    mypoint b = new mypoint();
                    b = curd.updatebeginingpoint();
                    data.begin.setX(b.x);
                    data.begin.setY(b.y);
                }
                else if (op == "3")
                {
                    Console.Clear();
                    mypoint b = new mypoint();
                    b = curd.updatebeginingpoint();
                    data.end.setX(b.x);
                    data.end.setY(b.y);
                }
                else if (op == "4")
                {
                    Console.Clear();
                    curd.viewbeginingpoint(data);
                }
                else if (op == "5")
                {
                    Console.Clear();
                    curd.viewendpoint(data);
                }
                else if (op == "6")
                {
                    Console.Clear();
                    double length = data.getLength();
                    curd.showlength(length);
                }
                else if (op == "7")
                {
                    Console.Clear();
                    double gradient = data.getGradient();
                    curd.showgradient(gradient);
                }
                else if (op == "8")
                {
                    Console.Clear();
                    double dis = data.begin.Bdistancefromzero();
                    curd.showgradient(dis);
                }
                else if (op == "9")
                {
                    Console.Clear();
                    double dis = data.end.Bdistancefromzero();
                    curd.showgradient(dis);
                }
                Console.ReadLine();
            }
            while (op != "10");

        }
    }
}
