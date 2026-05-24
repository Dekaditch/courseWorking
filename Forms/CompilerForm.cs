using System;
using System.Drawing;
using System.Windows.Forms;
using lab1.Compilation;

namespace lab1.Forms
{
    public partial class CompilerForm : Form
    {
        private ExpressionCompiler compiler;

        private RichTextBox txtExpression;
        private Button btnCompile;
        private Button btnClear;
        private Label lblStatus;
        private TabControl tabResults;

        private DataGridView dgvTokens;
        private DataGridView dgvErrors;
        private DataGridView dgvTetrads;
        private DataGridView dgvPolis;
        private RichTextBox txtResult;

        public CompilerForm()
        {
            InitializeComponent();
            compiler = new ExpressionCompiler();
        }

        private void InitializeComponent()
        {
            this.txtExpression = new RichTextBox();
            this.btnCompile = new Button();
            this.btnClear = new Button();
            this.lblStatus = new Label();
            this.tabResults = new TabControl();

            var tabTokens = new TabPage("Лексический анализ");
            var tabErrors = new TabPage("Синтаксический анализ");
            var tabTetrads = new TabPage("Тетрады");
            var tabPolis = new TabPage("ПОЛИЗ");
            var tabResult = new TabPage("Результат");

            this.dgvTokens = new DataGridView();
            this.dgvErrors = new DataGridView();
            this.dgvTetrads = new DataGridView();
            this.dgvPolis = new DataGridView();
            this.txtResult = new RichTextBox();

            this.SuspendLayout();

            this.txtExpression.Font = new Font("Consolas", 12F);
            this.txtExpression.Location = new Point(12, 12);
            this.txtExpression.Size = new Size(500, 120);
            this.txtExpression.Text = "1 + 2 * 3;";
            this.txtExpression.WordWrap = false;

            this.btnCompile.BackColor = Color.LightGreen;
            this.btnCompile.FlatStyle = FlatStyle.Flat;
            this.btnCompile.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.btnCompile.Location = new Point(520, 12);
            this.btnCompile.Size = new Size(130, 50);
            this.btnCompile.Text = "▶ Компилировать";
            this.btnCompile.UseVisualStyleBackColor = false;
            this.btnCompile.Click += BtnCompile_Click;

            this.btnClear.Location = new Point(520, 70);
            this.btnClear.Size = new Size(130, 30);
            this.btnClear.Text = "🗑 Очистить";
            this.btnClear.Click += BtnClear_Click;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            this.lblStatus.Location = new Point(12, 145);
            this.lblStatus.Size = new Size(111, 15);
            this.lblStatus.Text = "Готов к работе";

            this.tabResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tabResults.Controls.Add(tabTokens);
            this.tabResults.Controls.Add(tabErrors);
            this.tabResults.Controls.Add(tabTetrads);
            this.tabResults.Controls.Add(tabPolis);
            this.tabResults.Controls.Add(tabResult);
            this.tabResults.Location = new Point(12, 165);
            this.tabResults.Size = new Size(660, 350);
            this.tabResults.TabIndex = 6;

            tabTokens.Controls.Add(this.dgvTokens);
            this.dgvTokens.Dock = DockStyle.Fill;
            SetupTokensGrid();

            tabErrors.Controls.Add(this.dgvErrors);
            this.dgvErrors.Dock = DockStyle.Fill;
            SetupErrorsGrid();

            tabTetrads.Controls.Add(this.dgvTetrads);
            this.dgvTetrads.Dock = DockStyle.Fill;
            SetupTetradsGrid();

            tabPolis.Controls.Add(this.dgvPolis);
            this.dgvPolis.Dock = DockStyle.Fill;
            SetupPolisGrid();

            tabResult.Controls.Add(this.txtResult);
            this.txtResult.Dock = DockStyle.Fill;
            this.txtResult.Font = new Font("Consolas", 12F);
            this.txtResult.ReadOnly = true;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(684, 527);
            this.Controls.Add(this.tabResults);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.txtExpression);
            this.Name = "CompilerForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Компилятор арифметических выражений";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupTokensGrid()
        {
            dgvTokens.Columns.Clear();
            dgvTokens.Columns.Add("Token", "Токен");
            dgvTokens.Columns.Add("Code", "Код");
            dgvTokens.Columns.Add("Type", "Тип токена");
            dgvTokens.Columns.Add("Line", "Строка");
            dgvTokens.Columns.Add("Pos", "Позиция");
            dgvTokens.AllowUserToAddRows = false;
            dgvTokens.ReadOnly = true;
            dgvTokens.Columns["Token"].Width = 100;
            dgvTokens.Columns["Code"].Width = 60;
            dgvTokens.Columns["Type"].Width = 140;
            dgvTokens.Columns["Line"].Width = 60;
            dgvTokens.Columns["Pos"].Width = 80;
        }

        private void SetupErrorsGrid()
        {
            dgvErrors.Columns.Clear();
            dgvErrors.Columns.Add("Line", "Строка/Позиция");
            dgvErrors.Columns.Add("Message", "Сообщение");
            dgvErrors.AllowUserToAddRows = false;
            dgvErrors.ReadOnly = true;
            dgvErrors.Columns["Message"].Width = 500;
        }

        private void SetupTetradsGrid()
        {
            dgvTetrads.Columns.Clear();
            dgvTetrads.Columns.Add("Op", "Операция");
            dgvTetrads.Columns.Add("Left", "Левый операнд");
            dgvTetrads.Columns.Add("Right", "Правый операнд");
            dgvTetrads.Columns.Add("Result", "Результат");
            dgvTetrads.AllowUserToAddRows = false;
            dgvTetrads.ReadOnly = true;
            dgvTetrads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupPolisGrid()
        {
            dgvPolis.Columns.Clear();
            dgvPolis.Columns.Add("Number", "№");
            dgvPolis.Columns.Add("Operand1", "Операнд 1");
            dgvPolis.Columns.Add("Operand2", "Операнд 2");
            dgvPolis.Columns.Add("Operator", "Оператор");
            dgvPolis.Columns.Add("Result", "Результат");

            dgvPolis.Columns["Number"].Width = 60;
            dgvPolis.Columns["Operand1"].Width = 120;
            dgvPolis.Columns["Operand2"].Width = 120;
            dgvPolis.Columns["Operator"].Width = 80;
            dgvPolis.Columns["Result"].Width = 100;

            dgvPolis.AllowUserToAddRows = false;
            dgvPolis.ReadOnly = true;
        }

        private string GetTokenType(int code)
        {
            switch (code)
            {
                case 1: return "ИДЕНТИФИКАТОР";
                case 2: return "РАЗДЕЛИТЕЛЬ";
                case 3: return "РАЗДЕЛИТЕЛЬ";
                case 4: return "ОПЕРАТОР";
                case 5: return "ОПЕРАТОР";
                case 6: return "ОПЕРАТОР";
                case 7: return "ОПЕРАТОР";
                case 8: return "ОПЕРАТОР";
                case 9: return "РАЗДЕЛИТЕЛЬ";
                case 10: return "РАЗДЕЛИТЕЛЬ";
                case 11: return "ЦЕЛОЕ ЧИСЛО";
                case 12: return "ВЕЩЕСТВЕННОЕ ЧИСЛО";
                default: return "НЕИЗВЕСТНЫЙ";
            }
        }

        private void BtnCompile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text))
            {
                MessageBox.Show("Введите выражение для компиляции!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearResults();
            lblStatus.Text = "Компиляция...";
            lblStatus.ForeColor = Color.Blue;
            Application.DoEvents();

            var result = compiler.Compile(txtExpression.Text, 1);

            if (result.RawTokens != null)
            {
                for (int i = 0; i < result.RawTokens.Length; i++)
                {
                    if (result.RawTokens[i] != "space")
                    {
                        string tokenType = GetTokenType(result.RawCodes[i]);
                        dgvTokens.Rows.Add(result.RawTokens[i], result.RawCodes[i], tokenType, result.RawLines[i], result.RawPositions[i]);
                    }
                }
            }

            if (!result.Success)
            {
                if (result.Errors != null && result.Errors.Count > 0)
                {
                    foreach (var err in result.Errors)
                    {
                        dgvErrors.Rows.Add(err.Value.Item1, err.Value.Item2);
                    }
                    lblStatus.Text = $"Ошибка: обнаружено {result.Errors.Count} синтаксических ошибок";
                }
                else if (!string.IsNullOrEmpty(result.ErrorMessage))
                {
                    dgvErrors.Rows.Add("0", result.ErrorMessage);
                    lblStatus.Text = $"Ошибка: {result.ErrorMessage}";
                }
                else
                {
                    dgvErrors.Rows.Add("0", "Неизвестная ошибка при компиляции");
                    lblStatus.Text = "Ошибка компиляции";
                }
                lblStatus.ForeColor = Color.Red;
                tabResults.SelectedIndex = 1;
                return;
            }

            dgvErrors.Rows.Add("-", "Ошибок не найдено. Синтаксический анализ успешно завершен.");

            if (result.Tetrads != null && result.Tetrads.Count > 0)
            {
                for (int i = 0; i < result.Tetrads.Count; i++)
                {
                    var tetrad = result.Tetrads[i];
                    dgvTetrads.Rows.Add(tetrad[0], tetrad[1], tetrad[2], tetrad[3]);
                }
            }

            var polisGen = new CompilationPolis();
            polisGen.Polis(result.Tetrads, 1);

            foreach (var row in polisGen.PolisRows)
            {
                dgvPolis.Rows.Add(row.Number, row.Operand1, row.Operand2, row.Operator, row.Result);
            }

            string finalResult = polisGen.PolisRows.Count > 0 ? polisGen.PolisRows[polisGen.PolisRows.Count - 1].Result : "0";

            txtResult.Text = $"Исходное выражение:\n{result.OriginalExpression}\n\n";
            txtResult.Text += $"Результат вычисления:\n{finalResult}\n\n";
            txtResult.Text += $"Статистика:\n";
            txtResult.Text += $"├─ Количество токенов: {(result.RawTokens?.Length ?? 0)}\n";
            txtResult.Text += $"├─ Количество тетрад: {result.GetTetradCount()}\n";
            txtResult.Text += $"└─ Длина ПОЛИЗа: {result.GetPolisLength()}\n";

            MessageBox.Show($"Результат выражения: {finalResult}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblStatus.Text = $"Успешно! Результат: {finalResult}";
            lblStatus.ForeColor = Color.Green;
            tabResults.SelectedIndex = 4;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearResults();
            txtExpression.Clear();
            lblStatus.Text = "Готов к работе";
            lblStatus.ForeColor = Color.Black;
        }

        private void ClearResults()
        {
            dgvTokens.Rows.Clear();
            dgvErrors.Rows.Clear();
            dgvTetrads.Rows.Clear();
            dgvPolis.Rows.Clear();
            txtResult.Clear();
        }
    }
}