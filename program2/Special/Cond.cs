// Cond -- Parse tree node strategy for printing the special form cond

using System;

namespace Tree
{
    public class Cond : Special
    {
	public Cond() { }

        public override void print(Node t, int n, bool p)
        { 
            Printer.printCond(t, n, p);
        }

        public Node eval (Node t, Environment e)
        {
            Node cdr = t.getCdr();
            return Nil.getInstance();
        }
    }
}


