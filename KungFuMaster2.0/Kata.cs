using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungFuMaster2._0
{
    public class ListFilterer
    {
        /// <summary>
        /// create a function that takes a list of non-negative integers and strings 
        /// and returns a new list with the strings filtered out.
        /// </summary>
        /// <param name="listOfItems"></param>
        /// <returns></returns>
        /// 
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            IList<int> newList = new List<int>();

            foreach (var obj in listOfItems)
            {
                if (obj.GetType() == typeof(int))
                {
                    ///add to new list
                    newList.Add(Convert.ToInt32(obj));
                }
            }
            return newList;
        }
    }
}
