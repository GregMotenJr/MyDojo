using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static bool ValidatePin(string pin)
    {
        bool result = true;

        foreach (var item in pin)
        {
            if (pin.Length == 4)
            {
                if (char.IsDigit(item) == true)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            else if (pin.Length == 6)
            {
                if (char.IsDigit(item) == true)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            else///PIN isnt exactly 4 or 6
            {
                result = false;
                break;
            }
        }
        return result;
    }
}