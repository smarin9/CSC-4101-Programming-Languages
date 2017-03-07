// Nil -- Parse tree node class for representing the empty list

using System;

namespace Tree
{
    public class Nil : Node
    {
        public Nil() { }
  
        public override void print(int n)
        {
            print(n, false);
        }

        public override void print(int n, bool p) {
	    // There got to be a more efficient way to print n spaces.
	    for (int i = 0; i < n; i++)
                Console.Write(" ");

            if (p)
                Console.WriteLine(")");
            else
                Console.WriteLine("()");
        }
    }
}
