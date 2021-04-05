namespace WInstonKingC969
{
    partial class AddUpdateCustomerForm
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
            this.nameTxt = new System.Windows.Forms.RichTextBox();
            this.addressTxt = new System.Windows.Forms.RichTextBox();
            this.zipTxt = new System.Windows.Forms.RichTextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.customerCityLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelCustomerBtn = new System.Windows.Forms.Button();
            this.saveCustomerBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.RichTextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(203, 88);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(261, 31);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.Text = "";
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(203, 147);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(261, 31);
            this.addressTxt.TabIndex = 1;
            this.addressTxt.Text = "";
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // zipTxt
            // 
            this.zipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTxt.Location = new System.Drawing.Point(203, 266);
            this.zipTxt.Name = "zipTxt";
            this.zipTxt.Size = new System.Drawing.Size(261, 31);
            this.zipTxt.TabIndex = 3;
            this.zipTxt.Text = "";
            this.zipTxt.TextChanged += new System.EventHandler(this.zipTxt_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(41, 95);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(147, 24);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Customer Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(23, 154);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(166, 24);
            this.addressLbl.TabIndex = 11;
            this.addressLbl.Text = "Customer Address";
            // 
            // customerCityLbl
            // 
            this.customerCityLbl.AutoSize = true;
            this.customerCityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityLbl.Location = new System.Drawing.Point(62, 213);
            this.customerCityLbl.Name = "customerCityLbl";
            this.customerCityLbl.Size = new System.Drawing.Size(126, 24);
            this.customerCityLbl.TabIndex = 13;
            this.customerCityLbl.Text = "Customer City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Customer Zip ";
            // 
            // cancelCustomerBtn
            // 
            this.cancelCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCustomerBtn.Location = new System.Drawing.Point(347, 473);
            this.cancelCustomerBtn.Name = "cancelCustomerBtn";
            this.cancelCustomerBtn.Size = new System.Drawing.Size(117, 36);
            this.cancelCustomerBtn.TabIndex = 6;
            this.cancelCustomerBtn.Text = "Cancel";
            this.cancelCustomerBtn.UseVisualStyleBackColor = true;
            this.cancelCustomerBtn.Click += new System.EventHandler(this.cancelCustBtn_Click);
            // 
            // saveCustomerBtn
            // 
            this.saveCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomerBtn.Location = new System.Drawing.Point(347, 386);
            this.saveCustomerBtn.Name = "saveCustomerBtn";
            this.saveCustomerBtn.Size = new System.Drawing.Size(117, 36);
            this.saveCustomerBtn.TabIndex = 5;
            this.saveCustomerBtn.Text = "Save";
            this.saveCustomerBtn.UseVisualStyleBackColor = true;
            this.saveCustomerBtn.Click += new System.EventHandler(this.saveCustBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Customer Details";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(203, 329);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(261, 31);
            this.phoneTxt.TabIndex = 4;
            this.phoneTxt.Text = "";
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(36, 336);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(152, 24);
            this.phoneLbl.TabIndex = 26;
            this.phoneLbl.Text = "Customer Phone";
            // 
            // cityCB
            // 
            this.cityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Oslo",
            "Toronto"});
            this.cityCB.Location = new System.Drawing.Point(203, 209);
            this.cityCB.Margin = new System.Windows.Forms.Padding(4);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(261, 28);
            this.cityCB.TabIndex = 2;
            this.cityCB.SelectedIndexChanged += new System.EventHandler(this.cityCB_SelectedIndexChanged);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(140, 368);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 20);
            this.errorLbl.TabIndex = 28;
            // 
            // AddUpdateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 521);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saveCustomerBtn);
            this.Controls.Add(this.cancelCustomerBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerCityLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.zipTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "AddUpdateCustomerForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.AddUpdateCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label customerCityLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelCustomerBtn;
        private System.Windows.Forms.Button saveCustomerBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label errorLbl;
        public System.Windows.Forms.RichTextBox addressTxt;
        public System.Windows.Forms.RichTextBox zipTxt;
        public System.Windows.Forms.RichTextBox phoneTxt;
        public System.Windows.Forms.ComboBox cityCB;
        public System.Windows.Forms.RichTextBox nameTxt;
    }
}