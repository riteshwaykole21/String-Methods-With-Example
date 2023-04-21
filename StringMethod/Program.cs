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
            Console.WriteLine("3 : Contains Method Example");
            Console.WriteLine("4 : Copy One String Into Another");
            Console.WriteLine("5 : Two String Are Same Not");
            Console.WriteLine("6 : Index Of String Char");
            Console.WriteLine("7 : Insert Sring In String ");
            Console.WriteLine("8 : Replace String Char ");
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
                case 3:
                    ContainsMethod containsMethod = new ContainsMethod();
                    containsMethod.Number();
                    break;
                case 4:
                    CopyMethod copyMethod = new CopyMethod();
                    copyMethod.Number();    
                    break;
                case 5:
                    EqualsMethod equalsMethod = new EqualsMethod();
                    equalsMethod.Number();
                    break;
                case 6:
                    indexOf indexOf = new indexOf();
                    indexOf.Number();
                    break;
                case 7:
                    InsertMethod insertMethod = new InsertMethod();
                    insertMethod.Number();
                    break;
                case 8:
                    ReplaceMethod replaceMethod = new ReplaceMethod();
                    replaceMethod.Number();
                    break;
            }
            Console.ReadLine();
        }
    }
}
