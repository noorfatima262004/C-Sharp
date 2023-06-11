using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange1.lab6.BL
{
    class line
    {
        public line(mypoint begin, mypoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public line()
        {

        }
        public mypoint begin;
        public mypoint end;
        public mypoint getbegin()
        {
            return begin;
        }
        public mypoint getend()
        {
            return end;
        }
        public void setBeginPoint(mypoint begin)
        {
            this.begin = begin;
        }
        public void setEndPoint(mypoint end)
        {
            this.end = end;
        }
        public double getLength()
        {
            double distane = (((end.x - begin.x) * (end.x - begin.x)) + ((end.y - begin.y) * (end.y - begin.y)));
            distane = Math.Sqrt(distane);
            return distane;
        }

        public double getGradient()
        {
            double distane1 = (end.y - begin.y);
            double distane2 = (end.x - begin.x);
            double distane = distane1 / distane2;
            return distane;
        }
    }

}
