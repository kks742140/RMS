namespace Prototype
{
    partial class panelOrderRecord
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
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lblHoid = new System.Windows.Forms.Label();
            this.lblSid = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblOid = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.Controls.Add(this.btnPay);
            this.panelDetail.Controls.Add(this.lblHoid);
            this.panelDetail.Controls.Add(this.lblSid);
            this.panelDetail.Controls.Add(this.btnDel);
            this.panelDetail.Controls.Add(this.btnUpdate);
            this.panelDetail.Controls.Add(this.lblTotal);
            this.panelDetail.Controls.Add(this.lblStaff);
            this.panelDetail.Controls.Add(this.lblTime);
            this.panelDetail.Controls.Add(this.lblDate);
            this.panelDetail.Controls.Add(this.lblTid);
            this.panelDetail.Controls.Add(this.lblOid);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(961, 127);
            this.panelDetail.TabIndex = 0;
            this.panelDetail.Click += new System.EventHandler(this.panelDetail_Click);
            // 
            // lblHoid
            // 
            this.lblHoid.AutoSize = true;
            this.lblHoid.Location = new System.Drawing.Point(135, 18);
            this.lblHoid.Name = "lblHoid";
            this.lblHoid.Size = new System.Drawing.Size(46, 17);
            this.lblHoid.TabIndex = 11;
            this.lblHoid.Text = "label1";
            this.lblHoid.Visible = false;
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(695, 12);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(46, 17);
            this.lblSid.TabIndex = 10;
            this.lblSid.Text = "label1";
            this.lblSid.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(917, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(41, 40);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(795, 52);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(558, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 24);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "lblTotal";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(558, 11);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(94, 24);
            this.lblStaff.TabIndex = 5;
            this.lblStaff.Text = "lblStaff";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(329, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 24);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "lblTime";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "lblDate";
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTid.Location = new System.Drawing.Point(329, 12);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(77, 24);
            this.lblTid.TabIndex = 2;
            this.lblTid.Text = "lblTid";
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOid.Location = new System.Drawing.Point(13, 12);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(77, 24);
            this.lblOid.TabIndex = 1;
            this.lblOid.Text = "lblOid";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(795, 52);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(107, 47);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Check Out";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panelOrderRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelDetail);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panelOrderRecord";
            this.Size = new System.Drawing.Size(960, 127);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        public System.Windows.Forms.Label lblOid;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblStaff;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblTid;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Label lblSid;
        public System.Windows.Forms.Label lblHoid;
        public System.Windows.Forms.Button btnPay;
    }
}
