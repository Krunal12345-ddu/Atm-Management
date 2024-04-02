namespace ATMCLIENTApp
{
    partial class HOME
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.ChangePinTb = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.MiniStatementTb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT YOUR TRANSACTION PLEASE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(3, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 28);
            this.panel2.TabIndex = 1;
            // 
            // DepositBtn
            // 
            this.DepositBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DepositBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.DepositBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepositBtn.Location = new System.Drawing.Point(34, 163);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(206, 70);
            this.DepositBtn.TabIndex = 2;
            this.DepositBtn.Text = "DEPOSIT";
            this.DepositBtn.UseVisualStyleBackColor = false;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // ChangePinTb
            // 
            this.ChangePinTb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChangePinTb.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.ChangePinTb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangePinTb.Location = new System.Drawing.Point(34, 273);
            this.ChangePinTb.Name = "ChangePinTb";
            this.ChangePinTb.Size = new System.Drawing.Size(206, 81);
            this.ChangePinTb.TabIndex = 3;
            this.ChangePinTb.Text = "CHANGE PIN";
            this.ChangePinTb.UseVisualStyleBackColor = false;
            this.ChangePinTb.Click += new System.EventHandler(this.ChangePinTb_Click);
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.WithdrawBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WithdrawBtn.Location = new System.Drawing.Point(525, 163);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(188, 70);
            this.WithdrawBtn.TabIndex = 4;
            this.WithdrawBtn.Text = "WITHDRAW";
            this.WithdrawBtn.UseVisualStyleBackColor = false;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // MiniStatementTb
            // 
            this.MiniStatementTb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MiniStatementTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MiniStatementTb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiniStatementTb.Location = new System.Drawing.Point(278, 355);
            this.MiniStatementTb.Name = "MiniStatementTb";
            this.MiniStatementTb.Size = new System.Drawing.Size(218, 66);
            this.MiniStatementTb.TabIndex = 6;
            this.MiniStatementTb.Text = "MINI STATEMENT";
            this.MiniStatementTb.UseVisualStyleBackColor = false;
            this.MiniStatementTb.Click += new System.EventHandler(this.MiniStatementTb_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(525, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 81);
            this.button2.TabIndex = 8;
            this.button2.Text = "FASTCASH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MiniStatementTb);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.ChangePinTb);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button ChangePinTb;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button MiniStatementTb;
        private System.Windows.Forms.Button button2;
    }
}