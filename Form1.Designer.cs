namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileStrip = new System.Windows.Forms.ToolStripTextBox();
            this.openFileStrip = new System.Windows.Forms.ToolStripTextBox();
            this.saveFileStrip = new System.Windows.Forms.ToolStripTextBox();
            this.saveHowStrip = new System.Windows.Forms.ToolStripTextBox();
            this.editStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.undoStrip = new System.Windows.Forms.ToolStripTextBox();
            this.redoStrip = new System.Windows.Forms.ToolStripTextBox();
            this.cutStrip = new System.Windows.Forms.ToolStripTextBox();
            this.copyStrip = new System.Windows.Forms.ToolStripTextBox();
            this.pasteStrip = new System.Windows.Forms.ToolStripTextBox();
            this.deleteStrip = new System.Windows.Forms.ToolStripTextBox();
            this.selectAllStrip = new System.Windows.Forms.ToolStripTextBox();
            this.textStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.taskDescStrip = new System.Windows.Forms.ToolStripTextBox();
            this.grammarStrip = new System.Windows.Forms.ToolStripTextBox();
            this.gramClassStrip = new System.Windows.Forms.ToolStripTextBox();
            this.parsingMethod = new System.Windows.Forms.ToolStripTextBox();
            this.testStrip = new System.Windows.Forms.ToolStripTextBox();
            this.literatStrip = new System.Windows.Forms.ToolStripTextBox();
            this.codeStrip = new System.Windows.Forms.ToolStripTextBox();
            this.startStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.infoStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.infoShowStrip = new System.Windows.Forms.ToolStripTextBox();
            this.aboutStrip = new System.Windows.Forms.ToolStripTextBox();
            this.exitStrip = new System.Windows.Forms.ToolStripTextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 150);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 271);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(776, 150);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.editStrip,
            this.textStrip,
            this.startStrip,
            this.infoStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileStrip,
            this.openFileStrip,
            this.saveFileStrip,
            this.saveHowStrip,
            this.exitStrip});
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(48, 20);
            this.fileStrip.Text = "Файл";
            // 
            // createFileStrip
            // 
            this.createFileStrip.Enabled = false;
            this.createFileStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createFileStrip.Name = "createFileStrip";
            this.createFileStrip.ReadOnly = true;
            this.createFileStrip.Size = new System.Drawing.Size(100, 23);
            this.createFileStrip.Text = "Создать";
            // 
            // openFileStrip
            // 
            this.openFileStrip.Enabled = false;
            this.openFileStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openFileStrip.Name = "openFileStrip";
            this.openFileStrip.ReadOnly = true;
            this.openFileStrip.Size = new System.Drawing.Size(100, 23);
            this.openFileStrip.Text = "Открыть";
            // 
            // saveFileStrip
            // 
            this.saveFileStrip.Enabled = false;
            this.saveFileStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveFileStrip.Name = "saveFileStrip";
            this.saveFileStrip.ReadOnly = true;
            this.saveFileStrip.Size = new System.Drawing.Size(100, 23);
            this.saveFileStrip.Text = "Сохранить";
            // 
            // saveHowStrip
            // 
            this.saveHowStrip.Enabled = false;
            this.saveHowStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveHowStrip.Name = "saveHowStrip";
            this.saveHowStrip.ReadOnly = true;
            this.saveHowStrip.Size = new System.Drawing.Size(100, 23);
            this.saveHowStrip.Text = "Сохранить как";
            // 
            // editStrip
            // 
            this.editStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoStrip,
            this.redoStrip,
            this.cutStrip,
            this.copyStrip,
            this.pasteStrip,
            this.deleteStrip,
            this.selectAllStrip});
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(59, 20);
            this.editStrip.Text = "Правка";
            // 
            // undoStrip
            // 
            this.undoStrip.Enabled = false;
            this.undoStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.undoStrip.Name = "undoStrip";
            this.undoStrip.ReadOnly = true;
            this.undoStrip.Size = new System.Drawing.Size(100, 23);
            this.undoStrip.Text = "Отменить";
            // 
            // redoStrip
            // 
            this.redoStrip.Enabled = false;
            this.redoStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.redoStrip.Name = "redoStrip";
            this.redoStrip.ReadOnly = true;
            this.redoStrip.Size = new System.Drawing.Size(100, 23);
            this.redoStrip.Text = "Повторить";
            // 
            // cutStrip
            // 
            this.cutStrip.Enabled = false;
            this.cutStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cutStrip.Name = "cutStrip";
            this.cutStrip.ReadOnly = true;
            this.cutStrip.Size = new System.Drawing.Size(100, 23);
            this.cutStrip.Text = "Вырезать";
            // 
            // copyStrip
            // 
            this.copyStrip.Enabled = false;
            this.copyStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.copyStrip.Name = "copyStrip";
            this.copyStrip.ReadOnly = true;
            this.copyStrip.Size = new System.Drawing.Size(100, 23);
            this.copyStrip.Text = "Копировать";
            // 
            // pasteStrip
            // 
            this.pasteStrip.Enabled = false;
            this.pasteStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pasteStrip.Name = "pasteStrip";
            this.pasteStrip.ReadOnly = true;
            this.pasteStrip.Size = new System.Drawing.Size(100, 23);
            this.pasteStrip.Text = "Вставить";
            // 
            // deleteStrip
            // 
            this.deleteStrip.Enabled = false;
            this.deleteStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteStrip.Name = "deleteStrip";
            this.deleteStrip.ReadOnly = true;
            this.deleteStrip.Size = new System.Drawing.Size(100, 23);
            this.deleteStrip.Text = "Удалить";
            // 
            // selectAllStrip
            // 
            this.selectAllStrip.Enabled = false;
            this.selectAllStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectAllStrip.Name = "selectAllStrip";
            this.selectAllStrip.ReadOnly = true;
            this.selectAllStrip.Size = new System.Drawing.Size(100, 23);
            this.selectAllStrip.Text = "Выделить все";
            // 
            // textStrip
            // 
            this.textStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskDescStrip,
            this.grammarStrip,
            this.gramClassStrip,
            this.parsingMethod,
            this.testStrip,
            this.literatStrip,
            this.codeStrip});
            this.textStrip.Name = "textStrip";
            this.textStrip.Size = new System.Drawing.Size(48, 20);
            this.textStrip.Text = "Текст";
            // 
            // taskDescStrip
            // 
            this.taskDescStrip.Enabled = false;
            this.taskDescStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskDescStrip.Name = "taskDescStrip";
            this.taskDescStrip.ReadOnly = true;
            this.taskDescStrip.Size = new System.Drawing.Size(110, 23);
            this.taskDescStrip.Text = "Постановка задачи";
            // 
            // grammarStrip
            // 
            this.grammarStrip.Enabled = false;
            this.grammarStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grammarStrip.Name = "grammarStrip";
            this.grammarStrip.ReadOnly = true;
            this.grammarStrip.Size = new System.Drawing.Size(100, 23);
            this.grammarStrip.Text = "Грамматика";
            // 
            // gramClassStrip
            // 
            this.gramClassStrip.Enabled = false;
            this.gramClassStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gramClassStrip.Name = "gramClassStrip";
            this.gramClassStrip.ReadOnly = true;
            this.gramClassStrip.Size = new System.Drawing.Size(155, 23);
            this.gramClassStrip.Text = "Классификация граматики";
            // 
            // parsingMethod
            // 
            this.parsingMethod.Enabled = false;
            this.parsingMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.parsingMethod.Name = "parsingMethod";
            this.parsingMethod.ReadOnly = true;
            this.parsingMethod.Size = new System.Drawing.Size(100, 23);
            this.parsingMethod.Text = "Метод анализа";
            // 
            // testStrip
            // 
            this.testStrip.Enabled = false;
            this.testStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.testStrip.Name = "testStrip";
            this.testStrip.ReadOnly = true;
            this.testStrip.Size = new System.Drawing.Size(110, 23);
            this.testStrip.Text = "Тестовый пример";
            // 
            // literatStrip
            // 
            this.literatStrip.Enabled = false;
            this.literatStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.literatStrip.Name = "literatStrip";
            this.literatStrip.ReadOnly = true;
            this.literatStrip.Size = new System.Drawing.Size(115, 23);
            this.literatStrip.Text = "Список литературы";
            // 
            // codeStrip
            // 
            this.codeStrip.Enabled = false;
            this.codeStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeStrip.Name = "codeStrip";
            this.codeStrip.ReadOnly = true;
            this.codeStrip.Size = new System.Drawing.Size(155, 23);
            this.codeStrip.Text = "Исходный код программы";
            // 
            // startStrip
            // 
            this.startStrip.Name = "startStrip";
            this.startStrip.Size = new System.Drawing.Size(46, 20);
            this.startStrip.Text = "Пуск";
            // 
            // infoStrip
            // 
            this.infoStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoShowStrip,
            this.aboutStrip});
            this.infoStrip.Name = "infoStrip";
            this.infoStrip.Size = new System.Drawing.Size(65, 20);
            this.infoStrip.Text = "Справка";
            // 
            // infoShowStrip
            // 
            this.infoShowStrip.Enabled = false;
            this.infoShowStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infoShowStrip.Name = "infoShowStrip";
            this.infoShowStrip.ReadOnly = true;
            this.infoShowStrip.Size = new System.Drawing.Size(100, 23);
            this.infoShowStrip.Text = "Вызов справки";
            // 
            // aboutStrip
            // 
            this.aboutStrip.Enabled = false;
            this.aboutStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aboutStrip.Name = "aboutStrip";
            this.aboutStrip.ReadOnly = true;
            this.aboutStrip.Size = new System.Drawing.Size(100, 23);
            this.aboutStrip.Text = "О программе";
            // 
            // exitStrip
            // 
            this.exitStrip.Enabled = false;
            this.exitStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitStrip.Name = "exitStrip";
            this.exitStrip.ReadOnly = true;
            this.exitStrip.Size = new System.Drawing.Size(100, 23);
            this.exitStrip.Text = "Выход";
            // 
            // button11
            // 
            this.button11.Image = global::lab1.Properties.Resources.icons8_информация_30;
            this.button11.Location = new System.Drawing.Point(582, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 45);
            this.button11.TabIndex = 14;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::lab1.Properties.Resources.icons8_вопрос_30;
            this.button10.Location = new System.Drawing.Point(525, 41);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 45);
            this.button10.TabIndex = 13;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = global::lab1.Properties.Resources.icons8_начало_30;
            this.button9.Location = new System.Drawing.Point(468, 41);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 45);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::lab1.Properties.Resources.icons8_вставить_30;
            this.button8.Location = new System.Drawing.Point(411, 41);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 45);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::lab1.Properties.Resources.icons8_вырезать_30;
            this.button7.Location = new System.Drawing.Point(354, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 45);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::lab1.Properties.Resources.icons8_скопировать_30;
            this.button6.Location = new System.Drawing.Point(297, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 45);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::lab1.Properties.Resources.icons8_направо_30;
            this.button5.Location = new System.Drawing.Point(240, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 45);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::lab1.Properties.Resources.icons8_налево_30;
            this.button4.Location = new System.Drawing.Point(183, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 45);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::lab1.Properties.Resources.icons8_дискета_30;
            this.button3.Location = new System.Drawing.Point(126, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 45);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::lab1.Properties.Resources.icons8_папка_30;
            this.button2.Location = new System.Drawing.Point(69, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 45);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::lab1.Properties.Resources.icons8_плюс_30;
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem editStrip;
        private System.Windows.Forms.ToolStripMenuItem textStrip;
        private System.Windows.Forms.ToolStripMenuItem startStrip;
        private System.Windows.Forms.ToolStripMenuItem infoStrip;
        private System.Windows.Forms.ToolStripTextBox taskDescStrip;
        private System.Windows.Forms.ToolStripTextBox grammarStrip;
        private System.Windows.Forms.ToolStripTextBox gramClassStrip;
        private System.Windows.Forms.ToolStripTextBox infoShowStrip;
        private System.Windows.Forms.ToolStripTextBox aboutStrip;
        private System.Windows.Forms.ToolStripTextBox parsingMethod;
        private System.Windows.Forms.ToolStripTextBox testStrip;
        private System.Windows.Forms.ToolStripTextBox literatStrip;
        private System.Windows.Forms.ToolStripTextBox codeStrip;
        private System.Windows.Forms.ToolStripTextBox undoStrip;
        private System.Windows.Forms.ToolStripTextBox redoStrip;
        private System.Windows.Forms.ToolStripTextBox cutStrip;
        private System.Windows.Forms.ToolStripTextBox copyStrip;
        private System.Windows.Forms.ToolStripTextBox pasteStrip;
        private System.Windows.Forms.ToolStripTextBox deleteStrip;
        private System.Windows.Forms.ToolStripTextBox selectAllStrip;
        private System.Windows.Forms.ToolStripTextBox createFileStrip;
        private System.Windows.Forms.ToolStripTextBox openFileStrip;
        private System.Windows.Forms.ToolStripTextBox saveFileStrip;
        private System.Windows.Forms.ToolStripTextBox saveHowStrip;
        private System.Windows.Forms.ToolStripTextBox exitStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

