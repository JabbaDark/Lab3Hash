namespace Hash
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
            this.button2 = new System.Windows.Forms.Button();
            this.HashBox = new System.Windows.Forms.TextBox();
            this.Seed = new System.Windows.Forms.TextBox();
            this.RandNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RandBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать хэш";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Случайная последовательность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HashBox
            // 
            this.HashBox.Location = new System.Drawing.Point(29, 54);
            this.HashBox.Multiline = true;
            this.HashBox.Name = "HashBox";
            this.HashBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HashBox.Size = new System.Drawing.Size(264, 45);
            this.HashBox.TabIndex = 2;
            // 
            // Seed
            // 
            this.Seed.Location = new System.Drawing.Point(335, 69);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(131, 20);
            this.Seed.TabIndex = 3;
            // 
            // RandNum
            // 
            this.RandNum.Location = new System.Drawing.Point(482, 69);
            this.RandNum.Name = "RandNum";
            this.RandNum.Size = new System.Drawing.Size(135, 20);
            this.RandNum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сид";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во чисел";
            // 
            // RandBox
            // 
            this.RandBox.FormattingEnabled = true;
            this.RandBox.Location = new System.Drawing.Point(335, 96);
            this.RandBox.Name = "RandBox";
            this.RandBox.Size = new System.Drawing.Size(282, 121);
            this.RandBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 228);
            this.Controls.Add(this.RandBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandNum);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.HashBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Хэш функция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox HashBox;
        private System.Windows.Forms.TextBox Seed;
        private System.Windows.Forms.TextBox RandNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox RandBox;
    }
}

