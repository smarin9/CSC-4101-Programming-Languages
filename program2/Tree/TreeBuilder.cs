// TreeBuilder -- Abstract Factory for building tree node objects

using System;

namespace Tree
{
    public class TreeBuilder : ITreeBuilder
    {

        public INode buildBoolLit(bool b)
        {
            return BoolLit.getInstance(b);
        }

        public INode buildIntLit(int i)
        {
            return new IntLit(i);
        }
                                
        public INode buildStringLit(string s)
        {
            return new StringLit(s);
        }

        public INode buildIdent(string n)
        {
            return new Ident(n);
        }

        public INode buildNil()
        {
            return Nil.getInstance();
        }

        public INode buildCons(INode a, INode d)
        {
            return new Cons((Node) a, (Node) d);
        }
    }
}
