// Begin -- Parse tree node strategy for printing the special form begin

using System;

namespace Tree
{
    public class Begin : Special
    {
	public Begin() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printBegin(t, n, p);
        }

        public Node eval (Node t, Environment e)
        {
            Node cdr = t.getCdr();
            if (cdr == null)
            {
                return Nil.getInstance();
            }

            Node car = evalCdr(cdr, null, e);
            if (car == null)
            {
                Console.Error.WriteLine("Error: Begin is null (car)");
            }
            return car;
        }

        private Node evalCdr (Node cdr, Node final, Environment e)
        {
            return Nil.getInstance();
        }
    }
}

