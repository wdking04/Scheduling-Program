namespace WInstonKingC969
{
    partial class MyReports
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
            this.myReportsLbl = new System.Windows.Forms.Label();
            this.appointmentsByMonthBtn = new System.Windows.Forms.Button();
            this.userScheduleBtn = new System.Windows.Forms.Button();
            this.appointmentByCustomerBtn = new System.Windows.Forms.Button();
            this.returnToDashBtn = new System.Windows.Forms.Button();
            this.appointmentReportlbl = new System.Windows.Forms.Label();
            this.scheduleReportlbl = new System.Windows.Forms.Label();
            this.customersReportlbl = new System.Windows.Forms.Label();
            this.myActivityBtn = new System.Windows.Forms.Button();
            this.activityReportLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myReportsLbl
            // 
            this.myReportsLbl.AutoSize = true;
            this.myReportsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myReportsLbl.Location = new System.Drawing.Point(38, 44);
            this.myReportsLbl.Name = "myReportsLbl";
            this.myReportsLbl.Size = new System.Drawing.Size(177, 32);
            this.myReportsLbl.TabIndex = 0;
            this.myReportsLbl.Text = "My Reports:";
            this.myReportsLbl.Click += new System.EventHandler(this.myReportsLbl_Click);
            // 
            // appointmentsByMonthBtn
            // 
            this.appointmentsByMonthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsByMonthBtn.Location = new System.Drawing.Point(33, 109);
            this.appointmentsByMonthBtn.Name = "appointmentsByMonthBtn";
            this.appointmentsByMonthBtn.Size = new System.Drawing.Size(211, 70);
            this.appointmentsByMonthBtn.TabIndex = 0;
            this.appointmentsByMonthBtn.Text = "My Appointments";
            this.appointmentsByMonthBtn.UseVisualStyleBackColor = true;
            this.appointmentsByMonthBtn.Click += new System.EventHandler(this.appointmentsByMonthBtn_Click);
            // 
            // userScheduleBtn
            // 
            this.userScheduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScheduleBtn.Location = new System.Drawing.Point(33, 206);
            this.userScheduleBtn.Name = "userScheduleBtn";
            this.userScheduleBtn.Size = new System.Drawing.Size(211, 70);
            this.userScheduleBtn.TabIndex = 1;
            this.userScheduleBtn.Text = "My Schedule";
            this.userScheduleBtn.UseVisualStyleBackColor = true;
            this.userScheduleBtn.Click += new System.EventHandler(this.userScheduleBtn_Click);
            // 
            // appointmentByCustomerBtn
            // 
            this.appointmentByCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentByCustomerBtn.Location = new System.Drawing.Point(33, 306);
            this.appointmentByCustomerBtn.Name = "appointmentByCustomerBtn";
            this.appointmentByCustomerBtn.Size = new System.Drawing.Size(211, 70);
            this.appointmentByCustomerBtn.TabIndex = 2;
            this.appointmentByCustomerBtn.Text = "My Customers";
            this.appointmentByCustomerBtn.UseVisualStyleBackColor = true;
            this.appointmentByCustomerBtn.Click += new System.EventHandler(this.appointmentByCustomerBtn_Click);
            // 
            // returnToDashBtn
            // 
            this.returnToDashBtn.Location = new System.Drawing.Point(444, 536);
            this.returnToDashBtn.Name = "returnToDashBtn";
            this.returnToDashBtn.Size = new System.Drawing.Size(189, 36);
            this.returnToDashBtn.TabIndex = 4;
            this.returnToDashBtn.Text = "Return to Dashboard";
            this.returnToDashBtn.UseVisualStyleBackColor = true;
            this.returnToDashBtn.Click += new System.EventHandler(this.returnToDashBtn_Click);
            // 
            // appointmentReportlbl
            // 
            this.appointmentReportlbl.AutoSize = true;
            this.appointmentReportlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentReportlbl.Location = new System.Drawing.Point(275, 135);
            this.appointmentReportlbl.Name = "appointmentReportlbl";
            this.appointmentReportlbl.Size = new System.Drawing.Size(315, 20);
            this.appointmentReportlbl.TabIndex = 5;
            this.appointmentReportlbl.Text = "Monthly totals for each type appointment.";
            // 
            // scheduleReportlbl
            // 
            this.scheduleReportlbl.AutoSize = true;
            this.scheduleReportlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleReportlbl.Location = new System.Drawing.Point(275, 235);
            this.scheduleReportlbl.Name = "scheduleReportlbl";
            this.scheduleReportlbl.Size = new System.Drawing.Size(311, 20);
            this.scheduleReportlbl.TabIndex = 6;
            this.scheduleReportlbl.Text = "All user appointment dates, times, types.";
            // 
            // customersReportlbl
            // 
            this.customersReportlbl.AutoSize = true;
            this.customersReportlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersReportlbl.Location = new System.Drawing.Point(275, 335);
            this.customersReportlbl.Name = "customersReportlbl";
            this.customersReportlbl.Size = new System.Drawing.Size(302, 20);
            this.customersReportlbl.TabIndex = 7;
            this.customersReportlbl.Text = "Appointment history for each customer.";
            // 
            // myActivityBtn
            // 
            this.myActivityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myActivityBtn.Location = new System.Drawing.Point(33, 407);
            this.myActivityBtn.Name = "myActivityBtn";
            this.myActivityBtn.Size = new System.Drawing.Size(211, 70);
            this.myActivityBtn.TabIndex = 3;
            this.myActivityBtn.Text = "My Activity";
            this.myActivityBtn.UseVisualStyleBackColor = true;
            this.myActivityBtn.Click += new System.EventHandler(this.myActivityBtn_Click);
            // 
            // activityReportLbl
            // 
            this.activityReportLbl.AutoSize = true;
            this.activityReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityReportLbl.Location = new System.Drawing.Point(279, 433);
            this.activityReportLbl.Name = "activityReportLbl";
            this.activityReportLbl.Size = new System.Drawing.Size(162, 20);
            this.activityReportLbl.TabIndex = 9;
            this.activityReportLbl.Text = "User Log In records.";
            // 
            // MyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 593);
            this.Controls.Add(this.activityReportLbl);
            this.Controls.Add(this.myActivityBtn);
            this.Controls.Add(this.customersReportlbl);
            this.Controls.Add(this.scheduleReportlbl);
            this.Controls.Add(this.appointmentReportlbl);
            this.Controls.Add(this.returnToDashBtn);
            this.Controls.Add(this.appointmentByCustomerBtn);
            this.Controls.Add(this.userScheduleBtn);
            this.Controls.Add(this.appointmentsByMonthBtn);
            this.Controls.Add(this.myReportsLbl);
            this.Name = "MyReports";
            this.Text = "My Reports";
            this.Load += new System.EventHandler(this.MyReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myReportsLbl;
        private System.Windows.Forms.Button appointmentsByMonthBtn;
        private System.Windows.Forms.Button userScheduleBtn;
        private System.Windows.Forms.Button appointmentByCustomerBtn;
        private System.Windows.Forms.Button returnToDashBtn;
        private System.Windows.Forms.Label appointmentReportlbl;
        private System.Windows.Forms.Label scheduleReportlbl;
        private System.Windows.Forms.Label customersReportlbl;
        private System.Windows.Forms.Button myActivityBtn;
        private System.Windows.Forms.Label activityReportLbl;
    }
}