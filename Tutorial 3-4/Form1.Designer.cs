namespace Tutorial_3_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Test1Box = new System.Windows.Forms.TextBox();
            this.Test2Box = new System.Windows.Forms.TextBox();
            this.Test3Box = new System.Windows.Forms.TextBox();
            this.AvgTestBox = new System.Windows.Forms.TextBox();
            this.AverageButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AVG Test Scores";
            // 
            // Test1Box
            // 
            this.Test1Box.Location = new System.Drawing.Point(213, 40);
            this.Test1Box.Name = "Test1Box";
            this.Test1Box.Size = new System.Drawing.Size(100, 20);
            this.Test1Box.TabIndex = 4;
            // 
            // Test2Box
            // 
            this.Test2Box.Location = new System.Drawing.Point(213, 143);
            this.Test2Box.Name = "Test2Box";
            this.Test2Box.Size = new System.Drawing.Size(100, 20);
            this.Test2Box.TabIndex = 5;
            // 
            // Test3Box
            // 
            this.Test3Box.Location = new System.Drawing.Point(213, 248);
            this.Test3Box.Name = "Test3Box";
            this.Test3Box.Size = new System.Drawing.Size(100, 20);
            this.Test3Box.TabIndex = 6;
            // 
            // AvgTestBox
            // 
            this.AvgTestBox.Location = new System.Drawing.Point(213, 336);
            this.AvgTestBox.Name = "AvgTestBox";
            this.AvgTestBox.ReadOnly = true;
            this.AvgTestBox.Size = new System.Drawing.Size(100, 20);
            this.AvgTestBox.TabIndex = 7;
            // 
            // AverageButton
            // 
            this.AverageButton.Location = new System.Drawing.Point(41, 413);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(107, 23);
            this.AverageButton.TabIndex = 8;
            this.AverageButton.Text = "Test Average";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(223, 413);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(381, 413);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 481);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.AvgTestBox);
            this.Controls.Add(this.Test3Box);
            this.Controls.Add(this.Test2Box);
            this.Controls.Add(this.Test1Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Test1Box;
        private System.Windows.Forms.TextBox Test2Box;
        private System.Windows.Forms.TextBox Test3Box;
        private System.Windows.Forms.TextBox AvgTestBox;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

