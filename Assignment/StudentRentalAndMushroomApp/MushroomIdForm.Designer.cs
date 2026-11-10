namespace StudentRentalAndMushroomApp
{
    partial class MushroomIdForm
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
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.lblQuestionBadge = new System.Windows.Forms.Label();
            this.lblQuestionPrompt = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lblResultStatus = new System.Windows.Forms.Label();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.grpRemaining = new System.Windows.Forms.GroupBox();
            this.lstRemaining = new System.Windows.Forms.ListBox();
            this.lblRemainingCount = new System.Windows.Forms.Label();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.pnlReference = new System.Windows.Forms.Panel();
            this.lblRefTitle = new System.Windows.Forms.Label();
            this.lblRefContent = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.grpRemaining.SuspendLayout();
            this.grpHistory.SuspendLayout();
            this.pnlReference.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 85);
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
            this.lblHeaderTitle.Text = "Problem 2: Mushroom Identification";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(220, 245, 225);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(27, 48);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(565, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Adaptive botanical identification using at most three questions with continuous elimination.";
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BackColor = System.Drawing.Color.White;
            this.pnlQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestion.Controls.Add(this.btnNo);
            this.pnlQuestion.Controls.Add(this.btnYes);
            this.pnlQuestion.Controls.Add(this.lblQuestionPrompt);
            this.pnlQuestion.Controls.Add(this.lblQuestionBadge);
            this.pnlQuestion.Location = new System.Drawing.Point(25, 100);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(520, 160);
            this.pnlQuestion.TabIndex = 1;
            // 
            // lblQuestionBadge
            // 
            this.lblQuestionBadge.AutoSize = true;
            this.lblQuestionBadge.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.lblQuestionBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblQuestionBadge.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.lblQuestionBadge.Location = new System.Drawing.Point(15, 12);
            this.lblQuestionBadge.Name = "lblQuestionBadge";
            this.lblQuestionBadge.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblQuestionBadge.Size = new System.Drawing.Size(155, 19);
            this.lblQuestionBadge.TabIndex = 0;
            this.lblQuestionBadge.Text = "QUESTION 1 OF AT MOST 3";
            // 
            // lblQuestionPrompt
            // 
            this.lblQuestionPrompt.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblQuestionPrompt.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.lblQuestionPrompt.Location = new System.Drawing.Point(15, 42);
            this.lblQuestionPrompt.Name = "lblQuestionPrompt";
            this.lblQuestionPrompt.Size = new System.Drawing.Size(485, 45);
            this.lblQuestionPrompt.TabIndex = 1;
            this.lblQuestionPrompt.Text = "Does your mushroom have gills?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(19, 100);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(180, 42);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "✔  YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(215, 100);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(180, 42);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "✖  NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.Color.White;
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResult.Controls.Add(this.lblResultMessage);
            this.pnlResult.Controls.Add(this.lblResultStatus);
            this.pnlResult.Location = new System.Drawing.Point(25, 275);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(520, 115);
            this.pnlResult.TabIndex = 2;
            // 
            // lblResultStatus
            // 
            this.lblResultStatus.AutoSize = true;
            this.lblResultStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblResultStatus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblResultStatus.Location = new System.Drawing.Point(15, 10);
            this.lblResultStatus.Name = "lblResultStatus";
            this.lblResultStatus.Size = new System.Drawing.Size(142, 17);
            this.lblResultStatus.TabIndex = 0;
            this.lblResultStatus.Text = "Identification Status:";
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblResultMessage.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.lblResultMessage.Location = new System.Drawing.Point(15, 34);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(485, 68);
            this.lblResultMessage.TabIndex = 1;
            this.lblResultMessage.Text = "Identification in progress. Answer the question above with YES or NO.";
            // 
            // grpRemaining
            // 
            this.grpRemaining.BackColor = System.Drawing.Color.White;
            this.grpRemaining.Controls.Add(this.lblRemainingCount);
            this.grpRemaining.Controls.Add(this.lstRemaining);
            this.grpRemaining.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRemaining.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.grpRemaining.Location = new System.Drawing.Point(560, 100);
            this.grpRemaining.Name = "grpRemaining";
            this.grpRemaining.Size = new System.Drawing.Size(275, 190);
            this.grpRemaining.TabIndex = 3;
            this.grpRemaining.TabStop = false;
            this.grpRemaining.Text = "Candidate Mushrooms";
            // 
            // lstRemaining
            // 
            this.lstRemaining.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.lstRemaining.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstRemaining.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lstRemaining.FormattingEnabled = true;
            this.lstRemaining.ItemHeight = 17;
            this.lstRemaining.Location = new System.Drawing.Point(15, 45);
            this.lstRemaining.Name = "lstRemaining";
            this.lstRemaining.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstRemaining.Size = new System.Drawing.Size(245, 123);
            this.lstRemaining.TabIndex = 0;
            // 
            // lblRemainingCount
            // 
            this.lblRemainingCount.AutoSize = true;
            this.lblRemainingCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRemainingCount.ForeColor = System.Drawing.Color.Gray;
            this.lblRemainingCount.Location = new System.Drawing.Point(15, 23);
            this.lblRemainingCount.Name = "lblRemainingCount";
            this.lblRemainingCount.Size = new System.Drawing.Size(147, 15);
            this.lblRemainingCount.TabIndex = 1;
            this.lblRemainingCount.Text = "6 of 6 candidates remain";
            // 
            // grpHistory
            // 
            this.grpHistory.BackColor = System.Drawing.Color.White;
            this.grpHistory.Controls.Add(this.lstHistory);
            this.grpHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpHistory.ForeColor = System.Drawing.Color.FromArgb(30, 45, 70);
            this.grpHistory.Location = new System.Drawing.Point(560, 300);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(275, 140);
            this.grpHistory.TabIndex = 4;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Answer History";
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.lstHistory.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lstHistory.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 14;
            this.lstHistory.Location = new System.Drawing.Point(15, 25);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstHistory.Size = new System.Drawing.Size(245, 88);
            this.lstHistory.TabIndex = 0;
            // 
            // pnlReference
            // 
            this.pnlReference.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.pnlReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReference.Controls.Add(this.lblRefContent);
            this.pnlReference.Controls.Add(this.lblRefTitle);
            this.pnlReference.Location = new System.Drawing.Point(25, 405);
            this.pnlReference.Name = "pnlReference";
            this.pnlReference.Size = new System.Drawing.Size(520, 85);
            this.pnlReference.TabIndex = 5;
            // 
            // lblRefTitle
            // 
            this.lblRefTitle.AutoSize = true;
            this.lblRefTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRefTitle.ForeColor = System.Drawing.Color.FromArgb(0, 80, 160);
            this.lblRefTitle.Location = new System.Drawing.Point(10, 8);
            this.lblRefTitle.Name = "lblRefTitle";
            this.lblRefTitle.Size = new System.Drawing.Size(211, 15);
            this.lblRefTitle.TabIndex = 0;
            this.lblRefTitle.Text = "Assignment Characteristics Reference:";
            // 
            // lblRefContent
            // 
            this.lblRefContent.AutoSize = true;
            this.lblRefContent.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRefContent.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
            this.lblRefContent.Location = new System.Drawing.Point(10, 27);
            this.lblRefContent.Name = "lblRefContent";
            this.lblRefContent.Size = new System.Drawing.Size(490, 48);
            this.lblRefContent.TabIndex = 1;
            this.lblRefContent.Text = "1. Agaric jaunissant: [Gills: Yes | Forest: No | Ring: Yes | Convex: Yes]\r\n2. Amanite tue-mouche: [Gills: Yes | Forest: Yes | Ring: Yes | Convex: Yes]\r\n3. Cèpe de Bordeaux: [Gills: No | Forest: Yes | Ring: No | Convex: No]\r\n4. Coprin: [Y,N,Y,N] | 5. Girolle: [Y,Y,N,N] | 6. Pied bleu: [Y,Y,N,Y]";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(560, 450);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(275, 40);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "🔄  Restart Identification";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(235, 238, 242);
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnReturn.Location = new System.Drawing.Point(25, 505);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(220, 40);
            this.btnReturn.TabIndex = 7;
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
            this.btnLogout.Location = new System.Drawing.Point(705, 505);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MushroomIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(860, 565);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pnlReference);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpRemaining);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MushroomIdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mushroom Identification - Problem 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MushroomIdForm_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.grpRemaining.ResumeLayout(false);
            this.grpRemaining.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            this.pnlReference.ResumeLayout(false);
            this.pnlReference.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Label lblQuestionBadge;
        private System.Windows.Forms.Label lblQuestionPrompt;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Label lblResultStatus;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.GroupBox grpRemaining;
        private System.Windows.Forms.ListBox lstRemaining;
        private System.Windows.Forms.Label lblRemainingCount;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Panel pnlReference;
        private System.Windows.Forms.Label lblRefTitle;
        private System.Windows.Forms.Label lblRefContent;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogout;
    }
}

