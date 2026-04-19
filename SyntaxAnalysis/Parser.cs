using lab1.LexicalAnalysis;
using lab1.SyntaxAnalysis;
using System;
using System.Collections.Generic;

namespace lab1
{
    public class Parser
    {
        private readonly List<Token> _tokens;
        private int _pos = 0;
        private const int MAX_ERRORS = 3;
        private bool _exprError = false;

        public List<SyntaxError> Errors { get; } = new List<SyntaxError>();

        private Token Current =>
            _pos < _tokens.Count ? _tokens[_pos] : new Token { Type = TokenType.UNKNOWN, Value = "EOF" };

        public Parser(List<Token> tokens)
        {
            _tokens = tokens;
        }

        private void Error(string msg)
        {
            if (Errors.Count >= MAX_ERRORS) return;
            var t = Current;
            Errors.Add(new SyntaxError(t.Value, t.Line, t.StartPosition, msg, t.StartPosition));
            _exprError = true;
        }

        private void InsertFake(string lexeme, TokenType type = TokenType.IDENTIFIER)
        {
            var fake = new Token
            {
                Type = type,
                Value = lexeme,
                Line = Current.Line,
                StartPosition = Current.StartPosition,
                EndPosition = Current.EndPosition
            };
            _tokens.Insert(_pos, fake);
        }

        private void IronError(string expected, string fake, TokenType type = TokenType.IDENTIFIER)
        {
            Error($"Ожидалось {expected}");
            InsertFake(fake, type);

            if (_pos < _tokens.Count)
            {
                _pos++; 
                if (_pos < _tokens.Count)
                    _pos++; 
            }
        }

        private void ParseFTYPE()
        {
            if (Current.Type == TokenType.KW_INT || Current.Type == TokenType.KW_FLOAT)
                _pos++;
            else
                IronError("'int' или 'float'", "int", TokenType.KW_INT);

            ParseFID();
        }

        private void ParseFID()
        {
            if (Current.Type == TokenType.IDENTIFIER)
                _pos++;
            else
            {
                IronError("идентификатор", "func");
                if (_pos < _tokens.Count && Current.Type != TokenType.LPAREN)
                    _pos++;
            }

            ParseOPENQ();
        }


        private void ParseOPENQ()
        {
            if (Current.Type == TokenType.LPAREN)
                _pos++;
            else
                IronError("'('", "(", TokenType.LPAREN);

            ParsePTYPE();
        }

        private void ParsePTYPE()
        {
            if (Current.Type == TokenType.KW_INT || Current.Type == TokenType.KW_FLOAT)
                _pos++;
            else
                IronError("'int' или 'float'", "int", TokenType.KW_INT);

            ParsePID();
        }

        private void ParsePID()
        {
            if (Current.Type == TokenType.IDENTIFIER)
            {
                _pos++;
            }
            else
            {
                IronError("идентификатор", "x");
                while (_pos < _tokens.Count &&
                       Current.Type != TokenType.COMMA &&
                       Current.Type != TokenType.RPAREN)
                {
                    _pos++;
                }
            }

            if (Current.Type == TokenType.COMMA)
                ParseCOMMA();
            else
                ParseCLOSEQ();
        }



        private void ParseCOMMA()
        {
            if (Current.Type == TokenType.COMMA)
                _pos++;
            else
                IronError("','", ",", TokenType.COMMA);

            ParsePTYPE();
        }

        private void ParseCLOSEQ()
        {
            if (Current.Type == TokenType.RPAREN)
                _pos++;
            else
                IronError("')'", ")", TokenType.RPAREN);

            ParseOPENF();
        }

        private void ParseOPENF()
        {
            if (Current.Type == TokenType.LBRACE)
                _pos++;
            else
                IronError("'{'", "{", TokenType.LBRACE);

            ParseRETURN();
        }

        private void ParseRETURN()
        {
            if (Current.Type == TokenType.KW_RETURN)
                _pos++;
            else
                IronError("'return'", "return", TokenType.KW_RETURN);

            ParseE();
            ParseCOLON();
        }

        private void ParseCOLON()
        {
            if (Current.Type == TokenType.SEMICOLON)
                _pos++;
            else
                IronError("';'", ";", TokenType.SEMICOLON);

            ParseCLOSEF();
        }

        private void ParseCLOSEF()
        {
            if (Current.Type == TokenType.RBRACE)
                _pos++;
            else
                IronError("'}'", "}", TokenType.RBRACE);

            ParseCOLONEND();
        }

        private void ParseCOLONEND()
        {
            if (Current.Type == TokenType.SEMICOLON)
                _pos++;
            else
                IronError("';'", ";", TokenType.SEMICOLON);
        }


        private void ParseE()
        {
            ParseT();
            ParseA();
        }

        private void ParseA()
        {
            if (Current.Type == TokenType.PLUS)
            {
                _pos++;
                ParseT();
                ParseA();
            }
            else if (Current.Type == TokenType.MINUS)
            {
                _pos++;
                ParseT();
                ParseA();
            }
        }

        private void ParseT()
        {
            ParseO();
            ParseB();
        }

        private void ParseB()
        {
            if (Current.Type == TokenType.MULTIPLY)
            {
                _pos++;
                ParseO();
                ParseB();
            }
            else if (Current.Type == TokenType.DIVIDE)
            {
                _pos++;
                ParseO();
                ParseB();
            }
        }

        private void ParseO()
        {
            if (Current.Type == TokenType.IDENTIFIER)
            {
                _pos++;
                if (Current.Type == TokenType.LPAREN)
                {
                    _pos++;
                    ParseE();
                    if (Current.Type == TokenType.RPAREN)
                        _pos++;
                    else
                        IronError("')'", ")", TokenType.RPAREN);
                }
            }
            else if (Current.Type == TokenType.INTEGER || Current.Type == TokenType.FLOAT)
            {
                _pos++;
            }
            else if (Current.Type == TokenType.LPAREN) 
            {
                _pos++;
                ParseE();
                if (Current.Type == TokenType.RPAREN)
                    _pos++;
                else
                    IronError("')'", ")", TokenType.RPAREN);
            }
            else
            {
                IronError("идентификатор, число или '('", "x");
                if (_pos < _tokens.Count && Current.Type != TokenType.RPAREN)
                    _pos++;
            }
        }

        public void ParseProgram()
        {
            _pos = 0;
            Errors.Clear();

            ParseFTYPE();

            if (_pos < _tokens.Count && Current.Type != TokenType.EOF)
            {
                Error("Лишние токены после конца программы");
            }
        }

    }
}
