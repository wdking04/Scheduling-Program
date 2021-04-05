namespace WInstonKingC969
{
    partial class AppointmentByMonthReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.appointmentByMonthDgv = new System.Windows.Forms.DataGridView();
            this.monthReportLbl = new System.Windows.Forms.Label();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.monthLbl = new System.Windows.Forms.Label();
            this.followUpLbl = new System.Windows.Forms.Label();
            this.initialLbl = new System.Windows.Forms.Label();
            this.presentationLbl = new System.Windows.Forms.Label();
            this.scrumLbl = new System.Windows.Forms.Label();
            this.totalAppointmentsLbl = new System.Windows.Forms.Label();
            this.appointmentTypeLbl = new System.Windows.Forms.Label();
            this.createReportBtn = new System.Windows.Forms.Button();
            this.initialCount = new System.Windows.Forms.Label();
            this.followUpCount = new System.Windows.Forms.Label();
            this.presentationCount = new System.Windows.Forms.Label();
            this.scrumCount = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.totalsByTypeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otherCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentByMonthDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentByMonthDgv
            // 
            this.appointmentByMonthDgv.AllowUserToAddRows = false;
            this.appointmentByMonthDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentByMonthDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentByMonthDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentByMonthDgv.ColumnHeadersVisible = false;
            this.appointmentByMonthDgv.Location = new System.Drawing.Point(81, 177);
            this.appointmentByMonthDgv.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentByMonthDgv.Name = "appointmentByMonthDgv";
            this.appointmentByMonthDgv.ReadOnly = true;
            this.appointmentByMonthDgv.RowHeadersVisible = false;
            this.appointmentByMonthDgv.RowHeadersWidth = 82;
            this.appointmentByMonthDgv.RowTemplate.Height = 33;
            this.appointmentByMonthDgv.Size = new System.Drawing.Size(263, 276);
            this.appointmentByMonthDgv.TabIndex = 0;
            this.appointmentByMonthDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentByMonthDgv_CellContentClick);
            // 
            // monthReportLbl
            // 
            this.monthReportLbl.AutoSize = true;
            this.monthReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthReportLbl.Location = new System.Drawing.Point(288, 9);
            this.monthReportLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthReportLbl.Name = "monthReportLbl";
            this.monthReportLbl.Size = new System.Drawing.Size(249, 29);
            this.monthReportLbl.TabIndex = 1;
            this.monthReportLbl.Text = "Monthly Appointments";
            // 
            // monthCB
            // 
            this.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(30, 75);
            this.monthCB.Margin = new System.Windows.Forms.Padding(2);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(162, 33);
            this.monthCB.TabIndex = 2;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.Location = new System.Drawing.Point(31, 42);
            this.monthLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(107, 20);
            this.monthLbl.TabIndex = 3;
            this.monthLbl.Text = "Select Month";
            // 
            // followUpLbl
            // 
            this.followUpLbl.AutoSize = true;
            this.followUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followUpLbl.Location = new System.Drawing.Point(474, 267);
            this.followUpLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.followUpLbl.Name = "followUpLbl";
            this.followUpLbl.Size = new System.Drawing.Size(88, 20);
            this.followUpLbl.TabIndex = 5;
            this.followUpLbl.Text = "Follow Up ";
            this.followUpLbl.Click += new System.EventHandler(this.followUpLbl_Click);
            // 
            // initialLbl
            // 
            this.initialLbl.AutoSize = true;
            this.initialLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialLbl.Location = new System.Drawing.Point(474, 152);
            this.initialLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.initialLbl.Name = "initialLbl";
            this.initialLbl.Size = new System.Drawing.Size(48, 20);
            this.initialLbl.TabIndex = 6;
            this.initialLbl.Text = "Initial";
            this.initialLbl.Click += new System.EventHandler(this.initialLbl_Click);
            // 
            // presentationLbl
            // 
            this.presentationLbl.AutoSize = true;
            this.presentationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationLbl.Location = new System.Drawing.Point(474, 207);
            this.presentationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.presentationLbl.Name = "presentationLbl";
            this.presentationLbl.Size = new System.Drawing.Size(113, 20);
            this.presentationLbl.TabIndex = 7;
            this.presentationLbl.Text = "Presentation  ";
            // 
            // scrumLbl
            // 
            this.scrumLbl.AutoSize = true;
            this.scrumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrumLbl.Location = new System.Drawing.Point(474, 325);
            this.scrumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrumLbl.Name = "scrumLbl";
            this.scrumLbl.Size = new System.Drawing.Size(63, 20);
            this.scrumLbl.TabIndex = 8;
            this.scrumLbl.Text = "Scrum ";
            // 
            // totalAppointmentsLbl
            // 
            this.totalAppointmentsLbl.AutoSize = true;
            this.totalAppointmentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAppointmentsLbl.Location = new System.Drawing.Point(474, 450);
            this.totalAppointmentsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAppointmentsLbl.Name = "totalAppointmentsLbl";
            this.totalAppointmentsLbl.Size = new System.Drawing.Size(177, 24);
            this.totalAppointmentsLbl.TabIndex = 9;
            this.totalAppointmentsLbl.Text = "Total Appointments ";
            // 
            // appointmentTypeLbl
            // 
            this.appointmentTypeLbl.AutoSize = true;
            this.appointmentTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeLbl.Location = new System.Drawing.Point(123, 139);
            this.appointmentTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appointmentTypeLbl.Name = "appointmentTypeLbl";
            this.appointmentTypeLbl.Size = new System.Drawing.Size(170, 24);
            this.appointmentTypeLbl.TabIndex = 10;
            this.appointmentTypeLbl.Text = "Appointment Type:";
            // 
            // createReportBtn
            // 
            this.createReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createReportBtn.Location = new System.Drawing.Point(236, 77);
            this.createReportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createReportBtn.Name = "createReportBtn";
            this.createReportBtn.Size = new System.Drawing.Size(147, 33);
            this.createReportBtn.TabIndex = 11;
            this.createReportBtn.Text = "Create Report";
            this.createReportBtn.UseVisualStyleBackColor = true;
            this.createReportBtn.Click += new System.EventHandler(this.createReportBtn_Click);
            // 
            // initialCount
            // 
            this.initialCount.AutoSize = true;
            this.initialCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialCount.Location = new System.Drawing.Point(650, 152);
            this.initialCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.initialCount.Name = "initialCount";
            this.initialCount.Size = new System.Drawing.Size(0, 24);
            this.initialCount.TabIndex = 12;
            // 
            // followUpCount
            // 
            this.followUpCount.AutoSize = true;
            this.followUpCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followUpCount.Location = new System.Drawing.Point(650, 267);
            this.followUpCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.followUpCount.Name = "followUpCount";
            this.followUpCount.Size = new System.Drawing.Size(0, 24);
            this.followUpCount.TabIndex = 13;
            // 
            // presentationCount
            // 
            this.presentationCount.AutoSize = true;
            this.presentationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationCount.Location = new System.Drawing.Point(650, 207);
            this.presentationCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.presentationCount.Name = "presentationCount";
            this.presentationCount.Size = new System.Drawing.Size(0, 24);
            this.presentationCount.TabIndex = 14;
            // 
            // scrumCount
            // 
            this.scrumCount.AutoSize = true;
            this.scrumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrumCount.Location = new System.Drawing.Point(650, 325);
            this.scrumCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scrumCount.Name = "scrumCount";
            this.scrumCount.Size = new System.Drawing.Size(0, 24);
            this.scrumCount.TabIndex = 15;
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCount.Location = new System.Drawing.Point(700, 450);
            this.totalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(0, 24);
            this.totalCount.TabIndex = 16;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Location = new System.Drawing.Point(29, 512);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(151, 33);
            this.dashboardBtn.TabIndex = 17;
            this.dashboardBtn.Text = "Return";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // totalsByTypeLbl
            // 
            this.totalsByTypeLbl.AutoSize = true;
            this.totalsByTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsByTypeLbl.Location = new System.Drawing.Point(474, 86);
            this.totalsByTypeLbl.Name = "totalsByTypeLbl";
            this.totalsByTypeLbl.Size = new System.Drawing.Size(138, 24);
            this.totalsByTypeLbl.TabIndex = 18;
            this.totalsByTypeLbl.Text = "Totals by Type:";
            this.totalsByTypeLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // myReportsLbl
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 379);
            this.label1.Name = "myReportsLbl";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Other";
            // 
            // otherCount
            // 
            this.otherCount.AutoSize = true;
            this.otherCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherCount.Location = new System.Drawing.Point(650, 379);
            this.otherCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.otherCount.Name = "otherCount";
            this.otherCount.Size = new System.Drawing.Size(0, 24);
            this.otherCount.TabIndex = 20;
            // 
            // ApptByMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(807, 556);
            this.Controls.Add(this.otherCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalsByTypeLbl);
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.scrumCount);
            this.Controls.Add(this.presentationCount);
            this.Controls.Add(this.followUpCount);
            this.Controls.Add(this.initialCount);
            this.Controls.Add(this.createReportBtn);
            this.Controls.Add(this.appointmentTypeLbl);
            this.Controls.Add(this.totalAppointmentsLbl);
            this.Controls.Add(this.scrumLbl);
            this.Controls.Add(this.presentationLbl);
            this.Controls.Add(this.initialLbl);
            this.Controls.Add(this.followUpLbl);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.monthReportLbl);
            this.Controls.Add(this.appointmentByMonthDgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentByMonthReport";
            this.Text = "Appointment Types By Month Report";
            this.Load += new System.EventHandler(this.AppointmentByMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentByMonthDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentByMonthDgv;
        private System.Windows.Forms.Label monthReportLbl;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label followUpLbl;
        private System.Windows.Forms.Label initialLbl;
        private System.Windows.Forms.Label presentationLbl;
        private System.Windows.Forms.Label scrumLbl;
        private System.Windows.Forms.Label totalAppointmentsLbl;
        private System.Windows.Forms.Label appointmentTypeLbl;
        private System.Windows.Forms.Button createReportBtn;
        private System.Windows.Forms.Label initialCount;
        private System.Windows.Forms.Label followUpCount;
        private System.Windows.Forms.Label presentationCount;
        private System.Windows.Forms.Label scrumCount;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Label totalsByTypeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label otherCount;
    }
}