﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Question.Array_Solution
{

    public class Longest_Consecutive_SubSequence
    {

        public static void Longest_Sonsecutive(int[] num)
        {
            int result = -1;
            HashSet<int> list = new HashSet<int>();
            foreach (int item in num)
            {
                list.Add(item);
            } 

            for (int i=0; i<num.Length; i++)
            {
                int j = 0;
                if (!list.Contains(num[i] - 1))
                {
                    j = num[i];
                    while (list.Contains(j))
                    {
                        j++;
                    }

                    result = Math.Max(result, j - num[i]);
                }
                
            }

           Console.WriteLine("Longest Consecutive Sub: "+ result);
        }
    }
}
