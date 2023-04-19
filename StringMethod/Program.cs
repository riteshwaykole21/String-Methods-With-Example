using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Clone Method Example");
            Console.WriteLine("2 : Concat Method Example");
            Console.WriteLine("Enter A Option");
            int Option  = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    CloneMethod cloneMethod = new CloneMethod();
                    cloneMethod.Method();
                    break;
                case 2:
                    ConcatMethod concatMethod = new ConcatMethod();
                    concatMethod.Method();
                    break;
            }
            Console.ReadLine();
        }
    }
}
