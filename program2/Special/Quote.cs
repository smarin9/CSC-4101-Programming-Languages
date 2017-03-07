// Quote -- Parse tree node strategy for printing the special form quote

using System;

namespace Tree
{
    public class Quote : Special
    {
	public Quote() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printQuote(t, n, p);
        }

        public Node eval (Node t, Environment e)
        {
            Node current = t.getCdr().getCar();
            if (current == null)
            {
                return Nil.getInstance();
            }
            else
            {
                return current;
            }
            }
        }
    }
}

