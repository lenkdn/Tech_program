namespace Lab17
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
            this.components = new System.ComponentModel.Container();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnStopAnimation = new System.Windows.Forms.Button();
            this.btnStartAnimation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.label_2r = new System.Windows.Forms.Label();
            this.label_2u = new System.Windows.Forms.Label();
            this.label_2d = new System.Windows.Forms.Label();
            this.label_2l = new System.Windows.Forms.Label();
            this.label_1d = new System.Windows.Forms.Label();
            this.label_1l = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(519, 13);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(131, 69);
            this.btnChooseColor.TabIndex = 1;
            this.btnChooseColor.Text = "Выбор цвета закрашенной области";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.BtnChooseColor_Click);
            // 
            // btnStopAnimation
            // 
            this.btnStopAnimation.Location = new System.Drawing.Point(519, 457);
            this.btnStopAnimation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopAnimation.Name = "btnStopAnimation";
            this.btnStopAnimation.Size = new System.Drawing.Size(131, 55);
            this.btnStopAnimation.TabIndex = 2;
            this.btnStopAnimation.Text = "Остановить анимацию";
            this.btnStopAnimation.UseVisualStyleBackColor = true;
            this.btnStopAnimation.Click += new System.EventHandler(this.btnStopAnimation_Click);
            // 
            // btnStartAnimation
            // 
            this.btnStartAnimation.Location = new System.Drawing.Point(519, 394);
            this.btnStartAnimation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartAnimation.Name = "btnStartAnimation";
            this.btnStartAnimation.Size = new System.Drawing.Size(131, 55);
            this.btnStartAnimation.TabIndex = 3;
            this.btnStartAnimation.Text = "Запустить анимацию";
            this.btnStartAnimation.UseVisualStyleBackColor = true;
            this.btnStartAnimation.Click += new System.EventHandler(this.btnStartAnimation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(450, 250);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(17, 17);
            this.label_X.TabIndex = 5;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(250, 50);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(17, 17);
            this.label_Y.TabIndex = 6;
            this.label_Y.Text = "Y";
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(245, 236);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(16, 17);
            this.label_0.TabIndex = 7;
            this.label_0.Text = "0";
            // 
            // label_2r
            // 
            this.label_2r.AutoSize = true;
            this.label_2r.Location = new System.Drawing.Point(419, 269);
            this.label_2r.Name = "label_2r";
            this.label_2r.Size = new System.Drawing.Size(16, 17);
            this.label_2r.TabIndex = 8;
            this.label_2r.Text = "2";
            // 
            // label_2u
            // 
            this.label_2u.AutoSize = true;
            this.label_2u.Location = new System.Drawing.Point(245, 119);
            this.label_2u.Name = "label_2u";
            this.label_2u.Size = new System.Drawing.Size(16, 17);
            this.label_2u.TabIndex = 9;
            this.label_2u.Text = "2";
            // 
            // label_2d
            // 
            this.label_2d.AutoSize = true;
            this.label_2d.Location = new System.Drawing.Point(286, 394);
            this.label_2d.Name = "label_2d";
            this.label_2d.Size = new System.Drawing.Size(16, 17);
            this.label_2d.TabIndex = 10;
            this.label_2d.Text = "2";
            // 
            // label_2l
            // 
            this.label_2l.AutoSize = true;
            this.label_2l.Location = new System.Drawing.Point(112, 269);
            this.label_2l.Name = "label_2l";
            this.label_2l.Size = new System.Drawing.Size(16, 17);
            this.label_2l.TabIndex = 11;
            this.label_2l.Text = "2";
            // 
            // label_1d
            // 
            this.label_1d.AutoSize = true;
            this.label_1d.Location = new System.Drawing.Point(286, 328);
            this.label_1d.Name = "label_1d";
            this.label_1d.Size = new System.Drawing.Size(16, 17);
            this.label_1d.TabIndex = 12;
            this.label_1d.Text = "1";
            // 
            // label_1l
            // 
            this.label_1l.AutoSize = true;
            this.label_1l.Location = new System.Drawing.Point(172, 236);
            this.label_1l.Name = "label_1l";
            this.label_1l.Size = new System.Drawing.Size(16, 17);
            this.label_1l.TabIndex = 13;
            this.label_1l.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 522);
            this.Controls.Add(this.label_1l);
            this.Controls.Add(this.label_1d);
            this.Controls.Add(this.label_2l);
            this.Controls.Add(this.label_2d);
            this.Controls.Add(this.label_2u);
            this.Controls.Add(this.label_2r);
            this.Controls.Add(this.label_0);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStartAnimation);
            this.Controls.Add(this.btnStopAnimation);
            this.Controls.Add(this.btnChooseColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnStopAnimation;
        private System.Windows.Forms.Button btnStartAnimation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_0;
        private System.Windows.Forms.Label label_2r;
        private System.Windows.Forms.Label label_2u;
        private System.Windows.Forms.Label label_2d;
        private System.Windows.Forms.Label label_2l;
        private System.Windows.Forms.Label label_1d;
        private System.Windows.Forms.Label label_1l;
        private System.Windows.Forms.Timer timer1;
    }
}

