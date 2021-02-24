
namespace EmployeeShipmentTracker
{
    partial class ShipmentsByEmployee
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxEmployee1 = new System.Windows.Forms.TextBox();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.textBoxEmployee2 = new System.Windows.Forms.TextBox();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.textBoxEmployee3 = new System.Windows.Forms.TextBox();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxAverageOfEmployee1 = new System.Windows.Forms.TextBox();
            this.textBoxAverageOfEmployee2 = new System.Windows.Forms.TextBox();
            this.textBoxAverageOfEmployee3 = new System.Windows.Forms.TextBox();
            this.textBoxPerDayAverage = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBoxEmployee1
            // 
            this.textBoxEmployee1.Location = new System.Drawing.Point(12, 118);
            this.textBoxEmployee1.Multiline = true;
            this.textBoxEmployee1.Name = "textBoxEmployee1";
            this.textBoxEmployee1.Size = new System.Drawing.Size(168, 278);
            this.textBoxEmployee1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxEmployee1, "Employee one\'s units shipped");
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(79, 50);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(62, 27);
            this.textBoxUnits.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxUnits, "Enter units shipped here");
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(23, 21);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(47, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day 1";
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.AutoSize = true;
            this.labelEmployee1.Location = new System.Drawing.Point(54, 95);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(87, 20);
            this.labelEmployee1.TabIndex = 3;
            this.labelEmployee1.Text = "Employee 1";
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.AutoSize = true;
            this.labelEmployee2.Location = new System.Drawing.Point(239, 95);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(87, 20);
            this.labelEmployee2.TabIndex = 5;
            this.labelEmployee2.Text = "Employee 2";
            // 
            // textBoxEmployee2
            // 
            this.textBoxEmployee2.Location = new System.Drawing.Point(199, 118);
            this.textBoxEmployee2.Multiline = true;
            this.textBoxEmployee2.Name = "textBoxEmployee2";
            this.textBoxEmployee2.Size = new System.Drawing.Size(168, 278);
            this.textBoxEmployee2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxEmployee2, "Employee two\'s units shipped");
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.AutoSize = true;
            this.labelEmployee3.Location = new System.Drawing.Point(429, 95);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(87, 20);
            this.labelEmployee3.TabIndex = 7;
            this.labelEmployee3.Text = "Employee 3";
            // 
            // textBoxEmployee3
            // 
            this.textBoxEmployee3.Location = new System.Drawing.Point(387, 118);
            this.textBoxEmployee3.Multiline = true;
            this.textBoxEmployee3.Name = "textBoxEmployee3";
            this.textBoxEmployee3.Size = new System.Drawing.Size(168, 278);
            this.textBoxEmployee3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxEmployee3, "Employee three\'s units shipped");
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(23, 53);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(45, 20);
            this.labelUnits.TabIndex = 8;
            this.labelUnits.Text = "Units:";
            // 
            // textBoxAverageOfEmployee1
            // 
            this.textBoxAverageOfEmployee1.Enabled = false;
            this.textBoxAverageOfEmployee1.Location = new System.Drawing.Point(12, 402);
            this.textBoxAverageOfEmployee1.Name = "textBoxAverageOfEmployee1";
            this.textBoxAverageOfEmployee1.ReadOnly = true;
            this.textBoxAverageOfEmployee1.Size = new System.Drawing.Size(168, 27);
            this.textBoxAverageOfEmployee1.TabIndex = 9;
            // 
            // textBoxAverageOfEmployee2
            // 
            this.textBoxAverageOfEmployee2.Enabled = false;
            this.textBoxAverageOfEmployee2.Location = new System.Drawing.Point(199, 402);
            this.textBoxAverageOfEmployee2.Name = "textBoxAverageOfEmployee2";
            this.textBoxAverageOfEmployee2.ReadOnly = true;
            this.textBoxAverageOfEmployee2.Size = new System.Drawing.Size(168, 27);
            this.textBoxAverageOfEmployee2.TabIndex = 10;
            // 
            // textBoxAverageOfEmployee3
            // 
            this.textBoxAverageOfEmployee3.Enabled = false;
            this.textBoxAverageOfEmployee3.Location = new System.Drawing.Point(387, 402);
            this.textBoxAverageOfEmployee3.Name = "textBoxAverageOfEmployee3";
            this.textBoxAverageOfEmployee3.ReadOnly = true;
            this.textBoxAverageOfEmployee3.Size = new System.Drawing.Size(168, 27);
            this.textBoxAverageOfEmployee3.TabIndex = 11;
            // 
            // textBoxPerDayAverage
            // 
            this.textBoxPerDayAverage.Enabled = false;
            this.textBoxPerDayAverage.Location = new System.Drawing.Point(12, 446);
            this.textBoxPerDayAverage.Name = "textBoxPerDayAverage";
            this.textBoxPerDayAverage.ReadOnly = true;
            this.textBoxPerDayAverage.Size = new System.Drawing.Size(543, 27);
            this.textBoxPerDayAverage.TabIndex = 12;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 479);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(168, 39);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(199, 479);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(168, 39);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(387, 479);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(168, 39);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ShipmentsByEmployee
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(567, 523);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPerDayAverage);
            this.Controls.Add(this.textBoxAverageOfEmployee3);
            this.Controls.Add(this.textBoxAverageOfEmployee2);
            this.Controls.Add(this.textBoxAverageOfEmployee1);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.textBoxEmployee3);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.textBoxEmployee2);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.textBoxEmployee1);
            this.Name = "ShipmentsByEmployee";
            this.Text = "Average Units Shipped by Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmployee1;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.TextBox textBoxEmployee2;
        private System.Windows.Forms.Label labelEmployee3;
        private System.Windows.Forms.TextBox textBoxEmployee3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxAverageOfEmployee1;
        private System.Windows.Forms.TextBox textBoxAverageOfEmployee2;
        private System.Windows.Forms.TextBox textBoxAverageOfEmployee3;
        private System.Windows.Forms.TextBox textBoxPerDayAverage;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2textBoxAverageOfEmployee2;
        private System.Windows.Forms.Button buttonReset;
    }
}

