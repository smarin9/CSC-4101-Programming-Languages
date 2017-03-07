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
        private void parseList()
        {
            if (! car.isSymbol())
                form = new Regular();
            else
            {
                string name = car.getName();

                if (name.Equals("quote"))
                    form = new Quote();
                else if (name.Equals("lambda"))
                    form = new Lambda();
                else if (name.Equals("begin"))
                    form = new Begin();
                else if (name.Equals("if"))
                    form = new If();
                else if (name.Equals("let"))
                    form = new Let();
                else if (name.Equals("cond"))
                    form = new Cond();
                else if (name.Equals("define"))
                    form = new Define();
                else if (name.Equals("set!"))
                    form = new Set();
                else
                    form = new Regular();
            }
        }
 
        public override void print(int n)
        {
            form.print(this, n, false);
        }

        public override void print(int n, bool p)
        {
            form.print(this, n, p);
        }

        public override Node getCar()
        {
            return car;
        }

        public override Node getCdr()
        {
            return cdr;
        }

        public override void setCar(Node a)
        {
            car = a;
            parseList();
        }

        public override void setCdr(Node d)
        {
            cdr = d;
        }

        public override bool isPair()
        {
            return true;
        }

        public Node eval (Node t, Environment e)
        {
            return form.eval(t, e);
        }
    }
}
