namespace Prototype
{
    partial class panelBkUpdate
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtPno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.lblBid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdate
            // 
            this.panelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUpdate.Controls.Add(this.btnAdd);
            this.panelUpdate.Controls.Add(this.dateTimePicker1);
            this.panelUpdate.Controls.Add(this.lblTime);
            this.panelUpdate.Controls.Add(this.dtpDate);
            this.panelUpdate.Controls.Add(this.btnReset);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.txtOther);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.txtStatus);
            this.panelUpdate.Controls.Add(this.lblStatus);
            this.panelUpdate.Controls.Add(this.lblDT);
            this.panelUpdate.Controls.Add(this.txtPno);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.txtTel);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Controls.Add(this.txtName);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.txtCid);
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Controls.Add(this.txtBid);
            this.panelUpdate.Controls.Add(this.lblBid);
            this.panelUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(904, 433);
            this.panelUpdate.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(629, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2017, 2, 13, 0, 0, 0, 0);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(467, 212);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 20);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Time:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(214, 214);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(161, 22);
            this.dtpDate.TabIndex = 20;
            this.dtpDate.Value = new System.DateTime(2017, 2, 13, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(527, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 39);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(262, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 39);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(214, 281);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(161, 22);
            this.txtOther.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Others:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(632, 281);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(162, 22);
            this.txtStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(471, 281);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(52, 212);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(55, 20);
            this.lblDT.TabIndex = 12;
            this.lblDT.Text = "Date:";
            // 
            // txtPno
            // 
            this.txtPno.Location = new System.Drawing.Point(629, 147);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(161, 22);
            this.txtPno.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "No. of People:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(214, 145);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 22);
            this.txtTel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tel:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(630, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 22);
            this.txtName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(214, 88);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(161, 22);
            this.txtCid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client ID:";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(214, 26);
            this.txtBid.Name = "txtBid";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(161, 22);
            this.txtBid.TabIndex = 1;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Cooper Std Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.Location = new System.Drawing.Point(52, 26);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(116, 20);
            this.lblBid.TabIndex = 0;
            this.lblBid.Text = "Booking ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(399, 373);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 39);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelBkUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUpdate);
            this.Name = "panelBkUpdate";
            this.Size = new System.Drawing.Size(904, 433);
            this.Load += new System.EventHandler(this.panelBkUpdate_Load);
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtPno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtStatus;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtBid;
        public System.Windows.Forms.Label lblBid;
    }
}
