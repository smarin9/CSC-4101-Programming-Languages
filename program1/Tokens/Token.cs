// Token -- Base class Token objects

namespace Tokens
{
    public class Token
    {
        private TokenType tt;

        public Token(TokenType t)
        {
            tt = t;
        }

        public TokenType getType()
        {
            return tt;
        }

        public virtual int    getIntVal()    { return 0; }
        public virtual string getStringVal() { return ""; }
        public virtual string getName()      { return ""; }
    }
}
