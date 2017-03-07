// Let -- Parse tree node strategy for printing the special form let

using System;

namespace Tree
{
    public class Let : Special
    {
	public Let() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printLet(t, n, p);
        }

        public Node eval (Node t, Environment e)
        {
            Environment letE = new Environment(e);
            Node child = t.getCdr().getCar();
            if (child != null)
            {
                Node current = t.getCar();
                letE.define(current, null);
                return null;
            }
        }
    }
}


