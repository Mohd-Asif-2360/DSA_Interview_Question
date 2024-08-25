using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Question.Array_Solution
{
    public class Elements_nby3_times
    {

        public static void FindElements_NBy3_Times(int[] arr)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i]++;
                }
                else
                {
                    keyValuePairs.Add(i, 1);
                }
            }

            List<int> res = new List<int>();
            int compare = arr.Length / 3;
            foreach(var item in keyValuePairs) { 
                if(item.Value > compare)
                {
                    res.Add(item.Key);
                }
            }

            foreach (var item in res) { 
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
