// If -- Parse tree node strategy for printing the special form if

using System;

namespace Tree
{
    public class If : Special
    {
        // TODO: Add any fields needed.
 
        // TODO: Add an appropriate constructor.
	public If() { }

        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');
			Console.WriteLine("(if ");

			Node predicate = t.getCdr().getCar();
			if (predicate.isPair())
				predicate.print(0, p);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine();

			Node thenClause = t.getCdr().getCdr().getCar();
			if (!thenClause.isNull())
				thenClause.print(n + 2, p);
			else
				throw new ArgumentException("Syntax Error");

			Console.WriteLine();

			Node elseClause = t.getCdr().getCdr().getCdr().getCar();
			if (!elseClause.isNull())
				elseClause.print(n + 2, p);
			else
				throw new ArgumentException("Syntax Error");

			for (int i = 0; i < n; i++)
				Console.WriteLine(' ');

			Console.WriteLine(')');
		}
		void printQuote(Node c, int n, bool p) {

    }
}
}

