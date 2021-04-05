namespace WInstonKingC969
{
    partial class AddUpdateAppointmentForm
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
            this.appointmentEndTxt = new System.Windows.Forms.RichTextBox();
            this.appointmentCustomerNameLbl = new System.Windows.Forms.Label();
            this.appointmentTypeLbl = new System.Windows.Forms.Label();
            this.appointmentStartLbl = new System.Windows.Forms.Label();
            this.apointmentEndLbl = new System.Windows.Forms.Label();
            this.cancelAppointmentBtn = new System.Windows.Forms.Button();
            this.saveAppointmentBtn = new System.Windows.Forms.Button();
            this.appointmentDetailLbl = new System.Windows.Forms.Label();
            this.customerCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentEndTxt
            // 
            this.appointmentEndTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentEndTxt.Location = new System.Drawing.Point(191, 228);
            this.appointmentEndTxt.Name = "appointmentEndTxt";
            this.appointmentEndTxt.Size = new System.Drawing.Size(1, 1);
            this.appointmentEndTxt.TabIndex = 6;
            this.appointmentEndTxt.Text = "";
            // 
            // appointmentCustomerNameLbl
            // 
            this.appointmentCustomerNameLbl.AutoSize = true;
            this.appointmentCustomerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCustomerNameLbl.Location = new System.Drawing.Point(27, 87);
            this.appointmentCustomerNameLbl.Name = "appointmentCustomerNameLbl";
            this.appointmentCustomerNameLbl.Size = new System.Drawing.Size(147, 24);
            this.appointmentCustomerNameLbl.TabIndex = 12;
            this.appointmentCustomerNameLbl.Text = "Customer Name";
            // 
            // appointmentTypeLbl
            // 
            this.appointmentTypeLbl.AutoSize = true;
            this.appointmentTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeLbl.Location = new System.Drawing.Point(9, 147);
            this.appointmentTypeLbl.Name = "appointmentTypeLbl";
            this.appointmentTypeLbl.Size = new System.Drawing.Size(165, 24);
            this.appointmentTypeLbl.TabIndex = 17;
            this.appointmentTypeLbl.Text = "Appointment Type";
            // 
            // appointmentStartLbl
            // 
            this.appointmentStartLbl.AutoSize = true;
            this.appointmentStartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentStartLbl.Location = new System.Drawing.Point(123, 208);
            this.appointmentStartLbl.Name = "appointmentStartLbl";
            this.appointmentStartLbl.Size = new System.Drawing.Size(51, 24);
            this.appointmentStartLbl.TabIndex = 19;
            this.appointmentStartLbl.Text = "Start ";
            // 
            // apointmentEndLbl
            // 
            this.apointmentEndLbl.AutoSize = true;
            this.apointmentEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apointmentEndLbl.Location = new System.Drawing.Point(124, 276);
            this.apointmentEndLbl.Name = "apointmentEndLbl";
            this.apointmentEndLbl.Size = new System.Drawing.Size(50, 24);
            this.apointmentEndLbl.TabIndex = 20;
            this.apointmentEndLbl.Text = "End ";
            // 
            // cancelAppointmentBtn
            // 
            this.cancelAppointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentBtn.Location = new System.Drawing.Point(352, 404);
            this.cancelAppointmentBtn.Name = "cancelAppointmentBtn";
            this.cancelAppointmentBtn.Size = new System.Drawing.Size(99, 36);
            this.cancelAppointmentBtn.TabIndex = 5;
            this.cancelAppointmentBtn.Text = "Cancel";
            this.cancelAppointmentBtn.UseVisualStyleBackColor = true;
            this.cancelAppointmentBtn.Click += new System.EventHandler(this.cancelAppointmentBtn_Click);
            // 
            // saveAppointmentBtn
            // 
            this.saveAppointmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAppointmentBtn.Location = new System.Drawing.Point(352, 331);
            this.saveAppointmentBtn.Name = "saveAppointmentBtn";
            this.saveAppointmentBtn.Size = new System.Drawing.Size(99, 36);
            this.saveAppointmentBtn.TabIndex = 4;
            this.saveAppointmentBtn.Text = "Save";
            this.saveAppointmentBtn.UseVisualStyleBackColor = true;
            this.saveAppointmentBtn.Click += new System.EventHandler(this.saveAppointmentBtn_Click);
            // 
            // appointmentDetailLbl
            // 
            this.appointmentDetailLbl.AutoSize = true;
            this.appointmentDetailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDetailLbl.Location = new System.Drawing.Point(8, 9);
            this.appointmentDetailLbl.Name = "appointmentDetailLbl";
            this.appointmentDetailLbl.Size = new System.Drawing.Size(228, 29);
            this.appointmentDetailLbl.TabIndex = 23;
            this.appointmentDetailLbl.Text = "Appointment Details";
            // 
            // customerCB
            // 
            this.customerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCB.FormattingEnabled = true;
            this.customerCB.Location = new System.Drawing.Point(191, 83);
            this.customerCB.Margin = new System.Windows.Forms.Padding(4);
            this.customerCB.Name = "customerCB";
            this.customerCB.Size = new System.Drawing.Size(259, 28);
            this.customerCB.TabIndex = 0;
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Initial",
            "Presentation",
            "Follow Up",
            "Scrum",
            "Other"});
            this.typeCB.Location = new System.Drawing.Point(191, 143);
            this.typeCB.Margin = new System.Windows.Forms.Padding(4);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(259, 28);
            this.typeCB.TabIndex = 1;
            this.typeCB.SelectedIndexChanged += new System.EventHandler(this.typeCB_SelectedIndexChanged);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(192, 205);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.startTimePicker.MinDate = new System.DateTime(2018, 7, 25, 0, 0, 0, 0);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(259, 27);
            this.startTimePicker.TabIndex = 2;
            this.startTimePicker.Value = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(191, 273);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.endTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(259, 27);
            this.endTimePicker.TabIndex = 3;
            this.endTimePicker.Value = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(12, 40);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 20);
            this.errorLbl.TabIndex = 28;
            // 
            // AddUpdateApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 460);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.customerCB);
            this.Controls.Add(this.appointmentDetailLbl);
            this.Controls.Add(this.saveAppointmentBtn);
            this.Controls.Add(this.cancelAppointmentBtn);
            this.Controls.Add(this.apointmentEndLbl);
            this.Controls.Add(this.appointmentStartLbl);
            this.Controls.Add(this.appointmentTypeLbl);
            this.Controls.Add(this.appointmentCustomerNameLbl);
            this.Controls.Add(this.appointmentEndTxt);
            this.Name = "AddUpdateApptForm";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.AddUpdateAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox appointmentEndTxt;
        private System.Windows.Forms.Label appointmentCustomerNameLbl;
        private System.Windows.Forms.Label appointmentTypeLbl;
        private System.Windows.Forms.Label appointmentStartLbl;
        private System.Windows.Forms.Label apointmentEndLbl;
        private System.Windows.Forms.Button cancelAppointmentBtn;
        private System.Windows.Forms.Button saveAppointmentBtn;
        private System.Windows.Forms.Label appointmentDetailLbl;
        private System.Windows.Forms.ComboBox customerCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label errorLbl;
    }
}