namespace Lab15
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
            this.label_ans = new System.Windows.Forms.Label();
            this.textBox_ans = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_n = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ans);
            this.groupBox1.Controls.Add(this.textBox_ans);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_n);
            this.groupBox1.Controls.Add(this.label_n);
            this.groupBox1.Controls.Add(this.textBox_x);
            this.groupBox1.Controls.Add(this.label_x);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(348, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вычисление значения выражения:";
            // 
            // label_ans
            // 
            this.label_ans.AutoSize = true;
            this.label_ans.Location = new System.Drawing.Point(205, 194);
            this.label_ans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ans.Name = "label_ans";
            this.label_ans.Size = new System.Drawing.Size(52, 17);
            this.label_ans.TabIndex = 7;
            this.label_ans.Text = "Ответ:";
            // 
            // textBox_ans
            // 
            this.textBox_ans.Enabled = false;
            this.textBox_ans.Location = new System.Drawing.Point(208, 218);
            this.textBox_ans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ans.Name = "textBox_ans";
            this.textBox_ans.ReadOnly = true;
            this.textBox_ans.Size = new System.Drawing.Size(132, 22);
            this.textBox_ans.TabIndex = 6;
            this.textBox_ans.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кол-во слагаемых";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(49, 118);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(132, 22);
            this.textBox_n.TabIndex = 1;
            this.textBox_n.Text = "0";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(25, 121);
            this.label_n.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(16, 17);
            this.label_n.TabIndex = 2;
            this.label_n.Text = "n";
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(49, 42);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(132, 22);
            this.textBox_x.TabIndex = 0;
            this.textBox_x.Text = "0";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(27, 46);
            this.label_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(14, 17);
            this.label_x.TabIndex = 0;
            this.label_x.Text = "x";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSaveFile);
            this.groupBox2.Controls.Add(this.btnSaveFile);
            this.groupBox2.Controls.Add(this.btnChooseFont);
            this.groupBox2.Controls.Add(this.btnChooseColor);
            this.groupBox2.Location = new System.Drawing.Point(399, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(297, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Файл был сохранён в:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Изменение шрифта всего текста формы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Изменение цвета заднего фона формы";
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(8, 231);
            this.txtSaveFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(280, 22);
            this.txtSaveFile.TabIndex = 5;
            this.txtSaveFile.TabStop = false;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(8, 178);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(136, 28);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "Сохранить файл";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(11, 110);
            this.btnChooseFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(136, 28);
            this.btnChooseFont.TabIndex = 4;
            this.btnChooseFont.Text = "Выбрать шрифт";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.BtnChooseFont_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(8, 37);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(136, 28);
            this.btnChooseColor.TabIndex = 3;
            this.btnChooseColor.Text = "Выбрать цвет";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.BtnChooseColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа 15";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ans;
        private System.Windows.Forms.TextBox textBox_ans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

