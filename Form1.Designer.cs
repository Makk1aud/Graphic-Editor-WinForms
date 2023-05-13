namespace Graphic_Editor
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
            this.mainPctBox = new System.Windows.Forms.PictureBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.blackWhiteBtn = new System.Windows.Forms.Button();
            this.penSizeTrBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.penSixeTxb = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPctBox
            // 
            this.mainPctBox.Location = new System.Drawing.Point(24, 25);
            this.mainPctBox.Name = "mainPctBox";
            this.mainPctBox.Size = new System.Drawing.Size(356, 358);
            this.mainPctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPctBox.TabIndex = 0;
            this.mainPctBox.TabStop = false;
            this.mainPctBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPctBox_MouseDown);
            this.mainPctBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPctBox_MouseMove);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(24, 389);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(110, 41);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Открыть";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(270, 389);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 41);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // blackWhiteBtn
            // 
            this.blackWhiteBtn.Location = new System.Drawing.Point(395, 234);
            this.blackWhiteBtn.Name = "blackWhiteBtn";
            this.blackWhiteBtn.Size = new System.Drawing.Size(88, 36);
            this.blackWhiteBtn.TabIndex = 1;
            this.blackWhiteBtn.Text = "Черно-белый";
            this.blackWhiteBtn.UseVisualStyleBackColor = true;
            this.blackWhiteBtn.Click += new System.EventHandler(this.blackWhite_Click);
            // 
            // penSizeTrBar
            // 
            this.penSizeTrBar.Location = new System.Drawing.Point(386, 52);
            this.penSizeTrBar.Maximum = 6;
            this.penSizeTrBar.Minimum = 1;
            this.penSizeTrBar.Name = "penSizeTrBar";
            this.penSizeTrBar.Size = new System.Drawing.Size(194, 45);
            this.penSizeTrBar.TabIndex = 2;
            this.penSizeTrBar.Value = 1;
            this.penSizeTrBar.Scroll += new System.EventHandler(this.penSizeTrBar_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(395, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 22);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ChangepPenColor);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(489, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 22);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ChangepPenColor);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(395, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 22);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ChangepPenColor);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(489, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 22);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ChangepPenColor);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(395, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 22);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ChangepPenColor);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(489, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 22);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ChangepPenColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(392, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Толщина кисти";
            // 
            // penSixeTxb
            // 
            this.penSixeTxb.BackColor = System.Drawing.Color.White;
            this.penSixeTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penSixeTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.penSixeTxb.Location = new System.Drawing.Point(511, 22);
            this.penSixeTxb.Multiline = true;
            this.penSixeTxb.Name = "penSixeTxb";
            this.penSixeTxb.Size = new System.Drawing.Size(41, 28);
            this.penSixeTxb.TabIndex = 5;
            this.penSixeTxb.Text = "1";
            this.penSixeTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.penSixeTxb.TextChanged += new System.EventHandler(this.penSixeTxb_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(149, 389);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(110, 41);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 442);
            this.Controls.Add(this.penSixeTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.penSizeTrBar);
            this.Controls.Add(this.blackWhiteBtn);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.mainPctBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPctBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button blackWhiteBtn;
        private System.Windows.Forms.TrackBar penSizeTrBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox penSixeTxb;
        private System.Windows.Forms.Button buttonClear;
    }
}

