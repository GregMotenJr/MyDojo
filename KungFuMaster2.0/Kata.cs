using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    int shapeArea(int n)
    {
            var area = 1;

            for (int i = 1; i <= n; i++)
            {
                area += ((i * 4) - 4);
            }
            return area;
    }

}//END KATA CLASS