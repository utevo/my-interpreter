using System.Collections.Generic;
using MyInterpreter.Parser.Ast.Statements;
using MyInterpreter.Parser.Ast.Values;
using System;
using System.Text;

namespace MyInterpreter.Parser.Ast {
    public class Function {
        private TypeValue type;
        private string name;
        private IEnumerable<Parameter> parameters;
        private BlockStatement blockStatement;
        public Function(TypeValue type, string name, IEnumerable<Parameter> parameters, BlockStatement blockStatement) {
            this.type = type;
            this.name = name;
            this.parameters = parameters;
            this.blockStatement = blockStatement;
        }
        public Value Execute() {
            throw new NotImplementedException();
        }
        public override string ToString() {
            var sb = new StringBuilder("Function->");
            sb.Append(type.ToString());
            sb.Append("->");
            sb.Append(name);
            sb.Append("\n");
            foreach (var param in parameters) {
                sb.Append(param.ToString());
                sb.Append("\n");
            }
            sb.Append(blockStatement.ToString());
            return sb.ToString();
        }
    }
}