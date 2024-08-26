using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Question.Array_Solution
{
    public class Facotorial_Of_Big_Number
    {
        public static void Factorial(int N)
        { 
            //create a list and store the firt value
            List<int> fact = new List<int>();
            fact.Add(1);  
            //iterate from 2 to the Number itself
            for (int multiplier = 2; multiplier <= N; multiplier++)
            {
                Muliply(fact, multiplier);
            }

            for(int i = fact.Count - 1; i >= 0; i--)
            {
                Console.Write(fact[i]);
            }
        }

        private static void Muliply(List<int> fact_Number, int multiplier)
        {
            int carry = 0;
            //this portion is going to update the current index values.
            for (int i = 0; i < fact_Number.Count; i++) {
                int res =  fact_Number[i] * multiplier;
                res = res + carry;
                fact_Number[i] = res % 10;
                carry = res / 10;
            }
            //every time carry is going to add a new index in the list
            while(carry > 0)
            {
                int res = carry % 10;
                fact_Number.Add(res);
                carry = carry / 10;
            }
        }
    }
}
