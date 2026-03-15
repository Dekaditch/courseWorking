using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.LexicalAnalysis
{
    public class Scanner
    {
        private string input;              
        private int position;              
        private int line;                    
        private int linePosition;            
        private List<Token> tokens;         
        private List<LexicalException> errors; 

        private HashSet<string> keywords = new HashSet<string>
        {
            "int", "return", "void", "char", "float",
        };

        public Scanner()
        {
            tokens = new List<Token>();
            errors = new List<LexicalException>();
        }

        public List<Token> Analyze(string text)
        {
            input = text;
            position = 0;
            line = 1;
            linePosition = 1;
            tokens.Clear();
            errors.Clear();

            while (position < input.Length)
            {
                char current = input[position];

                if (char.IsWhiteSpace(current))
                {
                    ProcessWhitespace();
                }
                else if (char.IsLetter(current) || current == '_')
                {
                    ProcessIdentifierOrKeyword();
                }
                else if (char.IsDigit(current))
                {
                    ProcessNumber();
                }
                else
                {
                    ProcessSymbol();
                }
            }

            return tokens;
        }

        private void ProcessWhitespace()
        {
            char current = input[position];
            Token token = new Token
            {
                Line = line,
                StartPosition = linePosition
            };

            if (current == ' ')
            {
                token.Type = TokenType.SPACE;
                token.Value = " ";
                token.EndPosition = linePosition;
                position++;
                linePosition++;
            }
            else if (current == '\t')
            {
                token.Type = TokenType.TAB;
                token.Value = "\t";
                token.EndPosition = linePosition;
                position++;
                linePosition++;
            }
            else if (current == '\n')
            {
                token.Type = TokenType.NEWLINE;
                token.Value = "\\n";
                token.EndPosition = linePosition;
                position++;
                line++;
                linePosition = 1;
            }
            else if (current == '\r')
            {
                if (position + 1 < input.Length && input[position + 1] == '\n')
                {
                    token.Type = TokenType.NEWLINE;
                    token.Value = "\\r\\n";
                    token.EndPosition = linePosition + 1;
                    position += 2;
                    line++;
                    linePosition = 1;
                }
                else
                {
                    token.Type = TokenType.UNKNOWN;
                    token.Value = current.ToString();
                    token.IsError = true;
                    token.ErrorMessage = "Недопустимый символ";
                    token.EndPosition = linePosition;
                    position++;
                    linePosition++;
                }
            }

            tokens.Add(token);
        }

        private void ProcessIdentifierOrKeyword()
        {
            int startPos = linePosition;
            int startIndex = position;

            while (position < input.Length &&
                  (char.IsLetterOrDigit(input[position]) || input[position] == '_'))
            {
                position++;
                linePosition++;
            }

            string value = input.Substring(startIndex, position - startIndex);

            Token token = new Token
            {
                Value = value,
                Line = line,
                StartPosition = startPos,
                EndPosition = linePosition - 1
            };

            if (keywords.Contains(value))
            {
                switch (value)
                {
                    case "int": token.Type = TokenType.KW_INT; break;
                    case "return": token.Type = TokenType.KW_RETURN; break;
                    case "float": token.Type = TokenType.KW_FLOAT; break;
                    default: token.Type = TokenType.IDENTIFIER; break;
                }
            }
            else
            {
                token.Type = TokenType.IDENTIFIER;
            }

            tokens.Add(token);
        }

        private void ProcessNumber()
        {
            int startPos = linePosition;
            int startIndex = position;
            bool hasDecimalPoint = false;

            while (position < input.Length && char.IsDigit(input[position]))
            {
                position++;
                linePosition++;
            }

            if (position < input.Length && input[position] == '.')
            {
                hasDecimalPoint = true;
                position++;
                linePosition++;

                while (position < input.Length && char.IsDigit(input[position]))
                {
                    position++;
                    linePosition++;
                }
            }

            string value = input.Substring(startIndex, position - startIndex);

            Token token = new Token
            {
                Value = value,
                Line = line,
                StartPosition = startPos,
                EndPosition = linePosition - 1
            };

            token.Type = hasDecimalPoint ? TokenType.FLOAT : TokenType.INTEGER;
            tokens.Add(token);
        }


        private void ProcessSymbol()
        {
            char current = input[position];
            Token token = new Token
            {
                Line = line,
                StartPosition = linePosition,
                EndPosition = linePosition
            };

            if (position + 1 < input.Length)
            {
                string twoChar = current.ToString() + input[position + 1].ToString();

                if (twoChar == "==" || twoChar == "!=" || twoChar == "<=" || twoChar == ">=")
                {
                    token.Value = twoChar;
                    token.EndPosition = linePosition + 1;

                    switch (twoChar)
                    {
                        case "==": token.Type = TokenType.EQUAL; break;
                        case "!=": token.Type = TokenType.NOT_EQUAL; break;
                        case "<=": token.Type = TokenType.LESS; break; 
                        case ">=": token.Type = TokenType.GREATER; break; 
                    }

                    position += 2;
                    linePosition += 2;
                    tokens.Add(token);
                    return;
                }
            }

            token.Value = current.ToString();

            switch (current)
            {
                case '=': token.Type = TokenType.ASSIGN; break;
                case '+': token.Type = TokenType.PLUS; break;
                case '-': token.Type = TokenType.MINUS; break;
                case '*': token.Type = TokenType.MULTIPLY; break;
                case '/':

                    if (position + 1 < input.Length && input[position + 1] == '/')
                    {
                        ProcessComment();
                        return;
                    }
                    token.Type = TokenType.DIVIDE;
                    break;
                case '(': token.Type = TokenType.LPAREN; break;
                case ')': token.Type = TokenType.RPAREN; break;
                case '{': token.Type = TokenType.LBRACE; break;
                case '}': token.Type = TokenType.RBRACE; break;
                case ';': token.Type = TokenType.SEMICOLON; break;
                case ',': token.Type = TokenType.COMMA; break;
                case '<': token.Type = TokenType.LESS; break;
                case '>': token.Type = TokenType.GREATER; break;
                default:
                    token.Type = TokenType.UNKNOWN;
                    token.IsError = true;
                    token.ErrorMessage = $"Недопустимый символ '{current}'";
                    break;
            }

            position++;
            linePosition++;
            tokens.Add(token);
        }

        private void ProcessComment()
        {
            int startPos = linePosition;
            int startIndex = position;

            position += 2;
            linePosition += 2;

            while (position < input.Length && input[position] != '\n')
            {
                position++;
                linePosition++;
            }

            string value = input.Substring(startIndex, position - startIndex);

            Token token = new Token
            {
                Type = TokenType.COMMENT,
                Value = value,
                Line = line,
                StartPosition = startPos,
                EndPosition = linePosition - 1
            };

            tokens.Add(token);
        }


        public List<LexicalException> GetErrors()
        {
            return errors;
        }

        public bool HasErrors => errors.Count > 0;
    }
}