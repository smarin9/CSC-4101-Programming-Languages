// IntToken -- Token object for representing integer constants.

namespace Tokens
{
    public class IntToken : Token
    {
        private int intVal;

        public IntToken(int i) : base(TokenType.INT)
        {
            intVal = i;
        }
    
        public override int getIntVal()
        {
            return intVal;
        }
    }
}
