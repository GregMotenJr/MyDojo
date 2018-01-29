using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool IsPangram(string str)
    {
        return str.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
    }

}//END KATA CLASS