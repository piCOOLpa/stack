using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
namespace stack_stack_implementation_cs
{
    class Program
    {

        public static char[] reverse_string_using_stack (char[] sequence )
        {
            // input is the char array , containing the elements in the char array.

            Stack<char> reverse_sequence = new Stack<char>();
            // define a stack to store all the elements in the LIFO style.


            // push all the elements into the stack from the char array.
            foreach(char S in sequence)
            {
                // iterate over each item in sequence , store the char in stack data-structure .
                // push the elements into stack from the char[]
                reverse_sequence.Push(S);
            }

            // over-write the elements in the char array in the lifo style.
            for(int i = 0; i < sequence.Length; ++i )
            {
                // iterate all the elements in the char array 
                // pop the LIFO elements from the stack to original char array.

                sequence[i] = reverse_sequence.Pop();
                ;
            }

            return sequence;
        }
        public static char[] reverse_string_recursively( char[] sequence , int index)
        {
            // null char array.

            if (index < sequence.Length)
            {
                // recurse only if the string is not null. Atleast one character.

                int index_a = index;
                int index_b = sequence.Length - index_a - 1;
                sequence = reverse_string_recursively(sequence, ++index);
                

                if (index_a > index_b)
                {
                    // swap the characters at the index_a , index_b
                    // in-place swap 
                    char temp = sequence[index_a];
                    sequence[index_a] = sequence[index_b];
                    sequence[index_b] = temp;

                    //s[index_a] = s[index_a];
                    // above assignment gives error as the string is read-only , it cannot be modified once created .
                    // so we must declare a  character array instaed of string.

                }

            }

            return sequence;
        }
        static void Main(string[] args)
        {
            Console.Write("enter a string which needs to be reversed : ");

            string s = Console.ReadLine();
            // abc 

            char[] sequence = s.ToCharArray();
            // [a , b , c]

            // sequence = reverse_string_recursively(sequence, 0);
            // ( [a , b , c] ,0)

            sequence = reverse_string_using_stack(sequence);



            Console.WriteLine("the original-string : " + s);
            Console.Write("the reverse of the original-string : ");
            foreach( char c in sequence)
            {
                Console.Write(c);
            }

            Console.ReadLine();
        }
    }
}

