// Lambda -- Parse tree node strategy for printing the special form lambda

using System;

namespace Tree
{
    public class Lambda : Special
    {
        // TODO: Add any fields needed.

        // TODO: Add an appropriate constructor.
	public Lambda() { }

        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');
			Console.WriteLine("(lambda ");

			Node secondNode = t.getCdr().getCar();
			if (secondNode.isPair())
				secondNode.print(0, false);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine();

			Node thirdNode = t.getCdr().getCdr().getCar();
			if (thirdNode.isPair())
				thirdNode.print(n + 2, false);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine();
			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');

			Console.WriteLine(')');

  	}
	void printQuote(Node c, int n, boolean p) { }
	}
}

