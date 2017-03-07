// Quote -- Parse tree node strategy for printing the special form quote

using System;

namespace Tree
{
    public class Quote : Special
    {
        // TODO: Add any fields needed.
  
        // TODO: Add an appropriate constructor.
	public Quote() { }

        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			Console.WriteLine("'");
			if (t.getCdr() == typeof(Nil))
				Console.WriteLine("");
			else
				(t.getCdr().print(0, false));
        }
    }
}

