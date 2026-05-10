using System.Collections.Generic;
using System.Linq;
using lab1.LexicalAnalysis;
using lab1.SyntaxAnalysis;

namespace lab1
{
    public class Parser
    {
        private List<Token> _tokens;
        private int _index;
        private bool _panicMode;

        public List<SyntaxError> Errors { get; } = new List<SyntaxError>();

        private Token Current =>
            _index < _tokens.Count
                ? _tokens[_index]
                : _tokens.LastOrDefault();

        public void ParseProgram(List<Token> tokens)
        {
            Errors.Clear();
            _index = 0;

            _tokens = new List<Token>();

            if (tokens == null || tokens.Count == 0)
            {
                AddError(null, "Пустой ввод");
                return;
            }

            _tokens = tokens
                .Where(t =>
                    t.Type != TokenType.SPACE &&
                    t.Type != TokenType.TAB &&
                    t.Type != TokenType.NEWLINE)
                .ToList();

            if (_tokens.Count == 0)
            {
                AddError(null, "Пустой ввод");
                return;
            }

            if (_tokens.Last().Type != TokenType.EOF)
            {
                var last = _tokens.Last();

                _tokens.Add(new Token
                {
                    Type = TokenType.EOF,
                    Value = "EOF",
                    Line = last.Line,
                    StartPosition = last.EndPosition + 1,
                    EndPosition = last.EndPosition + 3
                });
            }

            ParseFunction();

            if (Current != null && Current.Type != TokenType.EOF)
            {
                AddError(Current, "Лишние токены после конца программы");
            }
            _panicMode = false;
        }


        private void AddError(Token token, string message)
        {
            Errors.Add(new SyntaxError(
                token?.Value ?? "EOF",
                token?.Line ?? 0,
                token?.StartPosition ?? 0,
                message,
                token?.StartPosition ?? 0
            ));
        }


        private void Match(TokenType expected, params TokenType[] followSet)
        {
            if (Current == null)
                return;

            if (_panicMode && Current.Type == TokenType.EOF)
                return;

            if (Current.Type == expected)
            {
                _index++;
                _panicMode = false;
                return;
            }

            AddError(
                Current,
                $"Ожидался {expected}, найден {Current.Type}"
            );

            if (Current.Type == TokenType.EOF)
            {
                _panicMode = true;
                return;
            }

            if (followSet != null &&
                followSet.Contains(Current.Type))
            {
                return;
            }

            Recover(expected, followSet);
        }

        private void Recover(TokenType expected, TokenType[] followSet)
        {
            if (Current == null || Current.Type == TokenType.EOF)
                return;

            Token current = Current;
            Token next =
                _index + 1 < _tokens.Count
                    ? _tokens[_index + 1]
                    : null;


            bool expectedKeyword =
                expected == TokenType.KW_INT ||
                expected == TokenType.KW_FLOAT ||
                expected == TokenType.KW_RETURN;

            if (expectedKeyword &&
                current.Type == TokenType.IDENTIFIER)
            {
                _index++; 
                return;
            }


            if (next != null && next.Type == expected)
            {
                _index += 2;
                return;

            }
            while (Current != null &&
                   Current.Type != TokenType.EOF)
            {
                if (followSet != null &&
                    followSet.Contains(Current.Type))
                    break;

                _index++;
            }
        }


        private void ParseFunction()
        {
            ParseType();

            Match(
                TokenType.IDENTIFIER,
                TokenType.LPAREN,
                TokenType.LBRACE
            );

            Match(
                TokenType.LPAREN,
                TokenType.KW_INT,
                TokenType.KW_FLOAT,
                TokenType.RPAREN
            );

            ParseParameters();

            Match(
                TokenType.RPAREN,
                TokenType.LBRACE
            );

            Match(
                TokenType.LBRACE,
                TokenType.KW_RETURN
            );

            Match(
                TokenType.KW_RETURN,
                TokenType.IDENTIFIER,
                TokenType.INTEGER,
                TokenType.FLOAT,
                TokenType.LPAREN
            );

            ParseExpression();

            Match(
                TokenType.SEMICOLON,
                TokenType.RBRACE
            );

            Match(
                TokenType.RBRACE,
                TokenType.SEMICOLON
            );

            Match(
                TokenType.SEMICOLON,
                TokenType.EOF
            );
        }
        private bool ParseType()
        {
            if (Current?.Type == TokenType.KW_INT ||
                Current?.Type == TokenType.KW_FLOAT)
            {
                _index++;
                return true;
            }

            AddError(
                Current,
                $"Ожидался KW_INT, KW_FLOAT, найден {Current?.Type}"
            );

            return false;
        }
        private void ParseParameters()
        {
            if (Current == null || Current.Type == TokenType.EOF)
                return;

            if (Current.Type == TokenType.RPAREN)
            {
                AddError(Current, "Функция должна иметь минимум 1 параметр");
                return;
            }

            ParseParameter();

            while (Current != null &&
                   Current.Type != TokenType.RPAREN &&
                   Current.Type != TokenType.LBRACE &&
                   Current.Type != TokenType.EOF)
            {
                if (Current.Type == TokenType.COMMA)
                {
                    Match(TokenType.COMMA);
                    ParseParameter();
                }
                else
                {
                    AddError(Current,
                        $"Ожидался COMMA, найден {Current.Type}");

                    while (Current != null &&
                           Current.Type != TokenType.COMMA &&
                           Current.Type != TokenType.RPAREN &&
                           Current.Type != TokenType.LBRACE &&
                           Current.Type != TokenType.EOF)
                    {
                        _index++;
                    }

                    if (Current != null &&
                        Current.Type == TokenType.COMMA)
                    {
                        Match(TokenType.COMMA);
                        ParseParameter();
                    }
                }
            }
        }

        private void ParseParameter()
        {
            ParseType();

            if (Current != null && Current.Type == TokenType.IDENTIFIER)
            {
                _index++;
            }
            else
            {
                AddError(Current, $"Ожидался IDENTIFIER, найден {Current?.Type}");
            }
        }


        private void ParseExpression()
        {
            ParseTerm();

            while (Current != null &&
                  (Current.Type == TokenType.PLUS ||
                   Current.Type == TokenType.MINUS))
            {
                _index++;

                ParseTerm();
            }
        }

        private void ParseTerm()
        {
            ParseFactor();

            while (Current != null &&
                  (Current.Type == TokenType.MULTIPLY ||
                   Current.Type == TokenType.DIVIDE))
            {
                _index++;

                ParseFactor();
            }
        }

        private void ParseFactor()
        {
            if (Current == null ||
                Current.Type == TokenType.EOF)
                return;

            if (Current.Type == TokenType.IDENTIFIER ||
                Current.Type == TokenType.INTEGER ||
                Current.Type == TokenType.FLOAT)
            {
                _index++;
                return;
            }

            if (Current.Type == TokenType.LPAREN)
            {
                Match(
                    TokenType.LPAREN,
                    TokenType.IDENTIFIER,
                    TokenType.INTEGER,
                    TokenType.FLOAT
                );

                ParseExpression();

                Match(
                    TokenType.RPAREN,
                    TokenType.MULTIPLY,
                    TokenType.DIVIDE,
                    TokenType.PLUS,
                    TokenType.MINUS,
                    TokenType.SEMICOLON
                );

                return;
            }

            AddError(
                Current,
                $"Ожидалось выражение, найден {Current.Type}"
            );

            Recover(
                TokenType.IDENTIFIER,
                new[]
                {
                    TokenType.SEMICOLON,
                    TokenType.RPAREN,
                    TokenType.PLUS,
                    TokenType.MINUS,
                    TokenType.MULTIPLY,
                    TokenType.DIVIDE
                }
            );
        }
    }
}