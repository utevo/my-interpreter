namespace MyInterpreter.Parser.Ast.Values
{
    public class Int : Value
    {
        public uint Value { get; private set; }
        public ValueType Type { get; private set; }
        public Int(uint value)
        {
            Value = value;
            Type = ValueType.Int;
        }
    }
}