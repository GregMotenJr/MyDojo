using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    class Kata
    {
        public static string ToWeirdCase(string s)
        {
            string sUpper;
            List<string> upperList = new List<string>();

            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                upperList.Add(sUpper = words[i].ToUpper());
            }

            int count = 0;
            string temp = "";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < upperList.Count; i++)
            {
                count = 0;

                foreach (var indice in upperList[i])
                {
                    if (count % 2 == 0)
                    {
                        sb.Append(indice);
                        count++;
                    }

                    else
                    {
                        temp = indice.ToString().ToLower();
                        sb.Append(temp);
                        count++;
                    }
                }
                sb.Append(" ");
            }

            sb.Remove(sb.Length - 1, 1);
            return (sb.ToString());
        }
    }

}
