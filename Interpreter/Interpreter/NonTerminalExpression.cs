namespace Interpreter
{
    internal class NonTerminalExpression : AbstractExpression
    {
        private AbstractExpression _nonTerminalExpression;
        private AbstractExpression _terminalExpression;
        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                _terminalExpression = new TerminalExpression();
                _terminalExpression.Interpret(context);
                context.Position++;
                if (context.Result)
                {
                    _nonTerminalExpression = new NonTerminalExpression();
                    _nonTerminalExpression.Interpret(context);
                }
            }
        }

    }


}