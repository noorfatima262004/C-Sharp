using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab7.BL;
using lab7.UI;

namespace lab7.DL
{
    class CoffeeShopDL
    {
        public static void addinlist(CoffeeShop shop, MenuItem items)
        {
            shop.menuofshop.Add(items);
        }
        public static MenuItem productwithcheapestprice(CoffeeShop shop)
        {
            float price = shop.menuofshop[0].price;
            int index = 0;
            for (int x = 0; x < shop.menuofshop.Count; x++)
            {
                if (price > shop.menuofshop[x].price)
                {
                    price = shop.menuofshop[x].price;
                    index = x;
                }
            }
            return shop.menuofshop[index];
        }
        public static void addproductintoorderedlist(CoffeeShop shop, MenuItem obj)
        {
            shop.ordereditems.Add(obj.name);
        }
        public static void remove(CoffeeShop shop)
        {

            shop.ordereditems.Clear();

        }
        public static bool checkavaliablity(CoffeeShop c, MenuItem m)
        {
            bool flag = false;
            for (int x = 0; x < c.menuofshop.Count; x++)
            {
                if (c.menuofshop[x].name == m.name)
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }
        public static bool orderfullyavailablility(CoffeeShop shop)
        {
            bool check = false;
            if (shop.ordereditems.Count != 0)
            {
                check = true;
                return check;
            }
            return check;
        }
        public static void readyorder(CoffeeShop c)
        {
            for (int x = 0; x < c.ordereditems.Count; x++)
            {
                CoffeeShopUI.readyorder(c.ordereditems[x]);
                c.ordereditems.RemoveAt(x);
            }
        }
        public static void vieworder(CoffeeShop c)
        {
            for (int x = 0; x < c.ordereditems.Count; x++)
            {
                CoffeeShopUI.printorderlist(x + 1, c.ordereditems[x]);
            }
        }
        public static float calculatetotal(CoffeeShop shop)
        {
            float tprice = 0;
            for (int x = 0; x < shop.menuofshop.Count; x++)
            {
                for (int y = 0; y < shop.ordereditems.Count; y++)
                {

                    if (shop.ordereditems[y] == shop.menuofshop[x].name)
                    {
                        tprice = tprice + shop.menuofshop[x].price;
                    }
                }
            }
            return tprice;
        }
    }
}
