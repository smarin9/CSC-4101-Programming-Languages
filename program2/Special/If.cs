// If -- Parse tree node strategy for printing the special form if

using System;

namespace Tree
{
    public class If : Special
    {
	public If() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printIf(t, n, p);
        }

        public Node eval (Node t, Environment e)
        {
            Node cond = t.getCdr().getCar();
            Node ifTrue = t.getCdr().getCdr().getCar();
            Node ifFalse = t.getCdr().getCdr().getCdr().getCar();
            bool checkTrueResult = checkTrue(t, e);
            if (checkTrueResult == false)
            {
                return ifFalse.eval(ifFalse, e);
            }
            else 
            {
                return ifTrue.eval(ifTrue, e);
            }
        }

        public Boolean checkTrue(Node cond, Environment e)
        {
            Node check = cond.eval(cond, e);
            if (chec.isBool() == true)
            {
                BoolLit boolVal = (BoolLit) check;
                return boolVal.getVal();
            }
            return true;
        }
    }
}

