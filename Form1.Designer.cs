namespace FongP4BankAccount
{
    partial class BankAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountTab = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBInterstRate = new System.Windows.Forms.TextBox();
            this.txtBATMPin = new System.Windows.Forms.TextBox();
            this.txtBATMAcctNum = new System.Windows.Forms.TextBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.comBAcctType = new System.Windows.Forms.ComboBox();
            this.lblPercentRate = new System.Windows.Forms.Label();
            this.lblATMPin = new System.Windows.Forms.Label();
            this.lblATMAcctNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DepositWithdrawTab = new System.Windows.Forms.TabPage();
            this.txtBTransactions = new System.Windows.Forms.TextBox();
            this.btnProcessTrans = new System.Windows.Forms.Button();
            this.rdBWithdraw = new System.Windows.Forms.RadioButton();
            this.rdBDeposit = new System.Windows.Forms.RadioButton();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtBAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.correctEntryStatus = new System.Windows.Forms.Label();
            this.IncorrectEntry = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.accountTab.SuspendLayout();
            this.DepositWithdrawTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.welcomeTab);
            this.tabControl.Controls.Add(this.accountTab);
            this.tabControl.Controls.Add(this.DepositWithdrawTab);
            this.tabControl.Location = new System.Drawing.Point(7, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(686, 444);
            this.tabControl.TabIndex = 0;
            // 
            // welcomeTab
            // 
            this.welcomeTab.Controls.Add(this.pictureBox1);
            this.welcomeTab.Controls.Add(this.label2);
            this.welcomeTab.Controls.Add(this.label1);
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(678, 418);
            this.welcomeTab.TabIndex = 0;
            this.welcomeTab.Text = "Welcome";
            this.welcomeTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FongP4BankAccount.Properties.Resources._2018_01_bank;
            this.pictureBox1.Location = new System.Drawing.Point(199, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(142, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome To The C# Banking Center";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "C# Banking Center";
            // 
            // accountTab
            // 
            this.accountTab.Controls.Add(this.IncorrectEntry);
            this.accountTab.Controls.Add(this.correctEntryStatus);
            this.accountTab.Controls.Add(this.txtAccountNum);
            this.accountTab.Controls.Add(this.lblAcctNum);
            this.accountTab.Controls.Add(this.btnUpdate);
            this.accountTab.Controls.Add(this.txtBInterstRate);
            this.accountTab.Controls.Add(this.txtBATMPin);
            this.accountTab.Controls.Add(this.txtBATMAcctNum);
            this.accountTab.Controls.Add(this.txtBName);
            this.accountTab.Controls.Add(this.comBAcctType);
            this.accountTab.Controls.Add(this.lblPercentRate);
            this.accountTab.Controls.Add(this.lblATMPin);
            this.accountTab.Controls.Add(this.lblATMAcctNum);
            this.accountTab.Controls.Add(this.label4);
            this.accountTab.Controls.Add(this.label3);
            this.accountTab.Location = new System.Drawing.Point(4, 22);
            this.accountTab.Name = "accountTab";
            this.accountTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountTab.Size = new System.Drawing.Size(678, 418);
            this.accountTab.TabIndex = 1;
            this.accountTab.Text = "Account";
            this.accountTab.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(211, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 33);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBInterstRate
            // 
            this.txtBInterstRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBInterstRate.Location = new System.Drawing.Point(278, 215);
            this.txtBInterstRate.Name = "txtBInterstRate";
            this.txtBInterstRate.Size = new System.Drawing.Size(213, 26);
            this.txtBInterstRate.TabIndex = 5;
            this.txtBInterstRate.Visible = false;
            // 
            // txtBATMPin
            // 
            this.txtBATMPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBATMPin.Location = new System.Drawing.Point(278, 181);
            this.txtBATMPin.Name = "txtBATMPin";
            this.txtBATMPin.Size = new System.Drawing.Size(213, 26);
            this.txtBATMPin.TabIndex = 4;
            this.txtBATMPin.Visible = false;
            // 
            // txtBATMAcctNum
            // 
            this.txtBATMAcctNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBATMAcctNum.Location = new System.Drawing.Point(278, 147);
            this.txtBATMAcctNum.Name = "txtBATMAcctNum";
            this.txtBATMAcctNum.Size = new System.Drawing.Size(213, 26);
            this.txtBATMAcctNum.TabIndex = 3;
            this.txtBATMAcctNum.Visible = false;
            // 
            // txtBName
            // 
            this.txtBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(278, 83);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(213, 26);
            this.txtBName.TabIndex = 1;
            // 
            // comBAcctType
            // 
            this.comBAcctType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBAcctType.FormattingEnabled = true;
            this.comBAcctType.Items.AddRange(new object[] {
            "SavingAcct",
            "SilverAcct",
            "GoldAcct"});
            this.comBAcctType.Location = new System.Drawing.Point(278, 49);
            this.comBAcctType.Name = "comBAcctType";
            this.comBAcctType.Size = new System.Drawing.Size(213, 28);
            this.comBAcctType.TabIndex = 0;
            this.comBAcctType.Text = "SavingAcct";
            this.comBAcctType.SelectedIndexChanged += new System.EventHandler(this.comBAcctType_SelectedIndexChanged);
            // 
            // lblPercentRate
            // 
            this.lblPercentRate.AutoSize = true;
            this.lblPercentRate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentRate.Location = new System.Drawing.Point(44, 219);
            this.lblPercentRate.Name = "lblPercentRate";
            this.lblPercentRate.Size = new System.Drawing.Size(221, 18);
            this.lblPercentRate.TabIndex = 4;
            this.lblPercentRate.Text = "Percent Rate in Percent (5%)";
            this.lblPercentRate.Visible = false;
            // 
            // lblATMPin
            // 
            this.lblATMPin.AutoSize = true;
            this.lblATMPin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMPin.Location = new System.Drawing.Point(44, 185);
            this.lblATMPin.Name = "lblATMPin";
            this.lblATMPin.Size = new System.Drawing.Size(83, 18);
            this.lblATMPin.TabIndex = 3;
            this.lblATMPin.Text = "ATM PIN";
            this.lblATMPin.Visible = false;
            // 
            // lblATMAcctNum
            // 
            this.lblATMAcctNum.AutoSize = true;
            this.lblATMAcctNum.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATMAcctNum.Location = new System.Drawing.Point(44, 151);
            this.lblATMAcctNum.Name = "lblATMAcctNum";
            this.lblATMAcctNum.Size = new System.Drawing.Size(151, 18);
            this.lblATMAcctNum.TabIndex = 2;
            this.lblATMAcctNum.Text = "ATM Account Num";
            this.lblATMAcctNum.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Acct Type";
            // 
            // DepositWithdrawTab
            // 
            this.DepositWithdrawTab.Controls.Add(this.btnClear);
            this.DepositWithdrawTab.Controls.Add(this.txtBTransactions);
            this.DepositWithdrawTab.Controls.Add(this.btnProcessTrans);
            this.DepositWithdrawTab.Controls.Add(this.rdBWithdraw);
            this.DepositWithdrawTab.Controls.Add(this.rdBDeposit);
            this.DepositWithdrawTab.Controls.Add(this.txtResults);
            this.DepositWithdrawTab.Controls.Add(this.txtBAmount);
            this.DepositWithdrawTab.Controls.Add(this.label9);
            this.DepositWithdrawTab.Controls.Add(this.label8);
            this.DepositWithdrawTab.Location = new System.Drawing.Point(4, 22);
            this.DepositWithdrawTab.Name = "DepositWithdrawTab";
            this.DepositWithdrawTab.Padding = new System.Windows.Forms.Padding(3);
            this.DepositWithdrawTab.Size = new System.Drawing.Size(678, 418);
            this.DepositWithdrawTab.TabIndex = 2;
            this.DepositWithdrawTab.Text = "Deposit/Withdraw";
            this.DepositWithdrawTab.UseVisualStyleBackColor = true;
            // 
            // txtBTransactions
            // 
            this.txtBTransactions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBTransactions.Location = new System.Drawing.Point(367, 6);
            this.txtBTransactions.Multiline = true;
            this.txtBTransactions.Name = "txtBTransactions";
            this.txtBTransactions.ReadOnly = true;
            this.txtBTransactions.Size = new System.Drawing.Size(305, 406);
            this.txtBTransactions.TabIndex = 7;
            // 
            // btnProcessTrans
            // 
            this.btnProcessTrans.BackColor = System.Drawing.Color.Azure;
            this.btnProcessTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessTrans.Location = new System.Drawing.Point(116, 105);
            this.btnProcessTrans.Name = "btnProcessTrans";
            this.btnProcessTrans.Size = new System.Drawing.Size(230, 31);
            this.btnProcessTrans.TabIndex = 6;
            this.btnProcessTrans.Text = "Process Transaction";
            this.btnProcessTrans.UseVisualStyleBackColor = false;
            this.btnProcessTrans.Click += new System.EventHandler(this.btnProcessTrans_Click);
            // 
            // rdBWithdraw
            // 
            this.rdBWithdraw.AutoSize = true;
            this.rdBWithdraw.Checked = true;
            this.rdBWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBWithdraw.Location = new System.Drawing.Point(241, 66);
            this.rdBWithdraw.Name = "rdBWithdraw";
            this.rdBWithdraw.Size = new System.Drawing.Size(89, 20);
            this.rdBWithdraw.TabIndex = 5;
            this.rdBWithdraw.TabStop = true;
            this.rdBWithdraw.Text = "Withdraw";
            this.rdBWithdraw.UseVisualStyleBackColor = true;
            // 
            // rdBDeposit
            // 
            this.rdBDeposit.AutoSize = true;
            this.rdBDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBDeposit.Location = new System.Drawing.Point(150, 66);
            this.rdBDeposit.Name = "rdBDeposit";
            this.rdBDeposit.Size = new System.Drawing.Size(80, 20);
            this.rdBDeposit.TabIndex = 4;
            this.rdBDeposit.Text = "Deposit";
            this.rdBDeposit.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(116, 186);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(230, 99);
            this.txtResults.TabIndex = 3;
            // 
            // txtBAmount
            // 
            this.txtBAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAmount.Location = new System.Drawing.Point(116, 29);
            this.txtBAmount.Name = "txtBAmount";
            this.txtBAmount.Size = new System.Drawing.Size(230, 26);
            this.txtBAmount.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Amount";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(170, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 26);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNum.Location = new System.Drawing.Point(44, 119);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(107, 18);
            this.lblAcctNum.TabIndex = 11;
            this.lblAcctNum.Text = "Account Num";
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.Location = new System.Drawing.Point(278, 115);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(213, 26);
            this.txtAccountNum.TabIndex = 2;
            // 
            // correctEntryStatus
            // 
            this.correctEntryStatus.AutoSize = true;
            this.correctEntryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctEntryStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.correctEntryStatus.Location = new System.Drawing.Point(166, 336);
            this.correctEntryStatus.Name = "correctEntryStatus";
            this.correctEntryStatus.Size = new System.Drawing.Size(0, 13);
            this.correctEntryStatus.TabIndex = 12;
            this.correctEntryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.correctEntryStatus.Visible = false;
            // 
            // IncorrectEntry
            // 
            this.IncorrectEntry.AutoSize = true;
            this.IncorrectEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectEntry.ForeColor = System.Drawing.Color.Red;
            this.IncorrectEntry.Location = new System.Drawing.Point(181, 337);
            this.IncorrectEntry.Name = "IncorrectEntry";
            this.IncorrectEntry.Size = new System.Drawing.Size(0, 13);
            this.IncorrectEntry.TabIndex = 13;
            this.IncorrectEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IncorrectEntry.Visible = false;
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankAccountForm";
            this.Text = " Edward Fong efong@cnm.edu - BANKING ACCOUNT SIMULATION";
            this.tabControl.ResumeLayout(false);
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.accountTab.ResumeLayout(false);
            this.accountTab.PerformLayout();
            this.DepositWithdrawTab.ResumeLayout(false);
            this.DepositWithdrawTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.TabPage accountTab;
        private System.Windows.Forms.TabPage DepositWithdrawTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBAcctType;
        private System.Windows.Forms.Label lblPercentRate;
        private System.Windows.Forms.Label lblATMPin;
        private System.Windows.Forms.Label lblATMAcctNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBInterstRate;
        private System.Windows.Forms.TextBox txtBATMPin;
        private System.Windows.Forms.TextBox txtBATMAcctNum;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBTransactions;
        private System.Windows.Forms.Button btnProcessTrans;
        private System.Windows.Forms.RadioButton rdBWithdraw;
        private System.Windows.Forms.RadioButton rdBDeposit;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtBAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label lblAcctNum;
        private System.Windows.Forms.Label IncorrectEntry;
        private System.Windows.Forms.Label correctEntryStatus;
    }
}

