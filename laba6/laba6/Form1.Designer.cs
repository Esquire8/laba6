
namespace laba6
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLetter = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelLetter
            // 
            this.labelLetter.AutoSize = true;
            this.labelLetter.Location = new System.Drawing.Point(17, 29);
            this.labelLetter.Name = "labelLetter";
            this.labelLetter.Size = new System.Drawing.Size(0, 17);
            this.labelLetter.TabIndex = 2;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(17, 60);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(0, 17);
            this.labelMonth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите число:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Controls.Add(this.labelLetter);
            this.groupBox1.Controls.Add(this.labelMonth);
            this.groupBox1.Location = new System.Drawing.Point(263, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите год:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(17, 92);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(0, 17);
            this.labelYear.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLetter;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button button2;
    }
}

