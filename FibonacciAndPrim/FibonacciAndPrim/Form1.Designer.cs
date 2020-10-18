namespace FibonacciAndPrim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FibTrue = new System.Windows.Forms.CheckBox();
            this.FibFalse = new System.Windows.Forms.CheckBox();
            this.PrimFalse = new System.Windows.Forms.CheckBox();
            this.PrimTrue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(830, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fibonacci";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prim";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(56, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(830, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Controleaza numarul!\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FibTrue
            // 
            this.FibTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FibTrue.Location = new System.Drawing.Point(500, 207);
            this.FibTrue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FibTrue.Name = "FibTrue";
            this.FibTrue.Size = new System.Drawing.Size(139, 69);
            this.FibTrue.TabIndex = 8;
            this.FibTrue.Text = "True";
            this.FibTrue.UseVisualStyleBackColor = true;
            // 
            // FibFalse
            // 
            this.FibFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FibFalse.Location = new System.Drawing.Point(646, 208);
            this.FibFalse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FibFalse.Name = "FibFalse";
            this.FibFalse.Size = new System.Drawing.Size(139, 69);
            this.FibFalse.TabIndex = 9;
            this.FibFalse.Text = "False";
            this.FibFalse.UseVisualStyleBackColor = true;
            // 
            // PrimFalse
            // 
            this.PrimFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimFalse.Location = new System.Drawing.Point(646, 308);
            this.PrimFalse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PrimFalse.Name = "PrimFalse";
            this.PrimFalse.Size = new System.Drawing.Size(139, 69);
            this.PrimFalse.TabIndex = 11;
            this.PrimFalse.Text = "False";
            this.PrimFalse.UseVisualStyleBackColor = true;
            // 
            // PrimTrue
            // 
            this.PrimTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimTrue.Location = new System.Drawing.Point(500, 303);
            this.PrimTrue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PrimTrue.Name = "PrimTrue";
            this.PrimTrue.Size = new System.Drawing.Size(139, 69);
            this.PrimTrue.TabIndex = 10;
            this.PrimTrue.Text = "True";
            this.PrimTrue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.PrimFalse);
            this.Controls.Add(this.PrimTrue);
            this.Controls.Add(this.FibFalse);
            this.Controls.Add(this.FibTrue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox FibFalse;
        private System.Windows.Forms.CheckBox FibTrue;
        private System.Windows.Forms.CheckBox PrimFalse;
        private System.Windows.Forms.CheckBox PrimTrue;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}