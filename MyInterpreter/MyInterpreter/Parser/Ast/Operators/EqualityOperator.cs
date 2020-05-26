using System.Collections.Generic;
using System.Text;
using MyInterpreter.Exceptions.ParserExceptions;

namespace MyInterpreter.Parser.Ast.Operators {
    public class EqualityOperator : IOperator {
        public string Operator { get; private set; }
        public EqualityOperator(string value) => Operator = value;
        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append(Operator);
            return sb.ToString();
        }

    }
}