namespace LoanCalculator
{
    partial class frmMain
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
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanPeriod = new System.Windows.Forms.TextBox();
            this.lblPaymentSummary = new System.Windows.Forms.Label();
            this.lstPaymentSchedule = new System.Windows.Forms.ListView();
            this.colPaymentNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaymentAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrincipalPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInterestPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoanBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPaymentSummary = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.rdoPeriodMonth = new System.Windows.Forms.RadioButton();
            this.rdoPeriodYears = new System.Windows.Forms.RadioButton();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportSchedule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(17, 22);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(70, 13);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "Loan Amount";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(357, 24);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(121, 13);
            this.lblInterestRate.TabIndex = 1;
            this.lblInterestRate.Text = "Annual Interest Rate (%)";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(20, 38);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(163, 20);
            this.txtLoanAmount.TabIndex = 3;
            // 
            // txtAnnualInterestRate
            // 
            this.txtAnnualInterestRate.Location = new System.Drawing.Point(360, 40);
            this.txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            this.txtAnnualInterestRate.Size = new System.Drawing.Size(167, 20);
            this.txtAnnualInterestRate.TabIndex = 4;
            // 
            // txtLoanPeriod
            // 
            this.txtLoanPeriod.Location = new System.Drawing.Point(9, 17);
            this.txtLoanPeriod.Name = "txtLoanPeriod";
            this.txtLoanPeriod.Size = new System.Drawing.Size(163, 20);
            this.txtLoanPeriod.TabIndex = 5;
            // 
            // lblPaymentSummary
            // 
            this.lblPaymentSummary.AutoSize = true;
            this.lblPaymentSummary.Location = new System.Drawing.Point(18, 156);
            this.lblPaymentSummary.Name = "lblPaymentSummary";
            this.lblPaymentSummary.Size = new System.Drawing.Size(99, 13);
            this.lblPaymentSummary.TabIndex = 6;
            this.lblPaymentSummary.Text = "Payments Summary";
            // 
            // lstPaymentSchedule
            // 
            this.lstPaymentSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPaymentNo,
            this.colPaymentAmount,
            this.colPrincipalPaid,
            this.colInterestPaid,
            this.colLoanBalance});
            this.lstPaymentSchedule.FullRowSelect = true;
            this.lstPaymentSchedule.GridLines = true;
            this.lstPaymentSchedule.Location = new System.Drawing.Point(20, 256);
            this.lstPaymentSchedule.Name = "lstPaymentSchedule";
            this.lstPaymentSchedule.Size = new System.Drawing.Size(507, 382);
            this.lstPaymentSchedule.TabIndex = 7;
            this.lstPaymentSchedule.UseCompatibleStateImageBehavior = false;
            this.lstPaymentSchedule.View = System.Windows.Forms.View.Details;
            // 
            // colPaymentNo
            // 
            this.colPaymentNo.Text = "Payment No";
            this.colPaymentNo.Width = 81;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.Text = "Payment Amount";
            this.colPaymentAmount.Width = 111;
            // 
            // colPrincipalPaid
            // 
            this.colPrincipalPaid.Text = "Principal Paid";
            this.colPrincipalPaid.Width = 91;
            // 
            // colInterestPaid
            // 
            this.colInterestPaid.Text = "Interest Paid";
            this.colInterestPaid.Width = 101;
            // 
            // colLoanBalance
            // 
            this.colLoanBalance.Text = "Loan Balance";
            this.colLoanBalance.Width = 118;
            // 
            // txtPaymentSummary
            // 
            this.txtPaymentSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPaymentSummary.Location = new System.Drawing.Point(20, 172);
            this.txtPaymentSummary.Multiline = true;
            this.txtPaymentSummary.Name = "txtPaymentSummary";
            this.txtPaymentSummary.ReadOnly = true;
            this.txtPaymentSummary.Size = new System.Drawing.Size(507, 49);
            this.txtPaymentSummary.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(360, 68);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(167, 26);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Payments";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(360, 127);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(167, 26);
            this.btnResetForm.TabIndex = 10;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // rdoPeriodMonth
            // 
            this.rdoPeriodMonth.AutoSize = true;
            this.rdoPeriodMonth.Location = new System.Drawing.Point(9, 41);
            this.rdoPeriodMonth.Name = "rdoPeriodMonth";
            this.rdoPeriodMonth.Size = new System.Drawing.Size(60, 17);
            this.rdoPeriodMonth.TabIndex = 11;
            this.rdoPeriodMonth.Text = "Months";
            this.rdoPeriodMonth.UseVisualStyleBackColor = true;
            // 
            // rdoPeriodYears
            // 
            this.rdoPeriodYears.AutoSize = true;
            this.rdoPeriodYears.Checked = true;
            this.rdoPeriodYears.Location = new System.Drawing.Point(93, 41);
            this.rdoPeriodYears.Name = "rdoPeriodYears";
            this.rdoPeriodYears.Size = new System.Drawing.Size(52, 17);
            this.rdoPeriodYears.TabIndex = 12;
            this.rdoPeriodYears.TabStop = true;
            this.rdoPeriodYears.Text = "Years";
            this.rdoPeriodYears.UseVisualStyleBackColor = true;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(19, 237);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(139, 13);
            this.lblSchedule.TabIndex = 13;
            this.lblSchedule.Text = "Loan Amortization Schedule";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPeriodMonth);
            this.groupBox1.Controls.Add(this.rdoPeriodYears);
            this.groupBox1.Controls.Add(this.txtLoanPeriod);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 61);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Period";
            // 
            // btnExportSchedule
            // 
            this.btnExportSchedule.Location = new System.Drawing.Point(361, 97);
            this.btnExportSchedule.Name = "btnExportSchedule";
            this.btnExportSchedule.Size = new System.Drawing.Size(167, 26);
            this.btnExportSchedule.TabIndex = 15;
            this.btnExportSchedule.Text = "Export Schedule (Excel)";
            this.btnExportSchedule.UseVisualStyleBackColor = true;
            this.btnExportSchedule.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 655);
            this.Controls.Add(this.btnExportSchedule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPaymentSummary);
            this.Controls.Add(this.lstPaymentSchedule);
            this.Controls.Add(this.lblPaymentSummary);
            this.Controls.Add(this.txtAnnualInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Loan Calculator - Oliver Sargeant ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtAnnualInterestRate;
        private System.Windows.Forms.TextBox txtLoanPeriod;
        private System.Windows.Forms.Label lblPaymentSummary;
        private System.Windows.Forms.ListView lstPaymentSchedule;
        private System.Windows.Forms.ColumnHeader colPaymentNo;
        private System.Windows.Forms.ColumnHeader colPaymentAmount;
        private System.Windows.Forms.ColumnHeader colPrincipalPaid;
        private System.Windows.Forms.ColumnHeader colInterestPaid;
        private System.Windows.Forms.ColumnHeader colLoanBalance;
        private System.Windows.Forms.TextBox txtPaymentSummary;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.RadioButton rdoPeriodMonth;
        private System.Windows.Forms.RadioButton rdoPeriodYears;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportSchedule;
    }
}

