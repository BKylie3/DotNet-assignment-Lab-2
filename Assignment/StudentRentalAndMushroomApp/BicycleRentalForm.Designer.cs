namespace StudentRentalAndMushroomApp
{
    partial class BicycleRentalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.pnlRates = new System.Windows.Forms.Panel();
            this.lblRatesTitle = new System.Windows.Forms.Label();
            this.lblRateTable = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lblStartHint = new System.Windows.Forms.Label();
            this.lblEndHint = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lstBreakdown = new System.Windows.Forms.ListBox();
            this.lblBreakdownTitle = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalCostTitle = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlRates.SuspendLayout();
            this.grpInputs.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(370, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Problem 1: Bicycle Rental Calculator";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 240, 255);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(27, 48);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(535, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Enter starting and ending hours to compute the multi-tiered rental cost in Rwandan Francs";
            // 
            // pnlRates
            // 
            this.pnlRates.BackColor = System.Drawing.Color.White;
            this.pnlRates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRates.Controls.Add(this.lblRatesTitle);
            this.pnlRates.Controls.Add(this.lblRateTable);
            this.pnlRates.Location = new System.Drawing.Point(25, 100);
            this.pnlRates.Name = "pnlRates";
            this.pnlRates.Size = new System.Drawing.Size(710, 85);
            this.pnlRates.TabIndex = 1;
            // 
            // lblRatesTitle
            // 
            this.lblRatesTitle.AutoSize = true;
            this.lblRatesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRatesTitle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblRatesTitle.Location = new System.Drawing.Point(12, 8);
            this.lblRatesTitle.Name = "lblRatesTitle";
            this.lblRatesTitle.Size = new System.Drawing.Size(127, 15);
            this.lblRatesTitle.TabIndex = 0;
            this.lblRatesTitle.Text = "Official Rental Rates:";
            // 
            // lblRateTable
            // 
            this.lblRateTable.AutoSize = true;
            this.lblRateTable.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblRateTable.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblRateTable.Location = new System.Drawing.Point(12, 30);
            this.lblRateTable.Name = "lblRateTable";
            this.lblRateTable.Size = new System.Drawing.Size(680, 30);
            this.lblRateTable.TabIndex = 1;
            this.lblRateTable.Text = "• 00:00–07:00: 500 RWF/hr  |  • 07:00–14:00: 1,000 RWF/hr  |  • 14:00–19:00: 1,500 RWF/hr\r\n• 19:00–21:00: 1,000 RWF/hr  |  • 21:00–24:00: 500 RWF/hr";
            // 
            // grpInputs
            // 
            this.grpInputs.BackColor = System.Drawing.Color.White;
            this.grpInputs.Controls.Add(this.lblStartHint);
            this.grpInputs.Controls.Add(this.lblEndHint);
            this.grpInputs.Controls.Add(this.btnClear);
            this.grpInputs.Controls.Add(this.btnCalculate);
            this.grpInputs.Controls.Add(this.txtEndHour);
            this.grpInputs.Controls.Add(this.lblEndHour);
            this.grpInputs.Controls.Add(this.txtStartHour);
            this.grpInputs.Controls.Add(this.lblStartHour);
            this.grpInputs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpInputs.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.grpInputs.Location = new System.Drawing.Point(25, 200);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(340, 290);
            this.grpInputs.TabIndex = 2;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Rental Hours Input";
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStartHour.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblStartHour.Location = new System.Drawing.Point(20, 35);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(129, 17);
            this.lblStartHour.TabIndex = 0;
            this.lblStartHour.Text = "Starting Hour (0-23):";
            // 
            // txtStartHour
            // 
            this.txtStartHour.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStartHour.Location = new System.Drawing.Point(23, 58);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(290, 27);
            this.txtStartHour.TabIndex = 1;
            // 
            // lblStartHint
            // 
            this.lblStartHint.AutoSize = true;
            this.lblStartHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStartHint.ForeColor = System.Drawing.Color.Gray;
            this.lblStartHint.Location = new System.Drawing.Point(23, 89);
            this.lblStartHint.Name = "lblStartHint";
            this.lblStartHint.Size = new System.Drawing.Size(206, 13);
            this.lblStartHint.TabIndex = 2;
            this.lblStartHint.Text = "Whole integer from 0 (midnight) to 23";
            // 
            // lblEndHour
            // 
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEndHour.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblEndHour.Location = new System.Drawing.Point(20, 118);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(121, 17);
            this.lblEndHour.TabIndex = 3;
            this.lblEndHour.Text = "Ending Hour (1-24):";
            // 
            // txtEndHour
            // 
            this.txtEndHour.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEndHour.Location = new System.Drawing.Point(23, 140);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(290, 27);
            this.txtEndHour.TabIndex = 4;
            // 
            // lblEndHint
            // 
            this.lblEndHint.AutoSize = true;
            this.lblEndHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEndHint.ForeColor = System.Drawing.Color.Gray;
            this.lblEndHint.Location = new System.Drawing.Point(23, 171);
            this.lblEndHint.Name = "lblEndHint";
            this.lblEndHint.Size = new System.Drawing.Size(225, 13);
            this.lblEndHint.TabIndex = 5;
            this.lblEndHint.Text = "Whole integer from 1 to 24 (next midnight)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(23, 215);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(175, 42);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnClear.Location = new System.Drawing.Point(208, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 42);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpResults
            // 
            this.grpResults.BackColor = System.Drawing.Color.White;
            this.grpResults.Controls.Add(this.lblDuration);
            this.grpResults.Controls.Add(this.lstBreakdown);
            this.grpResults.Controls.Add(this.lblBreakdownTitle);
            this.grpResults.Controls.Add(this.lblTotalCost);
            this.grpResults.Controls.Add(this.lblTotalCostTitle);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResults.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.grpResults.Location = new System.Drawing.Point(385, 200);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(350, 290);
            this.grpResults.TabIndex = 3;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Calculation Result";
            // 
            // lblTotalCostTitle
            // 
            this.lblTotalCostTitle.AutoSize = true;
            this.lblTotalCostTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalCostTitle.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblTotalCostTitle.Location = new System.Drawing.Point(20, 28);
            this.lblTotalCostTitle.Name = "lblTotalCostTitle";
            this.lblTotalCostTitle.Size = new System.Drawing.Size(117, 17);
            this.lblTotalCostTitle.TabIndex = 0;
            this.lblTotalCostTitle.Text = "Total Rental Cost:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(235, 245, 255);
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.lblTotalCost.Location = new System.Drawing.Point(20, 52);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(310, 40);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "0 RWF";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblDuration.Location = new System.Drawing.Point(20, 96);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(310, 20);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration: 0 hour(s)";
            // 
            // lblBreakdownTitle
            // 
            this.lblBreakdownTitle.AutoSize = true;
            this.lblBreakdownTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBreakdownTitle.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblBreakdownTitle.Location = new System.Drawing.Point(20, 122);
            this.lblBreakdownTitle.Name = "lblBreakdownTitle";
            this.lblBreakdownTitle.Size = new System.Drawing.Size(149, 15);
            this.lblBreakdownTitle.TabIndex = 3;
            this.lblBreakdownTitle.Text = "Hourly Rates Breakdown:";
            // 
            // lstBreakdown
            // 
            this.lstBreakdown.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.lstBreakdown.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstBreakdown.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lstBreakdown.FormattingEnabled = true;
            this.lstBreakdown.ItemHeight = 14;
            this.lstBreakdown.Location = new System.Drawing.Point(20, 142);
            this.lstBreakdown.Name = "lstBreakdown";
            this.lstBreakdown.Size = new System.Drawing.Size(310, 130);
            this.lstBreakdown.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnReturn.Location = new System.Drawing.Point(25, 510);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(220, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "<< Return to Main Selection";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(605, 510);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BicycleRentalForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(760, 575);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.pnlRates);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BicycleRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicycle Rental Calculator - Problem 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BicycleRentalForm_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlRates.ResumeLayout(false);
            this.pnlRates.PerformLayout();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlRates;
        private System.Windows.Forms.Label lblRatesTitle;
        private System.Windows.Forms.Label lblRateTable;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label lblStartHint;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.Label lblEndHint;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblTotalCostTitle;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblBreakdownTitle;
        private System.Windows.Forms.ListBox lstBreakdown;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogout;
    }
}

