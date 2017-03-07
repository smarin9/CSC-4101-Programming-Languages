// BoolLit -- Parse tree node class for representing boolean literals

using System;

namespace Tree
{
    public class BoolLit : Node
    {
        private bool boolVal;
  
        private static BoolLit trueInstance =  new BoolLit(true);
        private static BoolLit falseInstance = new BoolLit(false);

        private BoolLit(bool b)
        {
            boolVal = b;
        }
  
        public static BoolLit getInstance(bool val)
        {
            if (val)
                return trueInstance;
            else
                return falseInstance;
        }

        public override void print(int n)
        {
            Printer.printBoolLit(n, boolVal);
        }

        public override bool isBool()
        {
            return true;
        }

        public Boolean getVal()
        {
            return boolVal;
        }
    }
}
