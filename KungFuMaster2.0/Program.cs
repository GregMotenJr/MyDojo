using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    class Program
    {
        static void Main(string[] args)
        {/*The Apprentice Soon Shall Become The Master*/
            //Console.WriteLine("Hello, World!");
            //Console.ReadKey();
            //END SETUP

            /*BEGIN 1-FUNCTION TESTS*/
            int a;
            int b;
            int c;

            Console.WriteLine("Enter value of 'a':");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of 'b':");
            b = Convert.ToInt32(Console.ReadLine());

            //why can't I not use it this way?
            c = Add(a, b);
            Console.WriteLine("a + b = {0}", c);
        }//END   Main

        static public int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }//END   Add


    }// END PROGRAM
}

