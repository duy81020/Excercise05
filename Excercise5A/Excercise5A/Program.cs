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
            while(true )
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(Char2Code(c));
            }
        }
        public static void Print_a_2_z_v1()
        {
         char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
         foreach (var c in az)
         {
             Console.WriteLine(c);

         }
         
        }
       
        public static int Char2Code(char c)
        {
            return (int)c;
        }
        public static bool IsUpper(char c)
        {
            return false;
        }
        public static bool IsLower(char c)
        {
            return false;
        }
        public static char ToUpper(char c)
        {
            return c;
        }
       
    
    }
}

