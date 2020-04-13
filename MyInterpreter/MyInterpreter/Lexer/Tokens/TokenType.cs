namespace MyInterpreter.Lexer.Tokens
{
    public enum TokenType
    {
        NUMBER, STRING, TEXT,
        WHILE, FOR, IF, ELSE, RETURN,
        IDENTIFIER,
        EOT,
        AND, OR, NOT,
        PLUS, MINUS, MULTIPLY, DIVIDE, MODULO, ASSIGN,
        PLUS_ASSIGN, MINUS_ASSIGN, MULTIPLY_ASSIGN, DIVIDE_ASSIGN, MODULO_ASSIGN,
        EQUALS, NOT_EQUAL, GREATER, LESS, GREATER_EQUAL, LESS_EQUAL
    }
}