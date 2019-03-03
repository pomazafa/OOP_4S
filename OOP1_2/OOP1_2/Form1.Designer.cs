using System.Collections.Generic;
namespace OOP1_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<int> list;
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
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.AscendingButton = new System.Windows.Forms.Button();
            this.DescendingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Query №3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.query3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Query №2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.query2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Query №1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.query1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(153, 150);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(258, 248);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(153, 150);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 86);
            this.button4.TabIndex = 5;
            this.button4.Text = "Generate collection";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Generate_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(200, 16);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 20);
            this.number.TabIndex = 6;
            this.number.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button5
            // 
            this.AscendingButton.Location = new System.Drawing.Point(36, 70);
            this.AscendingButton.Name = "button5";
            this.AscendingButton.Size = new System.Drawing.Size(75, 86);
            this.AscendingButton.TabIndex = 7;
            this.AscendingButton.Text = "Ascending";
            this.AscendingButton.UseVisualStyleBackColor = true;
            this.AscendingButton.Click += new System.EventHandler(this.Sort_Click);
            // 
            // button6
            // 
            this.DescendingButton.Location = new System.Drawing.Point(336, 70);
            this.DescendingButton.Name = "button6";
            this.DescendingButton.Size = new System.Drawing.Size(75, 86);
            this.DescendingButton.TabIndex = 8;
            this.DescendingButton.Text = "Descending";
            this.DescendingButton.UseVisualStyleBackColor = true;
            this.DescendingButton.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 409);
            this.Controls.Add(this.DescendingButton);
            this.Controls.Add(this.AscendingButton);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button AscendingButton;
        private System.Windows.Forms.Button DescendingButton;
    }
}

