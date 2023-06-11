using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challange2_lab6.UI;
using challange2_lab6.DL;

namespace challange2_lab6.BL
{
    class Muser
    {
        public Muser()
        {

        }
        public Muser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Muser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
           
        }
        public string name;
        public string password;
        public string role;
       
       

        public  bool rolecheck()
        {
            if (role == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
