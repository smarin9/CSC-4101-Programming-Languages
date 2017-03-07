// IdentToken -- Token object for representing identifiers.

namespace Tokens
{
    public class IdentToken : Token
    {
        private string name;

        public IdentToken(string s) : base(TokenType.IDENT)
        {
            name = s;
        }

        public override string getName()
        {
            return name;
        }
    }
}
