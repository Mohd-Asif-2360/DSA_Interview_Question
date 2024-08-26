using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Question.Array_Solution
{
    public class Intersection_Of_3_Sortd_Array
    {
       

        public Intersection_Of_3_Sortd_Array() { 
        }

        //we will use here 3 pointer approach
        public static void CommonElements()
        {
            int[] A = { 1, 5, 10, 20, 30 };
            int[] B = { 5, 13, 15, 20 };
            int[] C = { 5, 20 };

            //declare three pointers
            int i =0, j=0, k = 0;

            List<int> commonItems = new List<int>();
            // iterate untill pointers are greater than their respective array length
            while(i<A.Length && j<B.Length && k < C.Length)
            {
                if(A[i] == B[j] && B[j] == C[k])
                {
                    // add the value and increment the pointer
                    commonItems.Add(A[i]);
                    i++;
                    j++;
                    k++;


                    //check and skip duplicate pointer
                    while (i < A.Length && A[i] == A[i - 1]) i++;
                    while (j < B.Length && B[j] == B[j - 1]) j++;
                    while (k<C.Length && C[k] == C[k - 1]) k++;
                }
                else if (A[i] <B[j])
                {
                    i++;
                }
                else if (B[j] <C[k])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }

            Console.WriteLine();
            foreach(int item in commonItems)
            {
                Console.Write(item + " ");
            }
        }
    }
}
