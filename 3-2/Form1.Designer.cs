namespace _3_2
{
    partial class FuelForm
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
            this.MilesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GasLabel = new System.Windows.Forms.Label();
            this.MPGLabel = new System.Windows.Forms.Label();
            this.MilesTextBox = new System.Windows.Forms.TextBox();
            this.GasTextBox = new System.Windows.Forms.TextBox();
            this.MPGBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MilesLabel
            // 
            this.MilesLabel.AutoSize = true;
            this.MilesLabel.Location = new System.Drawing.Point(13, 33);
            this.MilesLabel.Name = "MilesLabel";
            this.MilesLabel.Size = new System.Drawing.Size(114, 13);
            this.MilesLabel.TabIndex = 0;
            this.MilesLabel.Text = "Number of miles driven";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // GasLabel
            // 
            this.GasLabel.AutoSize = true;
            this.GasLabel.Location = new System.Drawing.Point(16, 96);
            this.GasLabel.Name = "GasLabel";
            this.GasLabel.Size = new System.Drawing.Size(124, 13);
            this.GasLabel.TabIndex = 2;
            this.GasLabel.Text = "Number Of Gallons Used";
            // 
            // MPGLabel
            // 
            this.MPGLabel.AutoSize = true;
            this.MPGLabel.Location = new System.Drawing.Point(129, 215);
            this.MPGLabel.Name = "MPGLabel";
            this.MPGLabel.Size = new System.Drawing.Size(50, 13);
            this.MPGLabel.TabIndex = 3;
            this.MPGLabel.Text = "Car MPG";
            // 
            // MilesTextBox
            // 
            this.MilesTextBox.Location = new System.Drawing.Point(227, 33);
            this.MilesTextBox.Name = "MilesTextBox";
            this.MilesTextBox.Size = new System.Drawing.Size(111, 20);
            this.MilesTextBox.TabIndex = 4;
            // 
            // GasTextBox
            // 
            this.GasTextBox.Location = new System.Drawing.Point(227, 96);
            this.GasTextBox.Name = "GasTextBox";
            this.GasTextBox.Size = new System.Drawing.Size(111, 20);
            this.GasTextBox.TabIndex = 5;
            // 
            // MPGBox
            // 
            this.MPGBox.Location = new System.Drawing.Point(227, 215);
            this.MPGBox.Name = "MPGBox";
            this.MPGBox.ReadOnly = true;
            this.MPGBox.Size = new System.Drawing.Size(111, 20);
            this.MPGBox.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(64, 332);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(103, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate MPG";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(252, 332);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 394);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.MPGBox);
            this.Controls.Add(this.GasTextBox);
            this.Controls.Add(this.MilesTextBox);
            this.Controls.Add(this.MPGLabel);
            this.Controls.Add(this.GasLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MilesLabel);
            this.Name = "FuelForm";
            this.Text = "Calculating Fuel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MilesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GasLabel;
        private System.Windows.Forms.Label MPGLabel;
        private System.Windows.Forms.TextBox MilesTextBox;
        private System.Windows.Forms.TextBox GasTextBox;
        private System.Windows.Forms.TextBox MPGBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

