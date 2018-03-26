namespace Chapter3_Tutorial
{
    partial class Tutorial3_1
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
            this.Dayofweeklabel = new System.Windows.Forms.Label();
            this.nameofmonthlabel = new System.Windows.Forms.Label();
            this.dayofmonthlabel = new System.Windows.Forms.Label();
            this.theyear = new System.Windows.Forms.Label();
            this.DayOfWeekBox = new System.Windows.Forms.TextBox();
            this.NameOfMonthBox = new System.Windows.Forms.TextBox();
            this.DayOfMonthBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.DateOutput = new System.Windows.Forms.TextBox();
            this.ShowDateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dayofweeklabel
            // 
            this.Dayofweeklabel.AutoSize = true;
            this.Dayofweeklabel.Location = new System.Drawing.Point(12, 28);
            this.Dayofweeklabel.Name = "Dayofweeklabel";
            this.Dayofweeklabel.Size = new System.Drawing.Size(85, 13);
            this.Dayofweeklabel.TabIndex = 0;
            this.Dayofweeklabel.Text = "Day of the week";
            // 
            // nameofmonthlabel
            // 
            this.nameofmonthlabel.AutoSize = true;
            this.nameofmonthlabel.Location = new System.Drawing.Point(9, 87);
            this.nameofmonthlabel.Name = "nameofmonthlabel";
            this.nameofmonthlabel.Size = new System.Drawing.Size(97, 13);
            this.nameofmonthlabel.TabIndex = 1;
            this.nameofmonthlabel.Text = "Name of the month";
            // 
            // dayofmonthlabel
            // 
            this.dayofmonthlabel.AutoSize = true;
            this.dayofmonthlabel.Location = new System.Drawing.Point(9, 154);
            this.dayofmonthlabel.Name = "dayofmonthlabel";
            this.dayofmonthlabel.Size = new System.Drawing.Size(88, 13);
            this.dayofmonthlabel.TabIndex = 2;
            this.dayofmonthlabel.Text = "Day of the month";
            // 
            // theyear
            // 
            this.theyear.AutoSize = true;
            this.theyear.Location = new System.Drawing.Point(9, 215);
            this.theyear.Name = "theyear";
            this.theyear.Size = new System.Drawing.Size(49, 13);
            this.theyear.TabIndex = 3;
            this.theyear.Text = "The year";
            // 
            // DayOfWeekBox
            // 
            this.DayOfWeekBox.Location = new System.Drawing.Point(212, 28);
            this.DayOfWeekBox.Name = "DayOfWeekBox";
            this.DayOfWeekBox.Size = new System.Drawing.Size(125, 20);
            this.DayOfWeekBox.TabIndex = 4;
            // 
            // NameOfMonthBox
            // 
            this.NameOfMonthBox.Location = new System.Drawing.Point(212, 87);
            this.NameOfMonthBox.Name = "NameOfMonthBox";
            this.NameOfMonthBox.Size = new System.Drawing.Size(125, 20);
            this.NameOfMonthBox.TabIndex = 5;
            // 
            // DayOfMonthBox
            // 
            this.DayOfMonthBox.Location = new System.Drawing.Point(212, 154);
            this.DayOfMonthBox.Name = "DayOfMonthBox";
            this.DayOfMonthBox.Size = new System.Drawing.Size(125, 20);
            this.DayOfMonthBox.TabIndex = 6;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(212, 215);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(125, 20);
            this.YearBox.TabIndex = 7;
            // 
            // DateOutput
            // 
            this.DateOutput.Location = new System.Drawing.Point(92, 286);
            this.DateOutput.Name = "DateOutput";
            this.DateOutput.ReadOnly = true;
            this.DateOutput.Size = new System.Drawing.Size(335, 20);
            this.DateOutput.TabIndex = 8;
            // 
            // ShowDateButton
            // 
            this.ShowDateButton.Location = new System.Drawing.Point(47, 351);
            this.ShowDateButton.Name = "ShowDateButton";
            this.ShowDateButton.Size = new System.Drawing.Size(75, 23);
            this.ShowDateButton.TabIndex = 9;
            this.ShowDateButton.Text = "ShowDate";
            this.ShowDateButton.UseVisualStyleBackColor = true;
            this.ShowDateButton.Click += new System.EventHandler(this.ShowDateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(212, 351);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(392, 351);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Tutorial3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 397);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowDateButton);
            this.Controls.Add(this.DateOutput);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.DayOfMonthBox);
            this.Controls.Add(this.NameOfMonthBox);
            this.Controls.Add(this.DayOfWeekBox);
            this.Controls.Add(this.theyear);
            this.Controls.Add(this.dayofmonthlabel);
            this.Controls.Add(this.nameofmonthlabel);
            this.Controls.Add(this.Dayofweeklabel);
            this.Name = "Tutorial3_1";
            this.Text = "BirthDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dayofweeklabel;
        private System.Windows.Forms.Label nameofmonthlabel;
        private System.Windows.Forms.Label dayofmonthlabel;
        private System.Windows.Forms.Label theyear;
        private System.Windows.Forms.TextBox DayOfWeekBox;
        private System.Windows.Forms.TextBox NameOfMonthBox;
        private System.Windows.Forms.TextBox DayOfMonthBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox DateOutput;
        private System.Windows.Forms.Button ShowDateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

