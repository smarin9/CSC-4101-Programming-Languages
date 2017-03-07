// StringLit -- Parse tree node class for representing string literals

using System;

namespace Tree
{
    public class StringLit : Node
    {
        private string stringVal;

        public StringLit(string s)
        {
            stringVal = s;
        }

        public override void print(int n)
        {
            Printer.printStringLit(n, stringVal);
        }

        public override bool isString()
        {
            return true;
        }

        public Node eval (Environment e)
        {
            return this;
        }
    }
}

