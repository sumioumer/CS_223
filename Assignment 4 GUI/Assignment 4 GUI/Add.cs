﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_GUI
{
    internal class add

    {
        private static List<add> products = new List<add>();

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
        public static List<add> GetAll()
        {
            return products;
        }

    }
}
