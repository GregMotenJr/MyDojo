using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    int adjacentElementsProduct(int[] inputArray)
    {
        List<int> inputList = new List<int>();
        for (int I = 0; I < inputArray.Length; I++)
        {
            var result = inputArray[I] + inputArray[I + 1];
            inputList.Add(result);
        }
        inputList.Sort();
        inputList.Reverse();
        return inputList[0];
    }

}//END KATA CLASS