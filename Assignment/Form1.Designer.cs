namespace Assignment
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
            this.BillAmount = new System.Windows.Forms.TextBox();
            this.Bill = new System.Windows.Forms.Label();
            this.Label_TipPercent = new System.Windows.Forms.Label();
            this.SubtractTip = new System.Windows.Forms.Button();
            this.TipPercent = new System.Windows.Forms.TextBox();
            this.AddTip = new System.Windows.Forms.Button();
            this.Label_NumberOfPeople = new System.Windows.Forms.Label();
            this.TotalPeople = new System.Windows.Forms.TextBox();
            this.AddPeople = new System.Windows.Forms.Button();
            this.SubtractPeople = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.Label();
            this.PerPerson1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.PerPerson2 = new System.Windows.Forms.Label();
            this.TipPerPerson = new System.Windows.Forms.Label();
            this.TotalPerPerson = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BillAmount
            // 
            this.BillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillAmount.Location = new System.Drawing.Point(27, 53);
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.Size = new System.Drawing.Size(271, 44);
            this.BillAmount.TabIndex = 0;
            this.BillAmount.Text = "0.00";
            this.BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillAmount.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bill.Location = new System.Drawing.Point(22, 25);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(37, 25);
            this.Bill.TabIndex = 1;
            this.Bill.Text = "Bill";
            // 
            // Label_TipPercent
            // 
            this.Label_TipPercent.AutoSize = true;
            this.Label_TipPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TipPercent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_TipPercent.Location = new System.Drawing.Point(22, 127);
            this.Label_TipPercent.Name = "Label_TipPercent";
            this.Label_TipPercent.Size = new System.Drawing.Size(63, 25);
            this.Label_TipPercent.TabIndex = 2;
            this.Label_TipPercent.Text = "Tip %";
            // 
            // SubtractTip
            // 
            this.SubtractTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractTip.Location = new System.Drawing.Point(27, 155);
            this.SubtractTip.Name = "SubtractTip";
            this.SubtractTip.Size = new System.Drawing.Size(42, 52);
            this.SubtractTip.TabIndex = 3;
            this.SubtractTip.Text = "-";
            this.SubtractTip.UseVisualStyleBackColor = true;
            this.SubtractTip.Click += new System.EventHandler(this.SubtractTip_Click);
            // 
            // TipPercent
            // 
            this.TipPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPercent.Location = new System.Drawing.Point(66, 155);
            this.TipPercent.Name = "TipPercent";
            this.TipPercent.ReadOnly = true;
            this.TipPercent.Size = new System.Drawing.Size(196, 44);
            this.TipPercent.TabIndex = 4;
            this.TipPercent.Text = "0 %";
            this.TipPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddTip
            // 
            this.AddTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTip.Location = new System.Drawing.Point(259, 155);
            this.AddTip.Name = "AddTip";
            this.AddTip.Size = new System.Drawing.Size(39, 52);
            this.AddTip.TabIndex = 5;
            this.AddTip.Text = "+";
            this.AddTip.UseVisualStyleBackColor = true;
            this.AddTip.Click += new System.EventHandler(this.AddTip_Click);
            // 
            // Label_NumberOfPeople
            // 
            this.Label_NumberOfPeople.AutoSize = true;
            this.Label_NumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumberOfPeople.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_NumberOfPeople.Location = new System.Drawing.Point(22, 230);
            this.Label_NumberOfPeople.Name = "Label_NumberOfPeople";
            this.Label_NumberOfPeople.Size = new System.Drawing.Size(168, 25);
            this.Label_NumberOfPeople.TabIndex = 6;
            this.Label_NumberOfPeople.Text = "Number of People";
            // 
            // TotalPeople
            // 
            this.TotalPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPeople.Location = new System.Drawing.Point(66, 259);
            this.TotalPeople.Name = "TotalPeople";
            this.TotalPeople.ReadOnly = true;
            this.TotalPeople.Size = new System.Drawing.Size(196, 44);
            this.TotalPeople.TabIndex = 7;
            this.TotalPeople.Text = "0";
            this.TotalPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPeople
            // 
            this.AddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPeople.Location = new System.Drawing.Point(259, 259);
            this.AddPeople.Name = "AddPeople";
            this.AddPeople.Size = new System.Drawing.Size(39, 51);
            this.AddPeople.TabIndex = 8;
            this.AddPeople.Text = "+";
            this.AddPeople.UseVisualStyleBackColor = true;
            this.AddPeople.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // SubtractPeople
            // 
            this.SubtractPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractPeople.Location = new System.Drawing.Point(27, 259);
            this.SubtractPeople.Name = "SubtractPeople";
            this.SubtractPeople.Size = new System.Drawing.Size(42, 51);
            this.SubtractPeople.TabIndex = 9;
            this.SubtractPeople.Text = "-";
            this.SubtractPeople.UseVisualStyleBackColor = true;
            this.SubtractPeople.Click += new System.EventHandler(this.SubtractPeople_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Line.Location = new System.Drawing.Point(325, -2);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(3, 365);
            this.Line.TabIndex = 10;
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip.Location = new System.Drawing.Point(373, 98);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(62, 37);
            this.Tip.TabIndex = 11;
            this.Tip.Text = "Tip";
            // 
            // PerPerson1
            // 
            this.PerPerson1.AutoSize = true;
            this.PerPerson1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PerPerson1.Location = new System.Drawing.Point(376, 135);
            this.PerPerson1.Name = "PerPerson1";
            this.PerPerson1.Size = new System.Drawing.Size(89, 20);
            this.PerPerson1.TabIndex = 12;
            this.PerPerson1.Text = " per person";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(373, 196);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(89, 37);
            this.Total.TabIndex = 13;
            this.Total.Text = "Total";
            // 
            // PerPerson2
            // 
            this.PerPerson2.AutoSize = true;
            this.PerPerson2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PerPerson2.Location = new System.Drawing.Point(376, 233);
            this.PerPerson2.Name = "PerPerson2";
            this.PerPerson2.Size = new System.Drawing.Size(89, 20);
            this.PerPerson2.TabIndex = 14;
            this.PerPerson2.Text = " per person";
            // 
            // TipPerPerson
            // 
            this.TipPerPerson.AutoSize = true;
            this.TipPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPerPerson.Location = new System.Drawing.Point(568, 98);
            this.TipPerPerson.Name = "TipPerPerson";
            this.TipPerPerson.Size = new System.Drawing.Size(78, 55);
            this.TipPerPerson.TabIndex = 15;
            this.TipPerPerson.Text = "$0";
            // 
            // TotalPerPerson
            // 
            this.TotalPerPerson.AutoSize = true;
            this.TotalPerPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPerPerson.Location = new System.Drawing.Point(568, 196);
            this.TotalPerPerson.Name = "TotalPerPerson";
            this.TotalPerPerson.Size = new System.Drawing.Size(78, 55);
            this.TotalPerPerson.TabIndex = 16;
            this.TotalPerPerson.Text = "$0";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(27, 323);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 20);
            this.Error.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 352);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.TotalPerPerson);
            this.Controls.Add(this.TipPerPerson);
            this.Controls.Add(this.PerPerson2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.PerPerson1);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.SubtractPeople);
            this.Controls.Add(this.AddPeople);
            this.Controls.Add(this.TotalPeople);
            this.Controls.Add(this.Label_NumberOfPeople);
            this.Controls.Add(this.AddTip);
            this.Controls.Add(this.TipPercent);
            this.Controls.Add(this.SubtractTip);
            this.Controls.Add(this.Label_TipPercent);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.BillAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BillAmount;
        private System.Windows.Forms.Label Bill;
        private System.Windows.Forms.Label Label_TipPercent;
        private System.Windows.Forms.Button SubtractTip;
        private System.Windows.Forms.TextBox TipPercent;
        private System.Windows.Forms.Button AddTip;
        private System.Windows.Forms.Label Label_NumberOfPeople;
        private System.Windows.Forms.TextBox TotalPeople;
        private System.Windows.Forms.Button AddPeople;
        private System.Windows.Forms.Button SubtractPeople;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.Label PerPerson1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label PerPerson2;
        private System.Windows.Forms.Label TipPerPerson;
        private System.Windows.Forms.Label TotalPerPerson;
        private System.Windows.Forms.Label Error;
    }
}

