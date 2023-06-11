using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange1.lab6.BL
{
    public class mypoint
    {

        public mypoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public mypoint()
        {

        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public double distancewithcord(int x, int y)
        {
            double distane = (((this.x - x) * (this.x - x)) + ((this.y - y) * (this.y - y)));
            distane = Math.Sqrt(distane);
            return distane;
        }
        public double distancewithobject(mypoint other)
        {
            double distane = (((x - other.x) * (x - other.x)) + ((y - other.y) * (y - other.y)));
            distane = Math.Sqrt(distane);
            return distane;
        }
        public double Bdistancefromzero()
        {
            double distane = (((this.x - 0) * (this.x - 0)) + ((this.y - 0) * (this.y - 0)));
            distane = Math.Sqrt(distane);
            return distane;
        }
    }
}
