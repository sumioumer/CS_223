using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_GUI
{
    internal class Add
    {

        public string Number { get; set; }
        public string Date { get; set; }
        public string Invenotrynumber { get; set; }
        public string Objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }

        public void save()
        {
            Console.WriteLine("Saved successfully");
        }
    }
}
