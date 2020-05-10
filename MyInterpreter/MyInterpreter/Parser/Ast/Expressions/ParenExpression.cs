using MyInterpreter.Parser.Ast.Values;

namespace MyInterpreter.Parser.Ast.Expressions
{
    public class ParenExpression : PrimaryExpression
    {
        Expression expression;
        public ParenExpression(Expression expression)  =>
            this.expression = expression;
        public Value Evaluate()
        {
            throw new System.NotImplementedException();
        }
    }
}