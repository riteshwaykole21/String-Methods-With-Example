using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    public class InsertMethod
    {
        public void Number()
        {
            string a = "Hello";
            string b = a.Insert(1, "___ Welcome __");
            Console.WriteLine(b);
        }
    }
}
