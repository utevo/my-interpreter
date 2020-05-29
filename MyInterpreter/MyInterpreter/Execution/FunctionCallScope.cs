using System.Collections.Generic;
using MyInterpreter.Exceptions;
using MyInterpreter.Parser.Ast;

namespace MyInterpreter.Execution {
    public class FunctionCallScope {
        private readonly LinkedList<Scope> localScopes;
        public FunctionCallScope() {
            localScopes = new LinkedList<Scope>();
            localScopes.AddFirst(new Scope());
            //TODO add function call parameters
        }
        public void MakeNewLocalScope() =>
            localScopes.AddFirst(new Scope());

        public void DestroyLocalScope() =>
            localScopes.RemoveFirst();

        public Variable GetVariable(string name) {
            Variable variable;
            foreach (var scope in localScopes) {
                if((variable = scope.GetVariable(name)) != null)
                    return variable;
            }
            return null;
        }
        public void RegisterVariable(Variable variable) {
            var scope = localScopes.First.Value;
            if(!scope.RegisterVariable(variable))
                throw new RuntimeException();
        }
    }
}