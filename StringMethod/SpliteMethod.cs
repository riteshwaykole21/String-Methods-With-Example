using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    public class SpliteMethod
    {
        public void Number()
        {
            string Name = "12,45,78,98,13";
            string[] Name1 = Name.Split(',');
            foreach (string n in Name1)
            {
                Console.Write(n + " ");
            }
        }
    }
}
