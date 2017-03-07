// Lambda -- Parse tree node strategy for printing the special form lambda

using System;

namespace Tree
{
    public class Lambda : Special
    {
	public Lambda() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printLambda(t, n, p);
  	}
      public Node eval (Node t, Environment e)
      {
          return new Closure(t, e);
      }
    }
}

