namespace zd3_voroshilov_a
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            button5 = new Button();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            button2 = new Button();
            textBox4 = new TextBox();
            checkBox2 = new CheckBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            numericUpDown4 = new NumericUpDown();
            textBox6 = new TextBox();
            label10 = new Label();
            listBox2 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(933, 519);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(925, 491);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Базовые операторы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(13, 342);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(204, 27);
            button4.TabIndex = 15;
            button4.Text = "Удалить выбранное";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DeleteByOpIndex;
            // 
            // button3
            // 
            button3.Location = new Point(13, 308);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(204, 27);
            button3.TabIndex = 14;
            button3.Text = "Удалить по названию";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteByOpName;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Enabled = false;
            panel1.Location = new Point(6, 128);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 140);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 7;
            label3.Text = "Введите площадь покрытия";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(7, 108);
            numericUpDown2.Margin = new Padding(4, 3, 4, 3);
            numericUpDown2.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(204, 23);
            numericUpDown2.TabIndex = 12;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // textBox3
            // 
            textBox3.Location = new Point(7, 18);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 90);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 11;
            label5.Text = "Введите скорость интернета";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 9;
            label4.Text = "Введите цену за роуминг";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(7, 63);
            numericUpDown1.Margin = new Padding(4, 3, 4, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(204, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(13, 275);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(204, 27);
            button1.TabIndex = 6;
            button1.Text = "Добавить оператора";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddOperator;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 102);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(187, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Ввести более точные данные";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckAddFullInfo;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 70);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите стоимость минуты";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 25);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите название";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(225, 7);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(689, 469);
            listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(numericUpDown4);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(925, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Продвинутые операторы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(13, 309);
            button5.Name = "button5";
            button5.Size = new Size(204, 23);
            button5.TabIndex = 21;
            button5.Text = "Удалить по индексу";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DeleteByBuffIndex;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 15);
            label6.TabIndex = 7;
            label6.Text = "Введите площадь покрытия";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(13, 233);
            numericUpDown3.Margin = new Padding(4, 3, 4, 3);
            numericUpDown3.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(204, 23);
            numericUpDown3.TabIndex = 12;
            numericUpDown3.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(13, 276);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(204, 27);
            button2.TabIndex = 20;
            button2.Text = "Добавить оператора";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddBuffOperator;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 143);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 23);
            textBox4.TabIndex = 8;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(13, 102);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(184, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Плата за каждое соединение";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 215);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 15);
            label7.TabIndex = 11;
            label7.Text = "Введите скорость интернета";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(13, 70);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 23);
            textBox5.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 170);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 15);
            label8.TabIndex = 9;
            label8.Text = "Введите цену за роуминг";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 52);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(157, 15);
            label9.TabIndex = 17;
            label9.Text = "Введите стоимость минуты";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(13, 188);
            numericUpDown4.Margin = new Padding(4, 3, 4, 3);
            numericUpDown4.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(204, 23);
            numericUpDown4.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(13, 25);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(204, 23);
            textBox6.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 7);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 15);
            label10.TabIndex = 15;
            label10.Text = "Введите название";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(225, 7);
            listBox2.Margin = new Padding(4, 3, 4, 3);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(689, 469);
            listBox2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Button button5;
    }
}
