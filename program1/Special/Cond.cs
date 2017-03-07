// Cond -- Parse tree node strategy for printing the special form cond

using System;

namespace Tree
{
    public class Cond : Special
    {
        // TODO: Add any fields needed.

        // TODO: Add an appropriate constructor.
	public Cond() { }

        public override void print(Node t, int n, bool p)
        { 
            // TODO: Implement this function.
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(' ');
			}
			Console.WriteLine("(cond");

			Node conditions = t.getCdr();
			if(conditions.isPair())
			{
				conditions.print(n + 2, true);
			}
			else
			{
				throw new ArgumentException("Syntax Error");
			}


        }
    }
}


