namespace Lab14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtonDateTime = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_x2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_y2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_z2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox_a2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_x = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_y = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_z = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox_a = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelClock,
            this.toolStripDropDownButtonDateTime});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 274);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(588, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(540, 17);
            this.toolStripStatusLabelState.Spring = true;
            this.toolStripStatusLabelState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripDropDownButtonDateTime
            // 
            this.toolStripDropDownButtonDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonDateTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTime,
            this.toolStripMenuItemDate});
            this.toolStripDropDownButtonDateTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDateTime.Image")));
            this.toolStripDropDownButtonDateTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonDateTime.Name = "toolStripDropDownButtonDateTime";
            this.toolStripDropDownButtonDateTime.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButtonDateTime.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemTime
            // 
            this.toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            this.toolStripMenuItemTime.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItemTime.Text = "Текущее время";
            this.toolStripMenuItemTime.Click += new System.EventHandler(this.ToolStripMenuItemTime_Click);
            // 
            // toolStripMenuItemDate
            // 
            this.toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            this.toolStripMenuItemDate.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItemDate.Text = "Текущая дата";
            this.toolStripMenuItemDate.Click += new System.EventHandler(this.ToolStripMenuItemDate_Click);
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Enabled = true;
            this.timerDateTimeUpdate.Interval = 1000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.TimerDateTimeUpdate_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox_x,
            this.toolStripTextBox_y,
            this.toolStripTextBox_z,
            this.toolStripComboBox_a});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.toolStripTextBox_x2,
            this.toolStripTextBox_y2,
            this.toolStripTextBox_z2,
            this.toolStripComboBox_a2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 131);
            this.contextMenuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ContextMenuStrip1_MouseMove);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Ввод значений:";
            // 
            // toolStripTextBox_x2
            // 
            this.toolStripTextBox_x2.Name = "toolStripTextBox_x2";
            this.toolStripTextBox_x2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_x2.Text = "0";
            // 
            // toolStripTextBox_y2
            // 
            this.toolStripTextBox_y2.Name = "toolStripTextBox_y2";
            this.toolStripTextBox_y2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_y2.Text = "0";
            // 
            // toolStripTextBox_z2
            // 
            this.toolStripTextBox_z2.Name = "toolStripTextBox_z2";
            this.toolStripTextBox_z2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_z2.Text = "0";
            // 
            // toolStripComboBox_a2
            // 
            this.toolStripComboBox_a2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toolStripComboBox_a2.Name = "toolStripComboBox_a2";
            this.toolStripComboBox_a2.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(111, 23);
            this.toolStripTextBox1.Text = "Ввод значений:";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox_x
            // 
            this.toolStripTextBox_x.Name = "toolStripTextBox_x";
            this.toolStripTextBox_x.Size = new System.Drawing.Size(114, 23);
            this.toolStripTextBox_x.Text = "0";
            this.toolStripTextBox_x.ToolTipText = "x";
            // 
            // toolStripTextBox_y
            // 
            this.toolStripTextBox_y.Name = "toolStripTextBox_y";
            this.toolStripTextBox_y.Size = new System.Drawing.Size(111, 23);
            this.toolStripTextBox_y.Text = "0";
            this.toolStripTextBox_y.ToolTipText = "y";
            // 
            // toolStripTextBox_z
            // 
            this.toolStripTextBox_z.Name = "toolStripTextBox_z";
            this.toolStripTextBox_z.Size = new System.Drawing.Size(111, 23);
            this.toolStripTextBox_z.Text = "0";
            this.toolStripTextBox_z.ToolTipText = "z";
            // 
            // toolStripComboBox_a
            // 
            this.toolStripComboBox_a.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toolStripComboBox_a.Name = "toolStripComboBox_a";
            this.toolStripComboBox_a.Size = new System.Drawing.Size(111, 23);
            this.toolStripComboBox_a.ToolTipText = "a";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.toolStripComboBox1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(120, 23);
            this.toolStripTextBox3.Text = "Выбор выражения:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "выражение 1",
            "выражение 2"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "Ответ (задание 2):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 296);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDateTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDate;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_x;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_y;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_z;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_a;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_x2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_y2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_z2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_a2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

