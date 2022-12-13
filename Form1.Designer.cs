namespace BasicCalculator_ButOnAssemblyMode
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxResults = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lbNum1Err = new System.Windows.Forms.Label();
            this.lbNum2Err = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(12, 53);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(289, 27);
            this.txtBoxNum1.TabIndex = 1;
            this.txtBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxNum1.TextChanged += new System.EventHandler(this.txtBoxNum1_TextChanged);
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(12, 144);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(289, 27);
            this.txtBoxNum2.TabIndex = 3;
            this.txtBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxNum2.TextChanged += new System.EventHandler(this.txtBoxNum2_TextChanged);
            // 
            // txtBoxResults
            // 
            this.txtBoxResults.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxResults.Enabled = false;
            this.txtBoxResults.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtBoxResults.Location = new System.Drawing.Point(22, 188);
            this.txtBoxResults.Multiline = true;
            this.txtBoxResults.Name = "txtBoxResults";
            this.txtBoxResults.Size = new System.Drawing.Size(267, 60);
            this.txtBoxResults.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.ForeColor = System.Drawing.Color.Black;
            this.btnCompute.Location = new System.Drawing.Point(81, 267);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(139, 40);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lbNum1Err
            // 
            this.lbNum1Err.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNum1Err.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbNum1Err.Location = new System.Drawing.Point(307, 36);
            this.lbNum1Err.Name = "lbNum1Err";
            this.lbNum1Err.Size = new System.Drawing.Size(40, 50);
            this.lbNum1Err.TabIndex = 6;
            this.lbNum1Err.Text = "!";
            this.lbNum1Err.Click += new System.EventHandler(this.lbNum1Err_Click);
            // 
            // lbNum2Err
            // 
            this.lbNum2Err.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNum2Err.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbNum2Err.Location = new System.Drawing.Point(307, 127);
            this.lbNum2Err.Name = "lbNum2Err";
            this.lbNum2Err.Size = new System.Drawing.Size(40, 44);
            this.lbNum2Err.TabIndex = 7;
            this.lbNum2Err.Text = "!";
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(12, 95);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(101, 28);
            this.cbOperator.TabIndex = 8;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 319);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.lbNum2Err);
            this.Controls.Add(this.lbNum1Err);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtBoxResults);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBoxNum1;
        private TextBox txtBoxNum2;
        private TextBox txtBoxResults;
        private Button btnCompute;
        private Label lbNum1Err;
        private Label lbNum2Err;
        private ComboBox cbOperator;
    }
}