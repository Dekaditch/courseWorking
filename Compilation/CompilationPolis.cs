using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab1.Compilation
{
    public class CompilationPolis
    {
        public class PolisRow
        {
            public int Number { get; set; }
            public string Operand1 { get; set; }
            public string Operand2 { get; set; }
            public string Operator { get; set; }
            public string Result { get; set; }
        }

        public List<PolisRow> PolisRows { get; private set; }

        public CompilationPolis()
        {
            PolisRows = new List<PolisRow>();
        }

        public string[] Polis(List<string[]> tetrads, int lang)
        {
            List<string> polis = new List<string>();
            Dictionary<string, int> t_values = new Dictionary<string, int>();
            PolisRows.Clear();

            foreach (var tetrad in tetrads)
            {
                string op = tetrad[0];
                string operand_1 = tetrad[1];
                string operand_2 = tetrad[2];
                string result = tetrad[3];

                int val_1 = Get_Value(operand_1, t_values);
                int val_2 = Get_Value(operand_2, t_values);

                int calc_res = 0;
                switch (op)
                {
                    case "+": calc_res = val_1 + val_2; break;
                    case "-": calc_res = val_1 - val_2; break;
                    case "*": calc_res = val_1 * val_2; break;
                    case "/":
                        if (val_2 == 0)
                        {
                            calc_res = 0;
                            break;
                        }
                        calc_res = val_1 / val_2;
                        break;
                    case "%":
                        if (val_2 == 0)
                        {
                            calc_res = 0;
                            break;
                        }
                        calc_res = val_1 % val_2;
                        break;
                }

                t_values[result] = calc_res;

                PolisRows.Add(new PolisRow
                {
                    Number = PolisRows.Count + 1,
                    Operand1 = operand_1,
                    Operand2 = operand_2,
                    Operator = op,
                    Result = calc_res.ToString()
                });

                polis.Add(operand_1);
                polis.Add(operand_2);
                polis.Add(op);
                polis.Add(calc_res.ToString());
            }

            return polis.ToArray();
        }

        private int Get_Value(string operand, Dictionary<string, int> t_values)
        {
            if (operand.EndsWith("t") && operand.Length > 1)
            {
                if (t_values.ContainsKey(operand))
                    return t_values[operand];
                return 0;
            }

            if (int.TryParse(operand, out int result))
                return result;

            return 0;
        }
    }
}