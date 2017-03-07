// Ident -- Parse tree node class for representing identifiers

using System;

namespace Tree
{
    public class Ident : Node
    {
        private string name;

        public Ident(string n)
        {
            name = n;
        }

        public override void print(int n)
        {
            Printer.printIdent(n, name);
        }

        public override String getName()
        {
            return name;
        }

        public override bool isSymbol()
        {
            return true;
        }

        public Node eval (Environment e)
        {
            Node val = e.lookup(this);
            if (val != null)
            {
                return val;
            }
            return null;
        }
    }
}

