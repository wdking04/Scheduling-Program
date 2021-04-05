namespace WInstonKingC969
{
    partial class UserDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerDgv = new System.Windows.Forms.DataGridView();
            this.appointmentDgv = new System.Windows.Forms.DataGridView();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.udpateAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.deleteApptointmentBtn = new System.Windows.Forms.Button();
            this.myCal = new System.Windows.Forms.MonthCalendar();
            this.weeklyRb = new System.Windows.Forms.RadioButton();
            this.monthlyRb = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.myCustomersLbl1 = new System.Windows.Forms.Label();
            this.myAppointmentsLbl = new System.Windows.Forms.Label();
            this.labelCalender = new System.Windows.Forms.Label();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.dayRb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDgv
            // 
            this.customerDgv.AllowUserToAddRows = false;
            this.customerDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.customerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDgv.ColumnHeadersVisible = false;
            this.customerDgv.EnableHeadersVisualStyles = false;
            this.customerDgv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.customerDgv.Location = new System.Drawing.Point(28, 46);
            this.customerDgv.MultiSelect = false;
            this.customerDgv.Name = "customerDgv";
            this.customerDgv.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.customerDgv.RowHeadersVisible = false;
            this.customerDgv.RowHeadersWidth = 82;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.customerDgv.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.customerDgv.RowTemplate.Height = 33;
            this.customerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDgv.Size = new System.Drawing.Size(542, 200);
            this.customerDgv.TabIndex = 0;
            this.customerDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDgv_CellClick);
            // 
            // appointmentDgv
            // 
            this.appointmentDgv.AllowUserToAddRows = false;
            this.appointmentDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.appointmentDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDgv.EnableHeadersVisualStyles = false;
            this.appointmentDgv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.appointmentDgv.Location = new System.Drawing.Point(27, 355);
            this.appointmentDgv.MultiSelect = false;
            this.appointmentDgv.Name = "appointmentDgv";
            this.appointmentDgv.ReadOnly = true;
            this.appointmentDgv.RowHeadersVisible = false;
            this.appointmentDgv.RowHeadersWidth = 82;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.appointmentDgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.appointmentDgv.RowTemplate.Height = 33;
            this.appointmentDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDgv.Size = new System.Drawing.Size(543, 196);
            this.appointmentDgv.TabIndex = 1;
            this.appointmentDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDgv_CellClick);
            this.appointmentDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDgv_CellContentClick);
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerBtn.Location = new System.Drawing.Point(221, 252);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(95, 36);
            this.updateCustomerBtn.TabIndex = 2;
            this.updateCustomerBtn.Text = "Update";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.Location = new System.Drawing.Point(27, 252);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(72, 36);
            this.addCustomerBtn.TabIndex = 0;
            this.addCustomerBtn.Text = "Add";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerBtn.Location = new System.Drawing.Point(115, 252);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(89, 36);
            this.deleteCustomerBtn.TabIndex = 1;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // udpateAppointmentBtn
            // 
            this.udpateAppointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpateAppointmentBtn.Location = new System.Drawing.Point(221, 557);
            this.udpateAppointmentBtn.Name = "udpateAppointmentBtn";
            this.udpateAppointmentBtn.Size = new System.Drawing.Size(95, 36);
            this.udpateAppointmentBtn.TabIndex = 5;
            this.udpateAppointmentBtn.Text = "Update";
            this.udpateAppointmentBtn.UseVisualStyleBackColor = true;
            this.udpateAppointmentBtn.Click += new System.EventHandler(this.udpateAppointmentBtn_Click);
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentBtn.Location = new System.Drawing.Point(26, 557);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(72, 36);
            this.addAppointmentBtn.TabIndex = 3;
            this.addAppointmentBtn.Text = "Add";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // deleteApptointmentBtn
            // 
            this.deleteApptointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApptointmentBtn.Location = new System.Drawing.Point(115, 557);
            this.deleteApptointmentBtn.Name = "deleteApptointmentBtn";
            this.deleteApptointmentBtn.Size = new System.Drawing.Size(89, 36);
            this.deleteApptointmentBtn.TabIndex = 4;
            this.deleteApptointmentBtn.Text = "Delete";
            this.deleteApptointmentBtn.UseVisualStyleBackColor = true;
            this.deleteApptointmentBtn.Click += new System.EventHandler(this.deleteAppointmentBtn_Click);
            // 
            // myCal
            // 
            this.myCal.BackColor = System.Drawing.SystemColors.Control;
            this.myCal.Location = new System.Drawing.Point(655, 145);
            this.myCal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.myCal.MaximumSize = new System.Drawing.Size(300, 300);
            this.myCal.Name = "myCal";
            this.myCal.TabIndex = 8;
            this.myCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.myCal_DateChanged);
            this.myCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.myCal_DateSelected);
            // 
            // weeklyRb
            // 
            this.weeklyRb.AutoSize = true;
            this.weeklyRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyRb.Location = new System.Drawing.Point(686, 355);
            this.weeklyRb.Name = "weeklyRb";
            this.weeklyRb.Size = new System.Drawing.Size(84, 24);
            this.weeklyRb.TabIndex = 9;
            this.weeklyRb.Text = "Weekly";
            this.weeklyRb.UseVisualStyleBackColor = true;
            this.weeklyRb.CheckedChanged += new System.EventHandler(this.weeklyRb_CheckedChanged);
            // 
            // monthlyRb
            // 
            this.monthlyRb.AutoSize = true;
            this.monthlyRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyRb.Location = new System.Drawing.Point(811, 355);
            this.monthlyRb.Name = "monthlyRb";
            this.monthlyRb.Size = new System.Drawing.Size(88, 24);
            this.monthlyRb.TabIndex = 10;
            this.monthlyRb.Text = "Monthly";
            this.monthlyRb.UseVisualStyleBackColor = true;
            this.monthlyRb.CheckedChanged += new System.EventHandler(this.monthlyRb_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.AllowDrop = true;
            this.exitBtn.BackColor = System.Drawing.Color.Silver;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(878, 576);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 33);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // myCustomersLbl1
            // 
            this.myCustomersLbl1.AutoSize = true;
            this.myCustomersLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCustomersLbl1.Location = new System.Drawing.Point(22, 18);
            this.myCustomersLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myCustomersLbl1.Name = "myCustomersLbl1";
            this.myCustomersLbl1.Size = new System.Drawing.Size(139, 25);
            this.myCustomersLbl1.TabIndex = 13;
            this.myCustomersLbl1.Text = "My Customers";
            // 
            // myAppointmentsLbl
            // 
            this.myAppointmentsLbl.AutoSize = true;
            this.myAppointmentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAppointmentsLbl.Location = new System.Drawing.Point(23, 325);
            this.myAppointmentsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myAppointmentsLbl.Name = "myAppointmentsLbl";
            this.myAppointmentsLbl.Size = new System.Drawing.Size(164, 25);
            this.myAppointmentsLbl.TabIndex = 14;
            this.myAppointmentsLbl.Text = "My Appointments";
            // 
            // labelCalender
            // 
            this.labelCalender.AutoSize = true;
            this.labelCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalender.Location = new System.Drawing.Point(720, 64);
            this.labelCalender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCalender.Name = "labelCalender";
            this.labelCalender.Size = new System.Drawing.Size(135, 25);
            this.labelCalender.TabIndex = 15;
            this.labelCalender.Text = "My Calender";
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Location = new System.Drawing.Point(699, 433);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(196, 85);
            this.reportsBtn.TabIndex = 20;
            this.reportsBtn.Text = "My Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // dayRb
            // 
            this.dayRb.AutoSize = true;
            this.dayRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayRb.Location = new System.Drawing.Point(696, 115);
            this.dayRb.Name = "dayRb";
            this.dayRb.Size = new System.Drawing.Size(182, 24);
            this.dayRb.TabIndex = 21;
            this.dayRb.Text = "Appointments Today";
            this.dayRb.UseVisualStyleBackColor = true;
            this.dayRb.CheckedChanged += new System.EventHandler(this.dayRb_CheckedChanged);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 621);
            this.Controls.Add(this.dayRb);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.labelCalender);
            this.Controls.Add(this.myAppointmentsLbl);
            this.Controls.Add(this.myCustomersLbl1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.monthlyRb);
            this.Controls.Add(this.weeklyRb);
            this.Controls.Add(this.myCal);
            this.Controls.Add(this.deleteApptointmentBtn);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.udpateAppointmentBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.updateCustomerBtn);
            this.Controls.Add(this.appointmentDgv);
            this.Controls.Add(this.customerDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserDashboard";
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDgv;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button udpateAppointmentBtn;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.Button deleteApptointmentBtn;
        private System.Windows.Forms.MonthCalendar myCal;
        private System.Windows.Forms.RadioButton weeklyRb;
        private System.Windows.Forms.RadioButton monthlyRb;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label myCustomersLbl1;
        private System.Windows.Forms.Label myAppointmentsLbl;
        private System.Windows.Forms.Label labelCalender;
        internal System.Windows.Forms.DataGridView appointmentDgv;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.RadioButton dayRb;
    }
}