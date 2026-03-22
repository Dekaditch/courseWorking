using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.LexicalAnalysis;

namespace lab1.SyntaxAnalysis
{
    public class Parser
    {
        private List<Token> tokens;
        private int position;
        private List<SyntaxError> errors;
        private string originalText;

        public Parser()
        {
            errors = new List<SyntaxError>();
        }

        public List<SyntaxError> Parse(string text, List<Token> tokensList)
        {
            originalText = text;
            tokens = tokensList;
            position = 0;
            errors.Clear();

            try
            {
                ParseFTYPE();

                if (position < tokens.Count)
                {
                    Token current = tokens[position];
                    AddError("конец программы", current.Line, current.StartPosition,
                        current.Value, GetTokenStartIndex(current));
                }
            }
            catch (Exception ex)
            {
                errors.Add(new SyntaxError(ex.Message, 1, 1, "Критическая ошибка анализа", 0));
            }

            return errors;
        }

        private Token Current => position < tokens.Count ? tokens[position] : null;
        private bool IsEnd => position >= tokens.Count;
        private void Advance() => position++;

        private bool Check(TokenType type) => Current != null && Current.Type == type;

        private bool Match(TokenType type)
        {
            if (Check(type))
            {
                Advance();
                return true;
            }
            return false;
        }

        private void ParseFTYPE()
        {
            if (!Check(TokenType.KW_INT) && !Check(TokenType.KW_FLOAT))
            {
                AddError("'int' или 'float'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "начало", GetTokenStartIndex(Current));
                SkipToNextKeyword();
                return;
            }
            Advance(); 
            ParseFSPACE();
        }

        private void ParseFSPACE()
        {
            ParseFID();
        }

        private void ParseFID()
        {
            if (Check(TokenType.IDENTIFIER))
            {
                Advance(); 
                ParseOPENQ();
            }
            else
            {
                AddError("идентификатор", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToNextIdentifier();
            }
        }

        private void ParseOPENQ()
        {
            if (Match(TokenType.LPAREN))
            {
                ParsePTYPE();
            }
            else
            {
                AddError("'('", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToChar('(');
                if (Match(TokenType.LPAREN))
                {
                    ParsePTYPE();
                }
            }
        }

        private void ParsePTYPE()
        {
            if (!Check(TokenType.KW_INT) && !Check(TokenType.KW_FLOAT))
            {
                AddError("'int' или 'float'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToNextKeyword();
                return;
            }
            Advance(); 
            ParsePSPACE();
        }

        private void ParsePSPACE()
        {
            ParsePID();
        }

        private void ParsePID()
        {
            if (Check(TokenType.IDENTIFIER))
            {
                Advance(); 

                if (Check(TokenType.COMMA))
                {
                    ParseCOMMA();
                }
                else if (Check(TokenType.RPAREN))
                {
                    ParseCLOSEQ();
                }
                else
                {
                    AddError("',' или ')'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                        Current?.Value ?? "конец", GetTokenStartIndex(Current));
                    SkipToChar(',', ')');
                    if (Check(TokenType.COMMA))
                    {
                        ParseCOMMA();
                    }
                    else if (Check(TokenType.RPAREN))
                    {
                        ParseCLOSEQ();
                    }
                }
            }
            else
            {
                AddError("идентификатор", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
            }
        }

        private void ParseCOMMA()
        {
            if (Match(TokenType.COMMA))
            {
                ParsePTYPE();
            }
            else
            {
                AddError("','", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
            }
        }

        private void ParseCLOSEQ()
        {
            if (Match(TokenType.RPAREN))
            {
                ParseOPENF();
            }
            else
            {
                AddError("')'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToChar(')');
                if (Match(TokenType.RPAREN))
                {
                    ParseOPENF();
                }
            }
        }

        private void ParseOPENF()
        {
            if (Match(TokenType.LBRACE))
            {
                ParseRETURN();
            }
            else
            {
                AddError("'{'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToChar('{');
                if (Match(TokenType.LBRACE))
                {
                    ParseRETURN();
                }
            }
        }

        private void ParseRETURN()
        {
            if (Match(TokenType.KW_RETURN))
            {
                ParseBSPACE();
            }
            else
            {
                AddError("'return'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToKeyword("return");
                if (Match(TokenType.KW_RETURN))
                {
                    ParseBSPACE();
                }
            }
        }
        private void ParseBSPACE()
        {
            if (Check(TokenType.IDENTIFIER) || Check(TokenType.INTEGER) ||
                Check(TokenType.FLOAT) || Check(TokenType.LPAREN))
            {
                ParseE();
                ParseCOLON();
            }
            else
            {
                ParseCOLON();
            }
        }

        private void ParseCOLON()
        {
            if (Match(TokenType.SEMICOLON))
            {
                ParseCLOSEF();
            }
            else
            {
                AddError("';'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToChar(';');
                if (Match(TokenType.SEMICOLON))
                {
                    ParseCLOSEF();
                }
            }
        }

        private void ParseCLOSEF()
        {
            if (Match(TokenType.RBRACE))
            {
                ParseEND();
            }
            else
            {
                AddError("'}'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                SkipToChar('}');
                if (Match(TokenType.RBRACE))
                {
                    ParseEND();
                }
            }
        }

        private void ParseEND()
        {
            if (Match(TokenType.SEMICOLON))
            {
                // Успешно
            }
            else
            {
                AddError("';'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
            }
        }

        private void ParseE()
        {
            ParseT();
            ParseA();
        }

        private void ParseA()
        {
            if (Match(TokenType.PLUS))
            {
                ParseT();
                ParseA();
            }
            else if (Match(TokenType.MINUS))
            {
                ParseT();
                ParseA();
            }
        }

        private void ParseT()
        {
            ParseF();
            ParseB();
        }

        private void ParseB()
        {
            if (Match(TokenType.MULTIPLY))
            {
                ParseF();
                ParseB();
            }
            else if (Match(TokenType.DIVIDE))
            {
                ParseF();
                ParseB();
            }
        }

        private void ParseF()
        {
            if (Check(TokenType.IDENTIFIER))
            {
                Advance(); 
                if (Check(TokenType.LPAREN))
                {
                    Match(TokenType.LPAREN);
                    ParseE();
                    if (!Match(TokenType.RPAREN))
                    {
                        AddError("')'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                            Current?.Value ?? "конец", GetTokenStartIndex(Current));
                    }
                }
            }
            else if (Check(TokenType.INTEGER) || Check(TokenType.FLOAT))
            {
                Advance(); 
            }
            else if (Match(TokenType.LPAREN))
            {
                ParseE();
                if (!Match(TokenType.RPAREN))
                {
                    AddError("')'", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                        Current?.Value ?? "конец", GetTokenStartIndex(Current));
                }
            }
            else
            {
                AddError("идентификатор, число или '('", Current?.Line ?? 1, Current?.StartPosition ?? 1,
                    Current?.Value ?? "конец", GetTokenStartIndex(Current));
                if (Current != null)
                {
                    Advance();
                }
            }
        }


        private void SkipToNextKeyword()
        {
            while (!IsEnd)
            {
                if (Check(TokenType.KW_INT) || Check(TokenType.KW_FLOAT) ||
                    Check(TokenType.KW_RETURN))
                {
                    return;
                }
                Advance();
            }
        }

        private void SkipToNextIdentifier()
        {
            while (!IsEnd)
            {
                if (Check(TokenType.IDENTIFIER))
                {
                    return;
                }
                Advance();
            }
        }

        private void SkipToChar(params char[] chars)
        {
            while (!IsEnd)
            {
                if (Current != null && Current.Value.Length == 1)
                {
                    char currentChar = Current.Value[0];
                    if (chars.Contains(currentChar))
                    {
                        return;
                    }
                }
                Advance();
            }
        }

        private void SkipToKeyword(string keyword)
        {
            while (!IsEnd)
            {
                if (Current != null && Current.Value == keyword)
                {
                    return;
                }
                Advance();
            }
        }

        private int GetTokenStartIndex(Token token)
        {
            if (token == null) return -1;

            string[] lines = originalText.Split('\n');
            if (token.Line <= lines.Length)
            {
                int charIndex = 0;
                for (int i = 0; i < token.Line - 1; i++)
                {
                    charIndex += lines[i].Length + 1;
                }
                return charIndex + (token.StartPosition - 1);
            }
            return -1;
        }

        private void AddError(string expected, int line, int position, string fragment, int startIndex)
        {
            string description = $"Ожидалось: {expected}";
            errors.Add(new SyntaxError(fragment, line, position, description, startIndex));
        }
    }
}