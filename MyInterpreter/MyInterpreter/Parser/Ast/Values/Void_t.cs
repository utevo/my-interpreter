namespace MyInterpreter.Parser.Ast.Values
{
    public class Void_t : Value
    {
        public TypeValue Type { get; private set; }
        public Void_t() => Type = TypeValue.Void;
    }
}