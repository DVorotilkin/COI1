namespace Laba1_COI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастноеМаштабированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостнойСрезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспоненциальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.степени23ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гиперболическаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DownConsole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.процедурыToolStripMenuItem,
            this.алгоритмыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзображениеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьИзображениеToolStripMenuItem
            // 
            this.загрузитьИзображениеToolStripMenuItem.Name = "загрузитьИзображениеToolStripMenuItem";
            this.загрузитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.загрузитьИзображениеToolStripMenuItem.Text = "Загрузить изображение";
            this.загрузитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзображениеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // процедурыToolStripMenuItem
            // 
            this.процедурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрастноеМаштабированиеToolStripMenuItem,
            this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem,
            this.яркостнойСрезToolStripMenuItem});
            this.процедурыToolStripMenuItem.Enabled = false;
            this.процедурыToolStripMenuItem.Name = "процедурыToolStripMenuItem";
            this.процедурыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.процедурыToolStripMenuItem.Text = "Процедуры";
            // 
            // контрастноеМаштабированиеToolStripMenuItem
            // 
            this.контрастноеМаштабированиеToolStripMenuItem.Name = "контрастноеМаштабированиеToolStripMenuItem";
            this.контрастноеМаштабированиеToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.контрастноеМаштабированиеToolStripMenuItem.Text = "Контрастное масштабирование";
            this.контрастноеМаштабированиеToolStripMenuItem.Click += new System.EventHandler(this.контрастноеМаштабированиеToolStripMenuItem_Click);
            // 
            // инвертированноеКонтрастноеМасштабированиеToolStripMenuItem
            // 
            this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem.Name = "инвертированноеКонтрастноеМасштабированиеToolStripMenuItem";
            this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem.Text = "Инвертированное контрастное масштабирование";
            this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem.Click += new System.EventHandler(this.инвертированноеКонтрастноеМасштабированиеToolStripMenuItem_Click);
            // 
            // яркостнойСрезToolStripMenuItem
            // 
            this.яркостнойСрезToolStripMenuItem.Name = "яркостнойСрезToolStripMenuItem";
            this.яркостнойСрезToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.яркостнойСрезToolStripMenuItem.Text = "Яркостной срез";
            this.яркостнойСрезToolStripMenuItem.Click += new System.EventHandler(this.яркостнойСрезToolStripMenuItem_Click);
            // 
            // алгоритмыToolStripMenuItem
            // 
            this.алгоритмыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспоненциальнаяToolStripMenuItem,
            this.степени23ToolStripMenuItem,
            this.гиперболическаяToolStripMenuItem});
            this.алгоритмыToolStripMenuItem.Enabled = false;
            this.алгоритмыToolStripMenuItem.Name = "алгоритмыToolStripMenuItem";
            this.алгоритмыToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.алгоритмыToolStripMenuItem.Text = "Гистограмма";
            // 
            // экспоненциальнаяToolStripMenuItem
            // 
            this.экспоненциальнаяToolStripMenuItem.Name = "экспоненциальнаяToolStripMenuItem";
            this.экспоненциальнаяToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.экспоненциальнаяToolStripMenuItem.Text = "Экспоненциальная";
            this.экспоненциальнаяToolStripMenuItem.Click += new System.EventHandler(this.экспоненциальнаяToolStripMenuItem_Click);
            // 
            // степени23ToolStripMenuItem
            // 
            this.степени23ToolStripMenuItem.Name = "степени23ToolStripMenuItem";
            this.степени23ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.степени23ToolStripMenuItem.Text = "Степени 2/3";
            this.степени23ToolStripMenuItem.Click += new System.EventHandler(this.степени23ToolStripMenuItem_Click);
            // 
            // гиперболическаяToolStripMenuItem
            // 
            this.гиперболическаяToolStripMenuItem.Name = "гиперболическаяToolStripMenuItem";
            this.гиперболическаяToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.гиперболическаяToolStripMenuItem.Text = "Гиперболическая";
            this.гиперболическаяToolStripMenuItem.Click += new System.EventHandler(this.гиперболическаяToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG-файлы|*.jpg|PNG-файлы|*.png";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(9, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(526, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // DownConsole
            // 
            this.DownConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownConsole.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DownConsole.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DownConsole.Location = new System.Drawing.Point(0, 559);
            this.DownConsole.Name = "DownConsole";
            this.DownConsole.ReadOnly = true;
            this.DownConsole.Size = new System.Drawing.Size(1032, 20);
            this.DownConsole.TabIndex = 3;
            this.DownConsole.TabStop = false;
            this.DownConsole.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1028, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownConsole);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цифровая обработка изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастноеМаштабированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инвертированноеКонтрастноеМасштабированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостнойСрезToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox DownConsole;
        private System.Windows.Forms.ToolStripMenuItem экспоненциальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem степени23ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гиперболическаяToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

