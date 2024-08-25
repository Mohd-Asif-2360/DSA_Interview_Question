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
            List<int> fact = new List<int>();
            fact.Add(1);  
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
            for (int i = 0; i < fact_Number.Count; i++) {
                int res =  fact_Number[i] * multiplier;
                res = res + carry;
                fact_Number[i] = res % 10;
                carry = res / 10;
            }

            while(carry > 0)
            {
                int res = carry % 10;
                fact_Number.Add(res);
                carry = carry / 10;
            }
        }
    }
}
