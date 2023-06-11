using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using challange2_lab6.BL;
using challange2_lab6.UI;

namespace challange2_lab6.DL
{
    
    class MuserList
    {
        static string path = "E:\\c#\\challange2 lab6\\challange2 lab6\\bin\\Debug\\customer.txt";
        static List<Muser> users = new List<Muser>();
        public static void addUserInList(Muser user)
        {
            users.Add(user);
        }
        public static void Readdata()
        {
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path);
                string line;
                while ((line = myFile.ReadLine()) != null)
                {
                    string[] temp = line.Split(',');
                    Muser u = new Muser(temp[0], temp[1], temp[2]);
                    users.Add(u);
                }

                myFile.Close();
            }
            else
            {
                Console.WriteLine("File not found!!");
                Console.ReadKey();
            }
        }
            public static void WriteInFile(Muser u)
            {
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(u.name + "," + u.password + "," + u.role);
                file.Flush();
                file.Close();


            }   
        
        public static Muser checkuser(Muser user)
        {
            foreach(Muser storedUser in users)
            {
                if(user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }
    }
}
