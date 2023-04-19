using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    public class CloneMethod
    {
        public void Method()
        {
            string a = "Hello";
            string b = (string)a.Clone();
            Console.WriteLine(b);
        }
    }
}
