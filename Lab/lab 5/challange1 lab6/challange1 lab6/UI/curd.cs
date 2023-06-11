using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange1.lab6.BL;

namespace challange1.lab6.UI
{
    class curd
    {
        public static line makeLine()
        {
            Console.WriteLine(" ******** Make the Line .****** ");
            Console.Write("Enter any point to set X cordinate of begning point. ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter any point to set Y cordinate of begning point. ");
            int x2 = int.Parse(Console.ReadLine());
            mypoint setbegingpoint = new mypoint(x1, x2);
            Console.Write("Enter any point to set X cordinate of end point. ");
            int x21 = int.Parse(Console.ReadLine());
            Console.Write("Enter any point to set X cordinate of end point . ");
            int x22 = int.Parse(Console.ReadLine());
            mypoint setbegingpoint1 = new mypoint(x21, x22);
            line setline = new line(setbegingpoint, setbegingpoint1);
            return setline;
        }
        public static void viewbeginingpoint(line lines)
        {

            Console.WriteLine(" ******** begining point .****** ");
            int startpointx = lines.begin.getX();
            int startpointy = lines.begin.getY();
            Console.WriteLine("         x =  " + startpointx);
            Console.WriteLine("         y =  " + startpointy);
        }
        public static void viewendpoint(line lines)
        {

            Console.WriteLine(" ******** End point .****** ");
            int endpointx = lines.end.getX();
            int endpointy = lines.end.getY();

            Console.WriteLine("         x =  " + endpointx);
            Console.WriteLine("         y =  " + endpointy);
        }
        public static mypoint updatebeginingpoint()
        {

            Console.WriteLine(" ******** update  points .****** ");
            Console.Write("Enter any point to set X cordinate of begning point. ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter any point to set Y cordinate of begning point. ");
            int x2 = int.Parse(Console.ReadLine());
            mypoint points = new mypoint(x1, x2);
            return points;
        }
        public static void showlength(double length)
        {

            Console.WriteLine(" ******** Length of line .****** ");
            Console.Write("The length of Line is :  " + length);

        }
        public static void showgradient(double ga)
        {

            Console.WriteLine(" ******** Length of line .****** ");
            Console.Write("The Gradient of Line is :  " + ga);
        }
        public static string menu()
        {
            Console.Clear();
            string option;
            Console.WriteLine(" Press 1 to Make a Line ");
            Console.WriteLine(" Press 2 to update begin point ");
            Console.WriteLine(" Press 3 to update end point. ");
            Console.WriteLine(" Press 4 to show the begin point ");
            Console.WriteLine(" Press 5 to show the end point ");
            Console.WriteLine(" Press 6 to get the length of line ");
            Console.WriteLine(" Press 7 to get gradient of Line ");
            Console.WriteLine(" Press  8 to find the distance of begin point from zero cordinates. ");
            Console.WriteLine(" Press  9 to find the distance of begin point from zero cordinates. ");
            Console.WriteLine(" Press 10 Exist ");
            Console.Write(" Select option:  ");
            option = Console.ReadLine();
            return option;
        }
    }
}
