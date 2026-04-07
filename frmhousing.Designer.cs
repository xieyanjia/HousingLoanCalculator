namespace housing_web
{
    partial class frmhousing
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblDownPaymentPercent = new System.Windows.Forms.Label();
            this.lblAnnualRate = new System.Windows.Forms.Label();
            this.lblLoanYears = new System.Windows.Forms.Label();
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentPercent = new System.Windows.Forms.TextBox();
            this.txtAnnualRate = new System.Windows.Forms.TextBox();
            this.txtLoanYears = new System.Windows.Forms.TextBox();
            this.lblGraceYears = new System.Windows.Forms.Label();
            this.txtGraceYears = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLoanAmountResult = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentResult = new System.Windows.Forms.Label();
            this.lblFirstInterestResult = new System.Windows.Forms.Label();
            this.lblFirstPrincipalResult = new System.Windows.Forms.Label();
            this.lblTotalInterestResult = new System.Windows.Forms.Label();
            this.lblTotalRepaymentResult = new System.Windows.Forms.Label();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResult
            // 
            this.grpResult.BackColor = System.Drawing.Color.Pink;
            this.grpResult.Controls.Add(this.lblTotalRepaymentResult);
            this.grpResult.Controls.Add(this.lblTotalInterestResult);
            this.grpResult.Controls.Add(this.lblFirstPrincipalResult);
            this.grpResult.Controls.Add(this.lblFirstInterestResult);
            this.grpResult.Controls.Add(this.lblMonthlyPaymentResult);
            this.grpResult.Controls.Add(this.lblLoanAmountResult);
            this.grpResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpResult.Location = new System.Drawing.Point(44, 370);
            this.grpResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResult.Name = "grpResult";
            this.grpResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResult.Size = new System.Drawing.Size(745, 306);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "試算結果";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(329, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "個人房貸試算器";
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.AutoSize = true;
            this.lblHousePrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHousePrice.Location = new System.Drawing.Point(81, 99);
            this.lblHousePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.Size = new System.Drawing.Size(121, 20);
            this.lblHousePrice.TabIndex = 2;
            this.lblHousePrice.Text = "房屋總價（元）";
            // 
            // lblDownPaymentPercent
            // 
            this.lblDownPaymentPercent.AutoSize = true;
            this.lblDownPaymentPercent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDownPaymentPercent.Location = new System.Drawing.Point(81, 145);
            this.lblDownPaymentPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownPaymentPercent.Name = "lblDownPaymentPercent";
            this.lblDownPaymentPercent.Size = new System.Drawing.Size(135, 20);
            this.lblDownPaymentPercent.TabIndex = 3;
            this.lblDownPaymentPercent.Text = "自備款比例（%）";
            // 
            // lblAnnualRate
            // 
            this.lblAnnualRate.AutoSize = true;
            this.lblAnnualRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAnnualRate.Location = new System.Drawing.Point(81, 193);
            this.lblAnnualRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnualRate.Name = "lblAnnualRate";
            this.lblAnnualRate.Size = new System.Drawing.Size(119, 20);
            this.lblAnnualRate.TabIndex = 4;
            this.lblAnnualRate.Text = "貸款利率（%）";
            // 
            // lblLoanYears
            // 
            this.lblLoanYears.AutoSize = true;
            this.lblLoanYears.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanYears.Location = new System.Drawing.Point(81, 236);
            this.lblLoanYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanYears.Name = "lblLoanYears";
            this.lblLoanYears.Size = new System.Drawing.Size(121, 20);
            this.lblLoanYears.TabIndex = 5;
            this.lblLoanYears.Text = "貸款年限（年）";
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHousePrice.Location = new System.Drawing.Point(269, 96);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(228, 29);
            this.txtHousePrice.TabIndex = 6;
            this.txtHousePrice.Text = "15000000";
            this.txtHousePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDownPaymentPercent
            // 
            this.txtDownPaymentPercent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPaymentPercent.Location = new System.Drawing.Point(269, 136);
            this.txtDownPaymentPercent.Name = "txtDownPaymentPercent";
            this.txtDownPaymentPercent.Size = new System.Drawing.Size(228, 29);
            this.txtDownPaymentPercent.TabIndex = 7;
            this.txtDownPaymentPercent.Text = "20";
            this.txtDownPaymentPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnnualRate
            // 
            this.txtAnnualRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAnnualRate.Location = new System.Drawing.Point(269, 184);
            this.txtAnnualRate.Name = "txtAnnualRate";
            this.txtAnnualRate.Size = new System.Drawing.Size(228, 29);
            this.txtAnnualRate.TabIndex = 8;
            this.txtAnnualRate.Text = "2.15";
            this.txtAnnualRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoanYears
            // 
            this.txtLoanYears.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanYears.Location = new System.Drawing.Point(269, 233);
            this.txtLoanYears.Name = "txtLoanYears";
            this.txtLoanYears.Size = new System.Drawing.Size(228, 29);
            this.txtLoanYears.TabIndex = 9;
            this.txtLoanYears.Text = "30";
            this.txtLoanYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGraceYears
            // 
            this.lblGraceYears.AutoSize = true;
            this.lblGraceYears.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGraceYears.Location = new System.Drawing.Point(81, 288);
            this.lblGraceYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGraceYears.Name = "lblGraceYears";
            this.lblGraceYears.Size = new System.Drawing.Size(166, 20);
            this.lblGraceYears.TabIndex = 10;
            this.lblGraceYears.Text = "寬限期（年，可填 0）";
            // 
            // txtGraceYears
            // 
            this.txtGraceYears.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGraceYears.Location = new System.Drawing.Point(269, 279);
            this.txtGraceYears.Name = "txtGraceYears";
            this.txtGraceYears.Size = new System.Drawing.Size(228, 29);
            this.txtGraceYears.TabIndex = 11;
            this.txtGraceYears.Text = "0";
            this.txtGraceYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Orange;
            this.btnCalculate.Location = new System.Drawing.Point(584, 99);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 77);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "開始計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.Location = new System.Drawing.Point(584, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 77);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLoanAmountResult
            // 
            this.lblLoanAmountResult.AutoSize = true;
            this.lblLoanAmountResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanAmountResult.Location = new System.Drawing.Point(37, 39);
            this.lblLoanAmountResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanAmountResult.Name = "lblLoanAmountResult";
            this.lblLoanAmountResult.Size = new System.Drawing.Size(105, 20);
            this.lblLoanAmountResult.TabIndex = 14;
            this.lblLoanAmountResult.Text = "貸款總金額：";
            // 
            // lblMonthlyPaymentResult
            // 
            this.lblMonthlyPaymentResult.AutoSize = true;
            this.lblMonthlyPaymentResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyPaymentResult.Location = new System.Drawing.Point(37, 76);
            this.lblMonthlyPaymentResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyPaymentResult.Name = "lblMonthlyPaymentResult";
            this.lblMonthlyPaymentResult.Size = new System.Drawing.Size(121, 20);
            this.lblMonthlyPaymentResult.TabIndex = 15;
            this.lblMonthlyPaymentResult.Text = "每月應繳金額：";
            // 
            // lblFirstInterestResult
            // 
            this.lblFirstInterestResult.AutoSize = true;
            this.lblFirstInterestResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInterestResult.Location = new System.Drawing.Point(37, 113);
            this.lblFirstInterestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstInterestResult.Name = "lblFirstInterestResult";
            this.lblFirstInterestResult.Size = new System.Drawing.Size(89, 20);
            this.lblFirstInterestResult.TabIndex = 16;
            this.lblFirstInterestResult.Text = "首期利息：";
            // 
            // lblFirstPrincipalResult
            // 
            this.lblFirstPrincipalResult.AutoSize = true;
            this.lblFirstPrincipalResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstPrincipalResult.Location = new System.Drawing.Point(37, 151);
            this.lblFirstPrincipalResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstPrincipalResult.Name = "lblFirstPrincipalResult";
            this.lblFirstPrincipalResult.Size = new System.Drawing.Size(89, 20);
            this.lblFirstPrincipalResult.TabIndex = 17;
            this.lblFirstPrincipalResult.Text = "首期本金：";
            // 
            // lblTotalInterestResult
            // 
            this.lblTotalInterestResult.AutoSize = true;
            this.lblTotalInterestResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalInterestResult.Location = new System.Drawing.Point(37, 187);
            this.lblTotalInterestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInterestResult.Name = "lblTotalInterestResult";
            this.lblTotalInterestResult.Size = new System.Drawing.Size(105, 20);
            this.lblTotalInterestResult.TabIndex = 18;
            this.lblTotalInterestResult.Text = "總利息支出：";
            // 
            // lblTotalRepaymentResult
            // 
            this.lblTotalRepaymentResult.AutoSize = true;
            this.lblTotalRepaymentResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalRepaymentResult.Location = new System.Drawing.Point(37, 224);
            this.lblTotalRepaymentResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRepaymentResult.Name = "lblTotalRepaymentResult";
            this.lblTotalRepaymentResult.Size = new System.Drawing.Size(105, 20);
            this.lblTotalRepaymentResult.TabIndex = 19;
            this.lblTotalRepaymentResult.Text = "總還款金額：";
            // 
            // frmhousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 795);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGraceYears);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDownPaymentPercent);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.lblGraceYears);
            this.Controls.Add(this.txtAnnualRate);
            this.Controls.Add(this.lblHousePrice);
            this.Controls.Add(this.txtHousePrice);
            this.Controls.Add(this.txtLoanYears);
            this.Controls.Add(this.lblLoanYears);
            this.Controls.Add(this.lblDownPaymentPercent);
            this.Controls.Add(this.lblAnnualRate);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmhousing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblDownPaymentPercent;
        private System.Windows.Forms.Label lblAnnualRate;
        private System.Windows.Forms.Label lblLoanYears;
        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownPaymentPercent;
        private System.Windows.Forms.TextBox txtAnnualRate;
        private System.Windows.Forms.TextBox txtLoanYears;
        private System.Windows.Forms.Label lblGraceYears;
        private System.Windows.Forms.TextBox txtGraceYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLoanAmountResult;
        private System.Windows.Forms.Label lblTotalRepaymentResult;
        private System.Windows.Forms.Label lblTotalInterestResult;
        private System.Windows.Forms.Label lblFirstPrincipalResult;
        private System.Windows.Forms.Label lblFirstInterestResult;
        private System.Windows.Forms.Label lblMonthlyPaymentResult;
    }
}

