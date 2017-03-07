// IntLit -- Parse tree node class for representing integer literals

using System;

namespace Tree
{
    public class IntLit : Node
    {
        private int intVal;

        public IntLit(int i)
        {
            intVal = i;
        }

        public override void print(int n)
        {
	    // There got to be a more efficient way to print n spaces.
	    for (int i = 0; i < n; i++)
                Console.Write(" ");

            Console.WriteLine(intVal);
        }
    }
}
