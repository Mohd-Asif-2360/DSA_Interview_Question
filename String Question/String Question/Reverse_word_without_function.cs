using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Question.String_Question
{
    public class Reverse_word_without_function
    {

        public static void Reverse_Word(string s)
        {
            s= s.Trim();
            if (s == null || s.Length == 1 || !s.Contains(' ')) return;

            Stack<string> stack = new Stack<string>();
            string str = "";

            foreach(char c in s)
            {
                if ( c != ' ')
                {
                    str += c;
                }
                else if(str.Length > 0)
                {
                    stack.Push(str);
                    str = "";
                }
            }

            //handle the last word
            if(str.Length > 0)
            {
                stack.Push(str);
                str = "";
            }


            while (stack.Count > 0) { 
                str += stack.Pop();
                if (stack.Count > 0) {
                    str += " ";
                }
            }

            Console.WriteLine(str);
        }
    }
}
