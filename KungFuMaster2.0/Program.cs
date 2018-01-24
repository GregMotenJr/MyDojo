using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    // The Apprentice Soon Shall Become The Master
    // my work space for kata practice

    class Program
    {
        static void Main(string[] args)
        {
            ///Title: WeIrD StRiNg CaSe

            ///Instructions:

            /*
            Write a function toWeirdCase (weirdcase in Ruby) that accepts a string, and returns the same string with all even indexed characters in 
            each word upper cased, and all odd indexed characters in each word lower cased. The indexing just explained is zero based, so the zero-ith 
            index is even, therefore that character should be upper cased.

            The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words. 
            Words will be separated by a single space(' ').
             */

            Kata.ToWeirdCase("this is a test");

        }//END Main
}//END Program
}//END NameSpace
