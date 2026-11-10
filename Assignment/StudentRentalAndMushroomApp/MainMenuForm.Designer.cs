namespace StudentRentalAndMushroomApp
{
    partial class MainMenuForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblDescMushroom = new System.Windows.Forms.Label();
            this.lblDescBicycle = new System.Windows.Forms.Label();
            this.btnOpenMushroom = new System.Windows.Forms.Button();
            this.btnOpenBicycle = new System.Windows.Forms.Button();
            this.rbMushroomId = new System.Windows.Forms.RadioButton();
            this.rbBicycleRental = new System.Windows.Forms.RadioButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(24, 43, 73);
            this.pnlTop.Controls.Add(this.lblUserStatus);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblSubtitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(680, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Main Selection Console";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 205, 235);
            this.lblSubtitle.Location = new System.Drawing.Point(32, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(395, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select an assignment problem to launch its graphical user interface:";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblUserStatus.ForeColor = System.Drawing.Color.FromArgb(200, 220, 245);
            this.lblUserStatus.Location = new System.Drawing.Point(400, 25);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(250, 20);
            this.lblUserStatus.TabIndex = 2;
            this.lblUserStatus.Text = "Logged in as: student";
            this.lblUserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpOptions
            // 
            this.grpOptions.BackColor = System.Drawing.Color.White;
            this.grpOptions.Controls.Add(this.lblDescMushroom);
            this.grpOptions.Controls.Add(this.lblDescBicycle);
            this.grpOptions.Controls.Add(this.btnOpenMushroom);
            this.grpOptions.Controls.Add(this.btnOpenBicycle);
            this.grpOptions.Controls.Add(this.rbMushroomId);
            this.grpOptions.Controls.Add(this.rbBicycleRental);
            this.grpOptions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpOptions.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.grpOptions.Location = new System.Drawing.Point(35, 125);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(610, 205);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Assignment Problem Modules";
            // 
            // rbBicycleRental
            // 
            this.rbBicycleRental.AutoSize = true;
            this.rbBicycleRental.Checked = true;
            this.rbBicycleRental.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbBicycleRental.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.rbBicycleRental.Location = new System.Drawing.Point(30, 40);
            this.rbBicycleRental.Name = "rbBicycleRental";
            this.rbBicycleRental.Size = new System.Drawing.Size(262, 24);
            this.rbBicycleRental.TabIndex = 0;
            this.rbBicycleRental.TabStop = true;
            this.rbBicycleRental.Text = "Problem 1: Bicycle Rental Calculator";
            this.rbBicycleRental.UseVisualStyleBackColor = true;
            // 
            // lblDescBicycle
            // 
            this.lblDescBicycle.AutoSize = true;
            this.lblDescBicycle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescBicycle.ForeColor = System.Drawing.Color.Gray;
            this.lblDescBicycle.Location = new System.Drawing.Point(52, 68);
            this.lblDescBicycle.Name = "lblDescBicycle";
            this.lblDescBicycle.Size = new System.Drawing.Size(350, 15);
            this.lblDescBicycle.TabIndex = 1;
            this.lblDescBicycle.Text = "Calculates multi-rate hourly rental charges using loops and conditions.";
            // 
            // btnOpenBicycle
            // 
            this.btnOpenBicycle.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnOpenBicycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBicycle.FlatAppearance.BorderSize = 0;
            this.btnOpenBicycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBicycle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenBicycle.ForeColor = System.Drawing.Color.White;
            this.btnOpenBicycle.Location = new System.Drawing.Point(440, 43);
            this.btnOpenBicycle.Name = "btnOpenBicycle";
            this.btnOpenBicycle.Size = new System.Drawing.Size(140, 38);
            this.btnOpenBicycle.TabIndex = 2;
            this.btnOpenBicycle.Text = "Open Bicycle >>";
            this.btnOpenBicycle.UseVisualStyleBackColor = false;
            this.btnOpenBicycle.Click += new System.EventHandler(this.btnOpenBicycle_Click);
            // 
            // rbMushroomId
            // 
            this.rbMushroomId.AutoSize = true;
            this.rbMushroomId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbMushroomId.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.rbMushroomId.Location = new System.Drawing.Point(30, 120);
            this.rbMushroomId.Name = "rbMushroomId";
            this.rbMushroomId.Size = new System.Drawing.Size(287, 24);
            this.rbMushroomId.TabIndex = 3;
            this.rbMushroomId.Text = "Problem 2: Mushroom Identification";
            this.rbMushroomId.UseVisualStyleBackColor = true;
            // 
            // lblDescMushroom
            // 
            this.lblDescMushroom.AutoSize = true;
            this.lblDescMushroom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescMushroom.ForeColor = System.Drawing.Color.Gray;
            this.lblDescMushroom.Location = new System.Drawing.Point(52, 148);
            this.lblDescMushroom.Name = "lblDescMushroom";
            this.lblDescMushroom.Size = new System.Drawing.Size(360, 15);
            this.lblDescMushroom.TabIndex = 4;
            this.lblDescMushroom.Text = "Identifies mushrooms adaptively in at most 3 questions by eliminating options.";
            // 
            // btnOpenMushroom
            // 
            this.btnOpenMushroom.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnOpenMushroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMushroom.FlatAppearance.BorderSize = 0;
            this.btnOpenMushroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMushroom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnOpenMushroom.ForeColor = System.Drawing.Color.White;
            this.btnOpenMushroom.Location = new System.Drawing.Point(440, 123);
            this.btnOpenMushroom.Name = "btnOpenMushroom";
            this.btnOpenMushroom.Size = new System.Drawing.Size(140, 38);
            this.btnOpenMushroom.TabIndex = 5;
            this.btnOpenMushroom.Text = "Open Mushroom >>";
            this.btnOpenMushroom.UseVisualStyleBackColor = false;
            this.btnOpenMushroom.Click += new System.EventHandler(this.btnOpenMushroom_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(680, 360);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Selection Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rbBicycleRental;
        private System.Windows.Forms.Label lblDescBicycle;
        private System.Windows.Forms.Button btnOpenBicycle;
        private System.Windows.Forms.RadioButton rbMushroomId;
        private System.Windows.Forms.Label lblDescMushroom;
        private System.Windows.Forms.Button btnOpenMushroom;
    }
}