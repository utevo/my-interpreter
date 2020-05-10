using MyInterpreter.Parser.Ast.Expressions;
using MyInterpreter.Parser.Ast.Operators;

namespace MyInterpreter.Parser.Ast.Conditionals
{
    public class SimpleConditional : Logical
    {
        private Expression leftExpression;
        private Expression rightExpression;
        private EqualityOperator equalityOperator;
        public SimpleConditional(Expression left, Expression right, EqualityOperator equality, bool isNegated)
        {
            leftExpression = left;
            rightExpression = right;
            equalityOperator = equality;
            this.isNegated = isNegated;
        }
        public override bool Evaluate()
        {
            throw new System.NotImplementedException();
        }
    }
}