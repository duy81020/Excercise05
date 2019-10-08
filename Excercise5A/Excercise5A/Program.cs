using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5A
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
            Print_z_2_a_V2();
        }
        public static void Print_a_2_z_v1()
        {
         char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
         foreach (var c in az)
         {
             Console.WriteLine(c);

         }
         
        }
        public static void Print_z_2_a_V2()
        {
            char[] za = Enumerable.Range('z', 'a' - 'z' + 1).Select(i => (char)i).ToArray();
            foreach (var b in za)
            {
                Console.WriteLine(b);
            }
        }

    
    }
}

