// Cons -- Parse tree node class for representing a Cons node

using System;

namespace Tree
{
    public class Cons : Node
    {
        private Node car;
        private Node cdr;
        private Special form;
    
        public Cons(Node a, Node d)
        {
            car = a;
            cdr = d;
            parseList();
        }
    
        // parseList() `parses' special forms, constructs an appropriate
        // object of a subclass of Special, and stores a pointer to that
        // object in variable form.  It would be possible to fully parse
        // special forms at this point.  Since this causes complications
        // when using (incorrect) programs as data, it is easiest to let
        // parseList only look at the car for selecting the appropriate
        // object from the Special hierarchy and to leave the rest of
        // parsing up to the interpreter.
        void parseList()
        {
            // TODO: implement this function and any helper functions
            // you might need.

			if (car.isSymbol()) {
				String name = car.getName();
				if (name.Equals( "quote", StringComparison.Ordinal))
					return new Quote();
				else if (name.Equals( "lambda", StringComparison.Ordinal))
					return new Lambda();
				else if (name.Equals( "begin", StringComparison.Ordinal))
					return new Begin();
				else if (name.Equals( "if", StringComparison.Ordinal))
					return new If();
				else if (name.Equals( "cond", StringComparison.Ordinal))
					return new Cond();
				else if (name.Equals( "let", StringComparison.Ordinal))
					return new Let();
				else if (name.Equals( "set!", StringComparison.Ordinal))
					return new Set();
				else if (name.Equals( "define", StringComparison.Ordinal))
					return new Define();
				else
					return new Regular();
			}
			else 
				return new Regular();

        }
 
        public override void print(int n)
        {
            form.print(this, n, false);
        }

        public override void print(int n, bool p)
        {
            form.print(this, n, p);
        }


    	
    	public override Node getCar() {
      		return this.car;
    	}

   
    	public override Node getCdr() {
      		return this.cdr;
    	}

    	public boolea isPair() {
        	return true;
    	}
    }
}

