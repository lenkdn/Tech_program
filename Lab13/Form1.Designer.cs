namespace Lab13
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_f = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_j = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.label_i = new System.Windows.Forms.Label();
            this.comboBox_j = new System.Windows.Forms.ComboBox();
            this.listBox_a = new System.Windows.Forms.ListBox();
            this.comboBox_i = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(564, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(165, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор уравнения";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 68);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Уравнение 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 39);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Уравнение 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(47, 32);
            this.textBox_f.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(132, 22);
            this.textBox_f.TabIndex = 0;
            this.textBox_f.Text = "0";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(47, 64);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(132, 22);
            this.textBox_X.TabIndex = 1;
            this.textBox_X.Text = "0";
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Location = new System.Drawing.Point(25, 34);
            this.label_f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(12, 17);
            this.label_f.TabIndex = 3;
            this.label_f.Text = "f";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(20, 68);
            this.label_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(17, 17);
            this.label_X.TabIndex = 4;
            this.label_X.Text = "X";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(537, 272);
            this.label_Z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(17, 17);
            this.label_Z.TabIndex = 7;
            this.label_Z.Text = "Z";
            // 
            // textBox_Z
            // 
            this.textBox_Z.Location = new System.Drawing.Point(564, 268);
            this.textBox_Z.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.ReadOnly = true;
            this.textBox_Z.Size = new System.Drawing.Size(132, 22);
            this.textBox_Z.TabIndex = 9;
            this.textBox_Z.Text = "0";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Location = new System.Drawing.Point(20, 166);
            this.label_N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(18, 17);
            this.label_N.TabIndex = 9;
            this.label_N.Text = "N";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(47, 162);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(132, 22);
            this.textBox_N.TabIndex = 2;
            this.textBox_N.Text = "0";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(561, 247);
            this.label_answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(52, 17);
            this.label_answer.TabIndex = 10;
            this.label_answer.Text = "Ответ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_f);
            this.groupBox2.Controls.Add(this.textBox_X);
            this.groupBox2.Controls.Add(this.label_N);
            this.groupBox2.Controls.Add(this.label_f);
            this.groupBox2.Controls.Add(this.textBox_N);
            this.groupBox2.Controls.Add(this.label_X);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 194);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод значений";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Кол-во слагаемых в 1-м уравнении:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_j);
            this.groupBox3.Controls.Add(this.label_a);
            this.groupBox3.Controls.Add(this.label_i);
            this.groupBox3.Controls.Add(this.comboBox_j);
            this.groupBox3.Controls.Add(this.listBox_a);
            this.groupBox3.Controls.Add(this.comboBox_i);
            this.groupBox3.Location = new System.Drawing.Point(292, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(264, 193);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор значений";
            // 
            // label_j
            // 
            this.label_j.AutoSize = true;
            this.label_j.Location = new System.Drawing.Point(27, 65);
            this.label_j.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_j.Name = "label_j";
            this.label_j.Size = new System.Drawing.Size(11, 17);
            this.label_j.TabIndex = 5;
            this.label_j.Text = "j";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(23, 96);
            this.label_a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(16, 17);
            this.label_a.TabIndex = 3;
            this.label_a.Text = "a";
            // 
            // label_i
            // 
            this.label_i.AutoSize = true;
            this.label_i.Location = new System.Drawing.Point(28, 32);
            this.label_i.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_i.Name = "label_i";
            this.label_i.Size = new System.Drawing.Size(11, 17);
            this.label_i.TabIndex = 2;
            this.label_i.Text = "i";
            // 
            // comboBox_j
            // 
            this.comboBox_j.FormattingEnabled = true;
            this.comboBox_j.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_j.Location = new System.Drawing.Point(48, 63);
            this.comboBox_j.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_j.Name = "comboBox_j";
            this.comboBox_j.Size = new System.Drawing.Size(160, 24);
            this.comboBox_j.TabIndex = 4;
            // 
            // listBox_a
            // 
            this.listBox_a.FormattingEnabled = true;
            this.listBox_a.ItemHeight = 16;
            this.listBox_a.Items.AddRange(new object[] {
            "-10",
            "-5",
            "0",
            "5",
            "10"});
            this.listBox_a.Location = new System.Drawing.Point(48, 96);
            this.listBox_a.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_a.Name = "listBox_a";
            this.listBox_a.Size = new System.Drawing.Size(159, 84);
            this.listBox_a.TabIndex = 5;
            // 
            // comboBox_i
            // 
            this.comboBox_i.FormattingEnabled = true;
            this.comboBox_i.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox_i.Location = new System.Drawing.Point(48, 28);
            this.comboBox_i.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_i.Name = "comboBox_i";
            this.comboBox_i.Size = new System.Drawing.Size(160, 24);
            this.comboBox_i.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 332);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Решение уравнений";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label_f;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_j;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_i;
        private System.Windows.Forms.ComboBox comboBox_j;
        private System.Windows.Forms.ListBox listBox_a;
        private System.Windows.Forms.ComboBox comboBox_i;
    }
}

