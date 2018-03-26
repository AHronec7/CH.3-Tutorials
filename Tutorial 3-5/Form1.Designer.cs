namespace Tutorial_3_5
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
            this.FiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.TwentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.TenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.FiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiveCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FiftyCentsPictureBox
            // 
            this.FiftyCentsPictureBox.Image = global::Tutorial_3_5.Properties.Resources._50_cents;
            this.FiftyCentsPictureBox.Location = new System.Drawing.Point(248, 241);
            this.FiftyCentsPictureBox.Name = "FiftyCentsPictureBox";
            this.FiftyCentsPictureBox.Size = new System.Drawing.Size(188, 163);
            this.FiftyCentsPictureBox.TabIndex = 3;
            this.FiftyCentsPictureBox.TabStop = false;
            this.FiftyCentsPictureBox.Click += new System.EventHandler(this.FiftyCentsPictureBox_Click);
            // 
            // TwentyFiveCentsPictureBox
            // 
            this.TwentyFiveCentsPictureBox.Image = global::Tutorial_3_5.Properties.Resources.quarter;
            this.TwentyFiveCentsPictureBox.Location = new System.Drawing.Point(2, 241);
            this.TwentyFiveCentsPictureBox.Name = "TwentyFiveCentsPictureBox";
            this.TwentyFiveCentsPictureBox.Size = new System.Drawing.Size(208, 163);
            this.TwentyFiveCentsPictureBox.TabIndex = 2;
            this.TwentyFiveCentsPictureBox.TabStop = false;
            this.TwentyFiveCentsPictureBox.Click += new System.EventHandler(this.TwentyFiveCentsPictureBox_Click);
            // 
            // TenCentsPictureBox
            // 
            this.TenCentsPictureBox.Image = global::Tutorial_3_5.Properties.Resources.dime;
            this.TenCentsPictureBox.Location = new System.Drawing.Point(227, -1);
            this.TenCentsPictureBox.Name = "TenCentsPictureBox";
            this.TenCentsPictureBox.Size = new System.Drawing.Size(188, 201);
            this.TenCentsPictureBox.TabIndex = 1;
            this.TenCentsPictureBox.TabStop = false;
            this.TenCentsPictureBox.Click += new System.EventHandler(this.TenCentsPictureBox_Click);
            // 
            // FiveCentsPictureBox
            // 
            this.FiveCentsPictureBox.Image = global::Tutorial_3_5.Properties.Resources.nickel;
            this.FiveCentsPictureBox.Location = new System.Drawing.Point(2, -1);
            this.FiveCentsPictureBox.Name = "FiveCentsPictureBox";
            this.FiveCentsPictureBox.Size = new System.Drawing.Size(187, 164);
            this.FiveCentsPictureBox.TabIndex = 0;
            this.FiveCentsPictureBox.TabStop = false;
            this.FiveCentsPictureBox.Click += new System.EventHandler(this.FiveCentsPictureBox_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(298, 451);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(100, 451);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 5;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 499);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FiftyCentsPictureBox);
            this.Controls.Add(this.TwentyFiveCentsPictureBox);
            this.Controls.Add(this.TenCentsPictureBox);
            this.Controls.Add(this.FiveCentsPictureBox);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.FiftyCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiveCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FiveCentsPictureBox;
        private System.Windows.Forms.PictureBox TenCentsPictureBox;
        private System.Windows.Forms.PictureBox TwentyFiveCentsPictureBox;
        private System.Windows.Forms.PictureBox FiftyCentsPictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox TotalTextBox;
    }
}

