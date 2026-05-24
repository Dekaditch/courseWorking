using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab1.Compilation
{
    public class ExpressionCompiler
    {
        private CompilationScaner scanner;
        private CompilationParser parser;
        private CompilationTetrads tetradsGenerator;
        private CompilationPolis polisGenerator;

        public ExpressionCompiler()
        {
            scanner = new CompilationScaner();
            parser = new CompilationParser();
            tetradsGenerator = new CompilationTetrads();
            polisGenerator = new CompilationPolis();
        }

        public CompilationResult Compile(string expression, int language = 1)
        {
            var result = new CompilationResult();
            result.OriginalExpression = expression;

            try
            {
                if (string.IsNullOrWhiteSpace(expression))
                {
                    result.Success = false;
                    result.ErrorMessage = "Выражение не может быть пустым";
                    return result;
                }

                var richTextBox = new RichTextBox { Text = expression };
                var scanResult = scanner.Find_All_Tokens(richTextBox);

                result.RawCodes = scanResult.Item1;
                result.RawTokens = scanResult.Item2;
                result.RawLines = scanResult.Item3;
                result.RawPositions = scanResult.Item4;

                var cleaned = parser.Space_Clean(result.RawTokens, result.RawCodes, result.RawLines, result.RawPositions);
                result.CleanTokens = cleaned.Item1;
                result.CleanCodes = cleaned.Item2;
                result.CleanLines = cleaned.Item3;
                result.CleanPositions = cleaned.Item4;

                var errors = parser.Parser(result.CleanTokens, result.CleanCodes, language);
                if (errors != null && errors.Count > 0)
                {
                    result.Success = false;
                    result.Errors = errors;
                    return result;
                }

                result.Tetrads = tetradsGenerator.Tetrads(result.CleanTokens);
                result.Polis = polisGenerator.Polis(result.Tetrads, language);

                if (result.Polis != null && result.Polis.Length > 0)
                {
                    result.Result = result.Polis[result.Polis.Length - 1];
                }

                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public string GetResult()
        {
            if (polisGenerator.PolisRows.Count > 0)
            {
                return polisGenerator.PolisRows[polisGenerator.PolisRows.Count - 1].Result;
            }
            return "0";
        }
    }

    public class CompilationResult
    {
        public bool Success { get; set; }
        public string OriginalExpression { get; set; }
        public string Result { get; set; }
        public string ErrorMessage { get; set; }

        public int[] RawCodes { get; set; }
        public string[] RawTokens { get; set; }
        public int[] RawLines { get; set; }
        public int[] RawPositions { get; set; }

        public string[] CleanTokens { get; set; }
        public int[] CleanCodes { get; set; }
        public int[] CleanLines { get; set; }
        public int[] CleanPositions { get; set; }

        public Dictionary<int, (int, string)> Errors { get; set; }
        public List<string[]> Tetrads { get; set; }
        public string[] Polis { get; set; }

        public CompilationResult()
        {
            Errors = new Dictionary<int, (int, string)>();
            Tetrads = new List<string[]>();
        }

        public int GetErrorCount() => Errors?.Count ?? 0;
        public int GetTetradCount() => Tetrads?.Count ?? 0;
        public int GetPolisLength() => Polis?.Length ?? 0;
    }
}