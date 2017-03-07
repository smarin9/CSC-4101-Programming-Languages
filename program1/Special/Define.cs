// Define -- Parse tree node strategy for printing the special form define

using System;

namespace Tree
{
    public class Define : Special
    {
        // TODO: Add any fields needed.

        // TODO: Add an appropriate constructor.
	public Define() { }

        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(' ');
			}
			Console.WriteLine("(define ");

			Node name = t.getCdr().getCar();
			if (name.isSymbol())
				name.print(0, false);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine(" ");

			Node value = t.getCdr().getCdr().getCar();
			if (!value.isNull())
				value.print(0, true);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine(")");
        }
    }
}


