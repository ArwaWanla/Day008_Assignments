using System;

namespace Day008_ass2Checkorder
{
    class Program
    {
        public static bool CheckOrder(string source)
        {
            //create stack of type string
            string stack= " ";
            //push first characeter, check the most recent number in the stack (top)
            for (int i =0; i < source.Length; i++)
            {
                //push the first item to the stack
                if (i == 0)
                {
                    stack = stack+source[i];
                    //Console.WriteLine(stack);
                    //Console.WriteLine(stack.Length);
                    //Console.WriteLine(stack[0]);
                    continue;
                }
                Console.WriteLine(stack[0]);
                if (source[i] != stack[stack.Length-1])//if true
                {
                    stack += source[i];
                    
                    
                }
                else 
                {
                    stack = stack.Remove(stack.Length - 1);
                }

            }

            Console.WriteLine(stack);

            if (stack == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
        static void Main(string[] args)
        {
            string source = "11129923321";
            Console.WriteLine(CheckOrder(source));
            Console.WriteLine("\n");
        }
    }
}
