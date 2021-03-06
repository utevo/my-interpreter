using System;
using System.Collections.Generic;
using MyInterpreter.DataSource;
using MyInterpreter.Lexer.Tokens;

namespace MyInterpreter.Lexer {
    static class Mapper {
        public static Dictionary<string, TokenType> GetKeywordsMapper() {
            var keywords = new Dictionary<string, TokenType>();
            keywords.Add("while", TokenType.WHILE);
            keywords.Add("for", TokenType.FOR);
            keywords.Add("if", TokenType.IF);
            keywords.Add("else", TokenType.ELSE);
            keywords.Add("return", TokenType.RETURN);
            keywords.Add("matrix", TokenType.MATRIX);
            keywords.Add("int", TokenType.INT);
            keywords.Add("void", TokenType.VOID);
            keywords.Add("string", TokenType.STRING);
            return keywords;

        }
        public static Dictionary<char, TokenType> GetLiteralsMapper() {
            var literals = new Dictionary<char, TokenType>();
            literals.Add('(', TokenType.PAREN_OPEN); literals.Add(')', TokenType.PAREN_CLOSE);
            literals.Add('[', TokenType.BRACKET_OPEN); literals.Add(']', TokenType.BRACKET_CLOSE);
            literals.Add('{', TokenType.BRACE_OPEN); literals.Add('}', TokenType.BRACE_CLOSE);
            literals.Add(':', TokenType.COLON); literals.Add(';', TokenType.SEMICOLON);
            literals.Add(',', TokenType.COMMA);
            return literals;
        }

        public static Dictionary<char, Func<ISource, Token>> GetOperatorsMapper() {
            var mapper = new Dictionary<char, Func<ISource, Token>>();
            mapper.Add('=', (src) => GetOperatorTwoOrOneLetter(src, TokenType.ASSIGN, "=", TokenType.EQUALS, "=="));
            mapper.Add('<', (src) => GetOperatorTwoOrOneLetter(src, TokenType.LESS, "<", TokenType.LESS_EQUAL, "<="));
            mapper.Add('>', (src) => GetOperatorTwoOrOneLetter(src, TokenType.GREATER, ">", TokenType.GREATER_EQUAL, ">="));
            mapper.Add('!', (src) => GetOperatorTwoOrOneLetter(src, TokenType.NOT, "!", TokenType.NOT_EQUAL, "!="));
            mapper.Add('+', (src) => GetOperatorTwoOrOneLetter(src, TokenType.PLUS, "+", TokenType.PLUS_ASSIGN, "+="));
            mapper.Add('-', (src) => GetOperatorTwoOrOneLetter(src, TokenType.MINUS, "-", TokenType.MINUS_ASSIGN, "-="));
            mapper.Add('*', (src) => GetOperatorTwoOrOneLetter(src, TokenType.MULTIPLY, "*", TokenType.MULTIPLY_ASSIGN, "*="));
            mapper.Add('/', (src) => GetOperatorTwoOrOneLetter(src, TokenType.DIVIDE, "/", TokenType.DIVIDE_ASSIGN, "/="));
            mapper.Add('%', (src) => GetOperatorTwoOrOneLetter(src, TokenType.MODULO, "%", TokenType.MODULO_ASSIGN, "%="));
            mapper.Add('&', (src) => {
                src.Next();
                if (src.CurrentChar == '&') {
                    src.Next();
                    return new Operator(TokenType.AND, "&&", src.Position);
                }
                else
                    return null;
            });
            mapper.Add('|', (src) => {
                src.Next();
                if (src.CurrentChar == '|') {
                    src.Next();
                    return new Operator(TokenType.OR, "||", src.Position);
                }
                else
                    return null;
            });
            return mapper;
        }
        private static Operator GetOperatorTwoOrOneLetter(
            ISource src,
            TokenType ifOneLetterType, string ifOneLetterValue,
            TokenType ifTwoLetterType, string ifTwoLetterValue
            ) {
            src.Next();
            if (src.CurrentChar == '=') {
                src.Next();
                return new Operator(ifTwoLetterType, ifTwoLetterValue, src.Position);
            }
            else
                return new Operator(ifOneLetterType, ifOneLetterValue, src.Position);
        }
    }
}