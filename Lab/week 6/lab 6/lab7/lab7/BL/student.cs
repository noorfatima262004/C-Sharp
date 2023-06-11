using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.BL
{
    class student
    {
        public string name;
        public int rollN;
        public int ecatM;

        public student()
        {

        }
        public student(string name, int rollN, int ecatM)
        {
            this.name = name;
            this.rollN = rollN;
            this.ecatM = ecatM;
        }
    }
}
