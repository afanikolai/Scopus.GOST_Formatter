namespace Курсовая_проект
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
            this.tb_main = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяВыполненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неТестироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_dotDash = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_dot = new System.Windows.Forms.RadioButton();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_main.Location = new System.Drawing.Point(12, 31);
            this.tb_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_main.Multiline = true;
            this.tb_main.Name = "tb_main";
            this.tb_main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_main.Size = new System.Drawing.Size(759, 356);
            this.tb_main.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.времяВыполненияToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // времяВыполненияToolStripMenuItem
            // 
            this.времяВыполненияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестироватьToolStripMenuItem,
            this.неТестироватьToolStripMenuItem});
            this.времяВыполненияToolStripMenuItem.Name = "времяВыполненияToolStripMenuItem";
            this.времяВыполненияToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.времяВыполненияToolStripMenuItem.Text = "Время выполнения";
            // 
            // тестироватьToolStripMenuItem
            // 
            this.тестироватьToolStripMenuItem.Name = "тестироватьToolStripMenuItem";
            this.тестироватьToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.тестироватьToolStripMenuItem.Text = "Тестировать";
            this.тестироватьToolStripMenuItem.Click += new System.EventHandler(this.тестироватьToolStripMenuItem_Click);
            // 
            // неТестироватьToolStripMenuItem
            // 
            this.неТестироватьToolStripMenuItem.Name = "неТестироватьToolStripMenuItem";
            this.неТестироватьToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.неТестироватьToolStripMenuItem.Text = "Не тестировать";
            this.неТестироватьToolStripMenuItem.Click += new System.EventHandler(this.неТестироватьToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rb_dotDash);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rb_dot);
            this.panel1.Location = new System.Drawing.Point(12, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 53);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "файл нужно открыть звново";
            // 
            // rb_dotDash
            // 
            this.rb_dotDash.AutoSize = true;
            this.rb_dotDash.Location = new System.Drawing.Point(168, 14);
            this.rb_dotDash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_dotDash.Name = "rb_dotDash";
            this.rb_dotDash.Size = new System.Drawing.Size(144, 21);
            this.rb_dotDash.TabIndex = 1;
            this.rb_dotDash.Text = "Использовать \".-\"";
            this.rb_dotDash.UseVisualStyleBackColor = true;
            this.rb_dotDash.CheckedChanged += new System.EventHandler(this.rb_dotDash_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Для применения изменений ";
            // 
            // rb_dot
            // 
            this.rb_dot.AutoSize = true;
            this.rb_dot.Checked = true;
            this.rb_dot.Location = new System.Drawing.Point(13, 14);
            this.rb_dot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_dot.Name = "rb_dot";
            this.rb_dot.Size = new System.Drawing.Size(139, 21);
            this.rb_dot.TabIndex = 0;
            this.rb_dot.TabStop = true;
            this.rb_dot.Text = "Использовать \".\"";
            this.rb_dot.UseVisualStyleBackColor = true;
            this.rb_dot.CheckedChanged += new System.EventHandler(this.rb_dot_CheckedChanged);
            // 
            // pb1
            // 
            this.pb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb1.Location = new System.Drawing.Point(12, 459);
            this.pb1.Margin = new System.Windows.Forms.Padding(4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(760, 28);
            this.pb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 502);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(799, 549);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Scopus.BibTeX.GOST Formatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_dotDash;
        private System.Windows.Forms.RadioButton rb_dot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяВыполненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неТестироватьToolStripMenuItem;
    }
}

