using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1.LexicalAnalysis;
using lab1.SyntaxAnalysis;

namespace lab1.Managers
{
    public class SyntaxManager
    {
        private Scanner scanner;
        private Parser parser;
        private DataGridView dataGridView;
        private RichTextBox editorTextBox;
        private Label errorCountLabel;

        public SyntaxManager(DataGridView dataGridView, RichTextBox editorTextBox, Label errorCountLabel = null)
        {
            this.scanner = new Scanner();
            this.parser = new Parser(new List<Token>()); // или добавить пустой конструктор
            this.dataGridView = dataGridView;
            this.editorTextBox = editorTextBox;
            this.errorCountLabel = errorCountLabel;

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            if (dataGridView == null) return;

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            DataGridViewTextBoxColumn fragmentColumn = new DataGridViewTextBoxColumn();
            fragmentColumn.Name = "Fragment";
            fragmentColumn.HeaderText = "Неверный фрагмент";
            fragmentColumn.Width = 150;
            dataGridView.Columns.Add(fragmentColumn);

            DataGridViewTextBoxColumn locationColumn = new DataGridViewTextBoxColumn();
            locationColumn.Name = "Location";
            locationColumn.HeaderText = "Местоположение";
            locationColumn.Width = 150;
            dataGridView.Columns.Add(locationColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.Name = "Description";
            descriptionColumn.HeaderText = "Описание ошибки";
            descriptionColumn.Width = 400;
            dataGridView.Columns.Add(descriptionColumn);

            dataGridView.CellClick += DataGridView_CellClick;
        }

        public void RunAnalysis()
        {
            try
            {
                string text = editorTextBox.Text;

                dataGridView.Rows.Clear();

                List<Token> tokens = scanner.Analyze(text);

                parser = new Parser(tokens);
                parser.ParseProgram();
                List<SyntaxError> syntaxErrors = parser.Errors;



                foreach (SyntaxError error in syntaxErrors)
                {
                    int rowIndex = dataGridView.Rows.Add();
                    DataGridViewRow row = dataGridView.Rows[rowIndex];

                    row.Cells["Fragment"].Value = error.InvalidFragment;
                    row.Cells["Location"].Value = $"строка {error.Line}, позиция {error.Position}";
                    row.Cells["Description"].Value = error.Description;

                    row.Tag = error;
                }

                if (errorCountLabel != null)
                {
                    errorCountLabel.Text = $"Общее количество ошибок: {syntaxErrors.Count}";
                }

                if (syntaxErrors.Count == 0)
                {
                    dataGridView.Rows.Add(new object[] { "-", "-", "Синтаксических ошибок не обнаружено" });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при анализе: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            if (row.Tag is SyntaxError error)
            {
                // Перемещаем курсор в редакторе
                NavigateToError(error);
            }
        }

        private void NavigateToError(SyntaxError error)
        {
            try
            {
                int charIndex = GetCharIndexFromPosition(error.Line, error.Position);
                if (charIndex >= 0)
                {
                    editorTextBox.SelectionStart = charIndex;
                    editorTextBox.SelectionLength = error.InvalidFragment.Length;
                    editorTextBox.ScrollToCaret();
                    editorTextBox.Focus();

                    editorTextBox.SelectionBackColor = System.Drawing.Color.LightYellow;
                    var timer = new System.Windows.Forms.Timer();
                    timer.Interval = 500;
                    timer.Tick += (s, args) =>
                    {
                        editorTextBox.SelectionBackColor = System.Drawing.Color.White;
                        timer.Stop();
                    };
                    timer.Start();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private int GetCharIndexFromPosition(int line, int position)
        {
            string[] lines = editorTextBox.Text.Split('\n');
            if (line <= lines.Length)
            {
                int charIndex = 0;
                for (int i = 0; i < line - 1; i++)
                {
                    charIndex += lines[i].Length + 1;
                }
                return charIndex + (position - 1);
            }
            return -1;
        }

        public void ClearResults()
        {
            dataGridView.Rows.Clear();
            if (errorCountLabel != null)
            {
                errorCountLabel.Text = "Общее количество ошибок: 0";
            }
        }
    }
}