namespace WInstonKingC969
{
    partial class AppointmentByCustomerReport
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
            this.appointmentByCustomerDgv = new System.Windows.Forms.DataGridView();
            this.customerReportLbl = new System.Windows.Forms.Label();
            this.customerCB = new System.Windows.Forms.ComboBox();
            this.customerLbl = new System.Windows.Forms.Label();
            this.createReportBtn = new System.Windows.Forms.Button();
            this.returnDashboardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentByCustomerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentByCustomerDgv
            // 
            this.appointmentByCustomerDgv.AllowUserToAddRows = false;
            this.appointmentByCustomerDgv.AllowUserToDeleteRows = false;
            this.appointmentByCustomerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentByCustomerDgv.Location = new System.Drawing.Point(24, 162);
            this.appointmentByCustomerDgv.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentByCustomerDgv.Name = "appointmentByCustomerDgv";
            this.appointmentByCustomerDgv.ReadOnly = true;
            this.appointmentByCustomerDgv.RowHeadersVisible = false;
            this.appointmentByCustomerDgv.RowHeadersWidth = 82;
            this.appointmentByCustomerDgv.RowTemplate.Height = 33;
            this.appointmentByCustomerDgv.Size = new System.Drawing.Size(543, 180);
            this.appointmentByCustomerDgv.TabIndex = 0;
            this.appointmentByCustomerDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentByCustomerDgv_CellContentClick);
            // 
            // customerReportLbl
            // 
            this.customerReportLbl.AutoSize = true;
            this.customerReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerReportLbl.Location = new System.Drawing.Point(168, 9);
            this.customerReportLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerReportLbl.Name = "customerReportLbl";
            this.customerReportLbl.Size = new System.Drawing.Size(249, 25);
            this.customerReportLbl.TabIndex = 1;
            this.customerReportLbl.Text = " Customer Appointments";
            // 
            // customerCB
            // 
            this.customerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCB.FormattingEnabled = true;
            this.customerCB.Location = new System.Drawing.Point(24, 82);
            this.customerCB.Margin = new System.Windows.Forms.Padding(2);
            this.customerCB.Name = "customerCB";
            this.customerCB.Size = new System.Drawing.Size(188, 33);
            this.customerCB.TabIndex = 2;
            this.customerCB.SelectedIndexChanged += new System.EventHandler(this.customerCB_SelectedIndexChanged);
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLbl.Location = new System.Drawing.Point(25, 51);
            this.customerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(134, 20);
            this.customerLbl.TabIndex = 3;
            this.customerLbl.Text = "Select Customer";
            // 
            // createReportBtn
            // 
            this.createReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReportBtn.Location = new System.Drawing.Point(245, 82);
            this.createReportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createReportBtn.Name = "createReportBtn";
            this.createReportBtn.Size = new System.Drawing.Size(141, 33);
            this.createReportBtn.TabIndex = 12;
            this.createReportBtn.Text = "Create Report";
            this.createReportBtn.UseVisualStyleBackColor = true;
            this.createReportBtn.Click += new System.EventHandler(this.createReportBtn_Click);
            // 
            // returnDashboardBtn
            // 
            this.returnDashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDashboardBtn.Location = new System.Drawing.Point(24, 430);
            this.returnDashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnDashboardBtn.Name = "returnDashboardBtn";
            this.returnDashboardBtn.Size = new System.Drawing.Size(141, 36);
            this.returnDashboardBtn.TabIndex = 13;
            this.returnDashboardBtn.Text = "Return";
            this.returnDashboardBtn.UseVisualStyleBackColor = true;
            this.returnDashboardBtn.Click += new System.EventHandler(this.returnDashboardBtn_Click);
            // 
            // AppointmentByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 486);
            this.Controls.Add(this.returnDashboardBtn);
            this.Controls.Add(this.createReportBtn);
            this.Controls.Add(this.customerLbl);
            this.Controls.Add(this.customerCB);
            this.Controls.Add(this.customerReportLbl);
            this.Controls.Add(this.appointmentByCustomerDgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentByCustomer";
            this.Text = "Appointments By Customer Report";
            this.Load += new System.EventHandler(this.AppointmentByCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentByCustomerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentByCustomerDgv;
        private System.Windows.Forms.Label customerReportLbl;
        private System.Windows.Forms.ComboBox customerCB;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.Button createReportBtn;
        private System.Windows.Forms.Button returnDashboardBtn;
    }
}