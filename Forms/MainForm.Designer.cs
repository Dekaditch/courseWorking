namespace lab1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.textStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.startStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.infoStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createToolStrip = new System.Windows.Forms.ToolStripButton();
            this.browseToolStrip = new System.Windows.Forms.ToolStripButton();
            this.saveToolStrip = new System.Windows.Forms.ToolStripButton();
            this.undoToolStrip = new System.Windows.Forms.ToolStripButton();
            this.redoToolStrip = new System.Windows.Forms.ToolStripButton();
            this.copyToolStrip = new System.Windows.Forms.ToolStripButton();
            this.cutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.runToolStrip = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.infoToolStrip = new System.Windows.Forms.ToolStripButton();
            this.createFileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHowStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.undoStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.redoStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.copyStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.taskDescStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.grammarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gramClassStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.parsingMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.testStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.literatStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.codeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.infoShowStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textStrip.Size = new System.Drawing.Size(49, 20);
            this.textStrip.Text = "Текст";
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
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStrip,
            this.browseToolStrip,
            this.saveToolStrip,
            this.toolStripSeparator1,
            this.undoToolStrip,
            this.redoToolStrip,
            this.toolStripSeparator2,
            this.copyToolStrip,
            this.cutToolStrip,
            this.pasteToolStrip,
            this.toolStripSeparator4,
            this.runToolStrip,
            this.toolStripSeparator3,
            this.aboutToolStrip,
            this.infoToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createToolStrip
            // 
            this.createToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createToolStrip.Image = global::lab1.Properties.Resources.icons8_плюс_30;
            this.createToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createToolStrip.Name = "createToolStrip";
            this.createToolStrip.Size = new System.Drawing.Size(23, 22);
            this.createToolStrip.Text = "toolStripButton1";
            // 
            // browseToolStrip
            // 
            this.browseToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.browseToolStrip.Image = global::lab1.Properties.Resources.icons8_папка_30;
            this.browseToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseToolStrip.Name = "browseToolStrip";
            this.browseToolStrip.Size = new System.Drawing.Size(23, 22);
            this.browseToolStrip.Text = "browseToolStrip";
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStrip.Image = global::lab1.Properties.Resources.icons8_дискета_30;
            this.saveToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(23, 22);
            this.saveToolStrip.Text = "saveToolStrip";
            // 
            // undoToolStrip
            // 
            this.undoToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStrip.Image = global::lab1.Properties.Resources.icons8_налево_30;
            this.undoToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStrip.Name = "undoToolStrip";
            this.undoToolStrip.Size = new System.Drawing.Size(23, 22);
            this.undoToolStrip.Text = "toolStripButton4";
            this.undoToolStrip.ToolTipText = "undoToolStrip";
            // 
            // redoToolStrip
            // 
            this.redoToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolStrip.Image = global::lab1.Properties.Resources.icons8_направо_30;
            this.redoToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStrip.Name = "redoToolStrip";
            this.redoToolStrip.Size = new System.Drawing.Size(23, 22);
            this.redoToolStrip.Text = "toolStripButton5";
            // 
            // copyToolStrip
            // 
            this.copyToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStrip.Image = global::lab1.Properties.Resources.icons8_скопировать_30;
            this.copyToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStrip.Name = "copyToolStrip";
            this.copyToolStrip.Size = new System.Drawing.Size(23, 22);
            this.copyToolStrip.Text = "toolStripButton6";
            // 
            // cutToolStrip
            // 
            this.cutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStrip.Image = global::lab1.Properties.Resources.icons8_вырезать_30;
            this.cutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStrip.Name = "cutToolStrip";
            this.cutToolStrip.Size = new System.Drawing.Size(23, 22);
            this.cutToolStrip.Text = "toolStripButton7";
            // 
            // pasteToolStrip
            // 
            this.pasteToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStrip.Image = global::lab1.Properties.Resources.icons8_вставить_30;
            this.pasteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStrip.Name = "pasteToolStrip";
            this.pasteToolStrip.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStrip.Text = "toolStripButton8";
            // 
            // runToolStrip
            // 
            this.runToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runToolStrip.Image = global::lab1.Properties.Resources.icons8_начало_30;
            this.runToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runToolStrip.Name = "runToolStrip";
            this.runToolStrip.Size = new System.Drawing.Size(23, 22);
            this.runToolStrip.Text = "toolStripButton9";
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStrip.Image = global::lab1.Properties.Resources.icons8_вопрос_30;
            this.aboutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(23, 22);
            this.aboutToolStrip.Text = "toolStripButton10";
            // 
            // infoToolStrip
            // 
            this.infoToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoToolStrip.Image = global::lab1.Properties.Resources.icons8_информация_30;
            this.infoToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoToolStrip.Name = "infoToolStrip";
            this.infoToolStrip.Size = new System.Drawing.Size(23, 22);
            this.infoToolStrip.Text = "toolStripButton11";
            // 
            // createFileStrip
            // 
            this.createFileStrip.Name = "createFileStrip";
            this.createFileStrip.Size = new System.Drawing.Size(180, 22);
            this.createFileStrip.Text = "Создать";
            // 
            // openFileStrip
            // 
            this.openFileStrip.Name = "openFileStrip";
            this.openFileStrip.Size = new System.Drawing.Size(180, 22);
            this.openFileStrip.Text = "Открыть";
            // 
            // saveFileStrip
            // 
            this.saveFileStrip.Name = "saveFileStrip";
            this.saveFileStrip.Size = new System.Drawing.Size(180, 22);
            this.saveFileStrip.Text = "Сохранить";
            // 
            // saveHowStrip
            // 
            this.saveHowStrip.Name = "saveHowStrip";
            this.saveHowStrip.Size = new System.Drawing.Size(180, 22);
            this.saveHowStrip.Text = "Сохранить как";
            // 
            // exitStrip
            // 
            this.exitStrip.Name = "exitStrip";
            this.exitStrip.Size = new System.Drawing.Size(180, 22);
            this.exitStrip.Text = "Выход";
            // 
            // undoStrip
            // 
            this.undoStrip.Name = "undoStrip";
            this.undoStrip.Size = new System.Drawing.Size(180, 22);
            this.undoStrip.Text = "Отменить";
            // 
            // redoStrip
            // 
            this.redoStrip.Name = "redoStrip";
            this.redoStrip.Size = new System.Drawing.Size(180, 22);
            this.redoStrip.Text = "Повторить";
            // 
            // cutStrip
            // 
            this.cutStrip.Name = "cutStrip";
            this.cutStrip.Size = new System.Drawing.Size(180, 22);
            this.cutStrip.Text = "Вырезать";
            // 
            // copyStrip
            // 
            this.copyStrip.Name = "copyStrip";
            this.copyStrip.Size = new System.Drawing.Size(180, 22);
            this.copyStrip.Text = "Копировать";
            // 
            // pasteStrip
            // 
            this.pasteStrip.Name = "pasteStrip";
            this.pasteStrip.Size = new System.Drawing.Size(180, 22);
            this.pasteStrip.Text = "Вставить";
            // 
            // deleteStrip
            // 
            this.deleteStrip.Name = "deleteStrip";
            this.deleteStrip.Size = new System.Drawing.Size(180, 22);
            this.deleteStrip.Text = "Удалить";
            // 
            // selectAllStrip
            // 
            this.selectAllStrip.Name = "selectAllStrip";
            this.selectAllStrip.Size = new System.Drawing.Size(180, 22);
            this.selectAllStrip.Text = "Выделить все";
            // 
            // taskDescStrip
            // 
            this.taskDescStrip.Name = "taskDescStrip";
            this.taskDescStrip.Size = new System.Drawing.Size(222, 22);
            this.taskDescStrip.Text = "Постановка задачи";
            // 
            // grammarStrip
            // 
            this.grammarStrip.Name = "grammarStrip";
            this.grammarStrip.Size = new System.Drawing.Size(222, 22);
            this.grammarStrip.Text = "Грамматика";
            // 
            // gramClassStrip
            // 
            this.gramClassStrip.Name = "gramClassStrip";
            this.gramClassStrip.Size = new System.Drawing.Size(222, 22);
            this.gramClassStrip.Text = "Классификация граматики";
            // 
            // parsingMethod
            // 
            this.parsingMethod.Name = "parsingMethod";
            this.parsingMethod.Size = new System.Drawing.Size(222, 22);
            this.parsingMethod.Text = "Метод анализа";
            // 
            // testStrip
            // 
            this.testStrip.Name = "testStrip";
            this.testStrip.Size = new System.Drawing.Size(222, 22);
            this.testStrip.Text = "Тестовый пример";
            // 
            // literatStrip
            // 
            this.literatStrip.Name = "literatStrip";
            this.literatStrip.Size = new System.Drawing.Size(222, 22);
            this.literatStrip.Text = "Список литературы";
            // 
            // codeStrip
            // 
            this.codeStrip.Name = "codeStrip";
            this.codeStrip.Size = new System.Drawing.Size(222, 22);
            this.codeStrip.Text = "Исходный код программы";
            // 
            // infoShowStrip
            // 
            this.infoShowStrip.Name = "infoShowStrip";
            this.infoShowStrip.Size = new System.Drawing.Size(180, 22);
            this.infoShowStrip.Text = "Вызов справки";
            // 
            // aboutStrip
            // 
            this.aboutStrip.Name = "aboutStrip";
            this.aboutStrip.Size = new System.Drawing.Size(180, 22);
            this.aboutStrip.Text = "О программе";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 154);
            this.dataGridView1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "lab1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // 
            // Добавление обработчиков событий для меню "Файл"
            // 
            this.createFileStrip.Click += new System.EventHandler(this.createFileStrip_Click);
            this.openFileStrip.Click += new System.EventHandler(this.openFileStrip_Click);
            this.saveFileStrip.Click += new System.EventHandler(this.saveFileStrip_Click);
            this.saveHowStrip.Click += new System.EventHandler(this.saveHowStrip_Click);
            this.exitStrip.Click += new System.EventHandler(this.exitStrip_Click);

            // 
            // Добавление обработчиков событий для меню "Правка"
            // 
            this.undoStrip.Click += new System.EventHandler(this.undoStrip_Click);
            this.redoStrip.Click += new System.EventHandler(this.redoStrip_Click);
            this.cutStrip.Click += new System.EventHandler(this.cutStrip_Click);
            this.copyStrip.Click += new System.EventHandler(this.copyStrip_Click);
            this.pasteStrip.Click += new System.EventHandler(this.pasteStrip_Click);
            this.deleteStrip.Click += new System.EventHandler(this.deleteStrip_Click);
            this.selectAllStrip.Click += new System.EventHandler(this.selectAllStrip_Click);

            // 
            // Добавление обработчиков событий для меню "Текст"
            // 
            this.taskDescStrip.Click += new System.EventHandler(this.taskDescStrip_Click);
            this.grammarStrip.Click += new System.EventHandler(this.grammarStrip_Click);
            this.gramClassStrip.Click += new System.EventHandler(this.gramClassStrip_Click);
            this.parsingMethod.Click += new System.EventHandler(this.parsingMethod_Click);
            this.testStrip.Click += new System.EventHandler(this.testStrip_Click);
            this.literatStrip.Click += new System.EventHandler(this.literatStrip_Click);
            this.codeStrip.Click += new System.EventHandler(this.codeStrip_Click);

            // 
            // Добавление обработчиков событий для меню "Пуск"
            // 
            this.startStrip.Click += new System.EventHandler(this.startStrip_Click);

            // 
            // Добавление обработчиков событий для меню "Справка"
            // 
            this.infoShowStrip.Click += new System.EventHandler(this.infoShowStrip_Click);
            this.aboutStrip.Click += new System.EventHandler(this.aboutStrip_Click);

            // 
            // Добавление обработчиков событий для панели инструментов
            // 
            this.createToolStrip.Click += new System.EventHandler(this.createToolStrip_Click);
            this.browseToolStrip.Click += new System.EventHandler(this.browseToolStrip_Click);
            this.saveToolStrip.Click += new System.EventHandler(this.saveToolStrip_Click);
            this.undoToolStrip.Click += new System.EventHandler(this.undoToolStrip_Click);
            this.redoToolStrip.Click += new System.EventHandler(this.redoToolStrip_Click);
            this.copyToolStrip.Click += new System.EventHandler(this.copyToolStrip_Click);
            this.cutToolStrip.Click += new System.EventHandler(this.cutToolStrip_Click);
            this.pasteToolStrip.Click += new System.EventHandler(this.pasteToolStrip_Click);
            this.runToolStrip.Click += new System.EventHandler(this.runToolStrip_Click);
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStrip_Click);
            this.infoToolStrip.Click += new System.EventHandler(this.infoToolStrip_Click);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem editStrip;
        private System.Windows.Forms.ToolStripMenuItem textStrip;
        private System.Windows.Forms.ToolStripMenuItem startStrip;
        private System.Windows.Forms.ToolStripMenuItem infoStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createToolStrip;
        private System.Windows.Forms.ToolStripButton browseToolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStrip;
        private System.Windows.Forms.ToolStripButton undoToolStrip;
        private System.Windows.Forms.ToolStripButton redoToolStrip;
        private System.Windows.Forms.ToolStripButton copyToolStrip;
        private System.Windows.Forms.ToolStripButton cutToolStrip;
        private System.Windows.Forms.ToolStripButton pasteToolStrip;
        private System.Windows.Forms.ToolStripButton runToolStrip;
        private System.Windows.Forms.ToolStripButton aboutToolStrip;
        private System.Windows.Forms.ToolStripButton infoToolStrip;
        private System.Windows.Forms.ToolStripMenuItem createFileStrip;
        private System.Windows.Forms.ToolStripMenuItem openFileStrip;
        private System.Windows.Forms.ToolStripMenuItem saveFileStrip;
        private System.Windows.Forms.ToolStripMenuItem saveHowStrip;
        private System.Windows.Forms.ToolStripMenuItem exitStrip;
        private System.Windows.Forms.ToolStripMenuItem undoStrip;
        private System.Windows.Forms.ToolStripMenuItem redoStrip;
        private System.Windows.Forms.ToolStripMenuItem cutStrip;
        private System.Windows.Forms.ToolStripMenuItem copyStrip;
        private System.Windows.Forms.ToolStripMenuItem pasteStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllStrip;
        private System.Windows.Forms.ToolStripMenuItem taskDescStrip;
        private System.Windows.Forms.ToolStripMenuItem grammarStrip;
        private System.Windows.Forms.ToolStripMenuItem gramClassStrip;
        private System.Windows.Forms.ToolStripMenuItem parsingMethod;
        private System.Windows.Forms.ToolStripMenuItem testStrip;
        private System.Windows.Forms.ToolStripMenuItem literatStrip;
        private System.Windows.Forms.ToolStripMenuItem codeStrip;
        private System.Windows.Forms.ToolStripMenuItem infoShowStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}