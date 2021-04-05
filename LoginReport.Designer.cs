namespace WInstonKingC969
{
    partial class LoginReport
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
            this.userLoginlbl = new System.Windows.Forms.Label();
            this.logHistoryTextBox1 = new System.Windows.Forms.RichTextBox();
            this.createReportBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLoginlbl
            // 
            this.userLoginlbl.AutoSize = true;
            this.userLoginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginlbl.Location = new System.Drawing.Point(222, 19);
            this.userLoginlbl.Name = "userLoginlbl";
            this.userLoginlbl.Size = new System.Drawing.Size(177, 25);
            this.userLoginlbl.TabIndex = 0;
            this.userLoginlbl.Text = "User Log In History";
            // 
            // logHistoryTextBox1
            // 
            this.logHistoryTextBox1.Location = new System.Drawing.Point(30, 140);
            this.logHistoryTextBox1.Name = "logHistoryTextBox1";
            this.logHistoryTextBox1.Size = new System.Drawing.Size(567, 222);
            this.logHistoryTextBox1.TabIndex = 1;
            this.logHistoryTextBox1.Text = "";
            this.logHistoryTextBox1.TextChanged += new System.EventHandler(this.logHistoryTextBox1_TextChanged);
            // 
            // createReportBtn
            // 
            this.createReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReportBtn.Location = new System.Drawing.Point(30, 69);
            this.createReportBtn.Name = "createReportBtn";
            this.createReportBtn.Size = new System.Drawing.Size(175, 34);
            this.createReportBtn.TabIndex = 2;
            this.createReportBtn.Text = "Create Report";
            this.createReportBtn.UseVisualStyleBackColor = true;
            this.createReportBtn.Click += new System.EventHandler(this.createReportBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(30, 417);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(122, 39);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // LoginReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 468);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.createReportBtn);
            this.Controls.Add(this.logHistoryTextBox1);
            this.Controls.Add(this.userLoginlbl);
            this.Name = "LoginReport";
            this.Text = "User Login Report";
            this.Load += new System.EventHandler(this.LoginReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLoginlbl;
        private System.Windows.Forms.RichTextBox logHistoryTextBox1;
        private System.Windows.Forms.Button createReportBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}