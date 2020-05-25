using MyInterpreter.Exceptions.ParserExceptions;

namespace MyInterpreter.Parser.Ast.Operators {
    public class MultiplicativeOperator : IOperator {
        public string Operator { get; private set; }
        public MultiplicativeOperator(string value) => Operator = value;
        public void Accept(PrintVisitor visitor) {
            throw new System.NotImplementedException();
        }
    }
}