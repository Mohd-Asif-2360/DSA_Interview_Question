using Array_Question.Array_Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Prep
{
    public class ArrayProvider
    { 

        public ArrayProvider()
        { 
            //Get the factorial of a large number
            //Facotorial_Of_Big_Number.Factorial(5);

            //Get Max Product subaaray
            Maximum_Product_SubArray.Max_Product_SubArray(new int[] { 2, 3, -2, 4});


            //get longest consecutive subsequence
            Longest_Consecutive_SubSequence.Longest_Sonsecutive(new int[] {1, 1,  1, 8, 7, 9, 3, 10, 4, 20, 2, 6, 5});
        }
    }
}
