using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Question.Array_Solution
{
    public class Product_Of_Array_Except_Itself
    {

        public static void ProductOfSubArray(int[] arr)
        {

            int zeroCount = 0;
            int product = 1;
            int[] newArr = new int[arr.Length];
            Array.Fill(newArr, 0);
            foreach (int element in arr) { 
                if(element == 0)
                {
                    zeroCount++;
                }
                product *= element;
            }

            if (zeroCount == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = product / arr[i];
                }
            }
            else if (zeroCount == 1) { 
            
                for(int i=0; i < arr.Length; i++)
                {
                    newArr[i] = i != 0 ? 0 : product;
                }
            }

            foreach (int element in newArr) { 
                Console.WriteLine(element);
            }
        }
    }

    
}
