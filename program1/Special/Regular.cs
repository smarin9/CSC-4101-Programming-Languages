// Regular -- Parse tree node strategy for printing regular lists

using System;

namespace Tree
{
    public class Regular : Special
    {
        // TODO: Add any fields needed.
    
        // TODO: Add an appropriate constructor.
        public Regular() { }

        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');

			if (!p)
				Console.Writeline('(');

			t.getCar().print(0);
			Console.WriteLine(' ');
			t.getCdr().print(0, true);
        }
    }
}


