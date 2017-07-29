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
            ///Check to see if a string has the same amount of 'x's and 'o's. 
            ///The method must return a boolean and be case insensitive. 
            ///The string can contains any char.

            string source = "apo";
            //int countX = 0;
            //int countY = 0;
            var countX = source.ToLower().Count(x => x == 'x');
            var countY = source.ToLower().Count(x => x == 'y');

            Console.WriteLine("Their are {0} X's and {1} Y's", countX, countY);
            //while (countX < source.ToLower().Length && source[countX] == 'x') countX++;
            //while (countY < source.ToLower().Length && source[countY] == 'y') countY++;

            if (countX == countY)
            {
                Console.WriteLine("X and Y are equal");
            }
            else
            {
                Console.WriteLine("X and Y are not equal");
            }
            Console.ReadKey();
        }

        ///the finished code
        public static bool XO(string input)
        {
            //Establish Variables, convert the string to lowercase then 
            //go through the string and count the X and O chars

            var countX = input.ToLower().Count(x => x == 'x');
            var countO = input.ToLower().Count(x => x == 'o');

            //Comparing the values to see if they are equal 
            if (countX == countO)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
