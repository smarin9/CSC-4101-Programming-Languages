// Set -- Parse tree node strategy for printing the special form set!

using System;

namespace Tree
{
    public class Set : Special
    {
        // TODO: Add any fields needed.
 
        // TODO: Add an appropriate constructor.
	public Set() { }
	
        public override void print(Node t, int n, bool p)
        {
            // TODO: Implement this function.
			if (p != true)
				Console.WriteLine("(");

			if (t.getCar().isPair())
				t.getCar().print(0, false);
			else
				t.getCar().print(0, true);

			Console.WriteLine(" ");
			Node value = t.getCdr();
			if (value  typeof(Nil)){
				Console.WriteLine(")");}
			else{
				value.print(0, true);}
        }
    }
}

