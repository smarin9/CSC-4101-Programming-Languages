// Let -- Parse tree node strategy for printing the special form let

using System;

namespace Tree
{
    public class Let : Special
    {
        // TODO: Add any fields needed.
 
        // TODO: Add an appropriate constructor.
	public Let() { }

        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');

			Console.WriteLine("(let ");

			Node assignments = t.getCdr().getCar();
			if (assignments.isPair())
				assignments.print(0, false);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine();

			Node body = t.getCdr().getCdr();
			if (body.isPair())
				body.print(n + 2, true);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine();
			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');

			Console.WriteLine("/LET");
        }
    }
}


