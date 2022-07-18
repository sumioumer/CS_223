
using System;
usuing System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4_on_GUI
{
    internal class product

    {
        private static List<product> products = new List<product>();

        public string number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public void save()
        {
            products.Add(this);
            //Console.WriteLine("SAVE");
        }
        public static List<product> GetAll()
        {
            return products;
        }

    }
}
