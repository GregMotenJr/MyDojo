using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    class Kata
    {
        public static bool ValidatePin(string pin)
        {
            ///loop though pin
            ///ValidatePin should return false for pins with length other than 4 or 6 = passed
            ///ValidatePin should return false for pins which contain characters other than digits = passed
            ///ValidatePin should return true for valid pins = failed

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
}
