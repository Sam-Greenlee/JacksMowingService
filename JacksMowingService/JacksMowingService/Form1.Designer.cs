namespace JacksMowingService
{
    partial class frmJacksMowingService
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
            this.lblDayDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDayHours = new System.Windows.Forms.TextBox();
            this.txtDayPay = new System.Windows.Forms.TextBox();
            this.btnCalculateRate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDaysEntered = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAverageRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExit = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtShowStats = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDayDisplay
            // 
            this.lblDayDisplay.AutoSize = true;
            this.lblDayDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayDisplay.Location = new System.Drawing.Point(43, 93);
            this.lblDayDisplay.Name = "lblDayDisplay";
            this.lblDayDisplay.Size = new System.Drawing.Size(93, 32);
            this.lblDayDisplay.TabIndex = 0;
            this.lblDayDisplay.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pay";
            // 
            // txtDayHours
            // 
            this.txtDayHours.Location = new System.Drawing.Point(367, 93);
            this.txtDayHours.Name = "txtDayHours";
            this.txtDayHours.Size = new System.Drawing.Size(143, 22);
            this.txtDayHours.TabIndex = 3;
            // 
            // txtDayPay
            // 
            this.txtDayPay.Location = new System.Drawing.Point(590, 93);
            this.txtDayPay.Name = "txtDayPay";
            this.txtDayPay.Size = new System.Drawing.Size(140, 22);
            this.txtDayPay.TabIndex = 4;
            // 
            // btnCalculateRate
            // 
            this.btnCalculateRate.Location = new System.Drawing.Point(590, 136);
            this.btnCalculateRate.Name = "btnCalculateRate";
            this.btnCalculateRate.Size = new System.Drawing.Size(143, 23);
            this.btnCalculateRate.TabIndex = 5;
            this.btnCalculateRate.Text = "Calculate Rate";
            this.btnCalculateRate.UseVisualStyleBackColor = true;
            this.btnCalculateRate.Click += new System.EventHandler(this.btnCalculateRate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Days Entered";
            // 
            // txtDaysEntered
            // 
            this.txtDaysEntered.Location = new System.Drawing.Point(590, 236);
            this.txtDaysEntered.Name = "txtDaysEntered";
            this.txtDaysEntered.ReadOnly = true;
            this.txtDaysEntered.Size = new System.Drawing.Size(140, 22);
            this.txtDaysEntered.TabIndex = 7;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(590, 284);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.ReadOnly = true;
            this.txtHourlyRate.Size = new System.Drawing.Size(140, 22);
            this.txtHourlyRate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Day Hourly Rate";
            // 
            // txtAverageRate
            // 
            this.txtAverageRate.Location = new System.Drawing.Point(590, 341);
            this.txtAverageRate.Name = "txtAverageRate";
            this.txtAverageRate.ReadOnly = true;
            this.txtAverageRate.Size = new System.Drawing.Size(140, 22);
            this.txtAverageRate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average Rate for Days Entered";
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(185, 420);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 12;
            this.txtExit.Text = "E&xit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(419, 420);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 13;
            this.txtReset.Text = "&Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtShowStats
            // 
            this.txtShowStats.Location = new System.Drawing.Point(628, 420);
            this.txtShowStats.Name = "txtShowStats";
            this.txtShowStats.Size = new System.Drawing.Size(102, 23);
            this.txtShowStats.TabIndex = 14;
            this.txtShowStats.Text = "&Show Stats";
            this.txtShowStats.UseVisualStyleBackColor = true;
            this.txtShowStats.Click += new System.EventHandler(this.txtShowStats_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jack\'s Mowing Service";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 657);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtShowStats);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAverageRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtDaysEntered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculateRate);
            this.Controls.Add(this.txtDayPay);
            this.Controls.Add(this.txtDayHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDayDisplay);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.frmJacksMowingService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDayDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDayHours;
        private System.Windows.Forms.TextBox txtDayPay;
        private System.Windows.Forms.Button btnCalculateRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDaysEntered;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAverageRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button txtShowStats;
        private System.Windows.Forms.Label label6;
    }
}

