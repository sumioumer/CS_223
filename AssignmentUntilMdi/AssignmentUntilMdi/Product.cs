using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUntilMdi
{
    internal class Product
    {
        
        private static List<Product> products = new List<Product>();

        public string Number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public bool available { get; set; }
        public static Product findOne(string name)
        {
            return products.Find(p => p.objectname == name);
        }
        public void save()
        {
            products.Add(this);
            //Console.WriteLine("SAVE");
        }
        public static List<Product> GetAll()
        {
            return products;
        }
    }
}
