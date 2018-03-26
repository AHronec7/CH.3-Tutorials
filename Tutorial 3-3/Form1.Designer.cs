namespace Tutorial_3_3
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
            this.OriginalPriceBox = new System.Windows.Forms.TextBox();
            this.DiscountPriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalePriceBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Price";
            // 
            // OriginalPriceBox
            // 
            this.OriginalPriceBox.Location = new System.Drawing.Point(219, 41);
            this.OriginalPriceBox.Name = "OriginalPriceBox";
            this.OriginalPriceBox.Size = new System.Drawing.Size(100, 20);
            this.OriginalPriceBox.TabIndex = 1;
            // 
            // DiscountPriceBox
            // 
            this.DiscountPriceBox.Location = new System.Drawing.Point(219, 95);
            this.DiscountPriceBox.Name = "DiscountPriceBox";
            this.DiscountPriceBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountPriceBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sale Price";
            // 
            // SalePriceBox
            // 
            this.SalePriceBox.Location = new System.Drawing.Point(219, 179);
            this.SalePriceBox.Name = "SalePriceBox";
            this.SalePriceBox.ReadOnly = true;
            this.SalePriceBox.Size = new System.Drawing.Size(100, 20);
            this.SalePriceBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(93, 237);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(143, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate Sale Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(334, 237);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 284);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalePriceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiscountPriceBox);
            this.Controls.Add(this.OriginalPriceBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OriginalPriceBox;
        private System.Windows.Forms.TextBox DiscountPriceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalePriceBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

