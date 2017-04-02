namespace Prototype
{
    partial class panelOrderDetail
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
            this.panelOrderInfo = new System.Windows.Forms.Panel();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.txtOid = new System.Windows.Forms.TextBox();
            this.lblOid = new System.Windows.Forms.Label();
            this.panelFood = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelOrderInfo.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrderInfo
            // 
            this.panelOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrderInfo.Controls.Add(this.txtDT);
            this.panelOrderInfo.Controls.Add(this.lblDT);
            this.panelOrderInfo.Controls.Add(this.txtStaff);
            this.panelOrderInfo.Controls.Add(this.txtTid);
            this.panelOrderInfo.Controls.Add(this.lblStaff);
            this.panelOrderInfo.Controls.Add(this.lblTid);
            this.panelOrderInfo.Controls.Add(this.txtOid);
            this.panelOrderInfo.Controls.Add(this.lblOid);
            this.panelOrderInfo.Location = new System.Drawing.Point(0, 0);
            this.panelOrderInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelOrderInfo.Name = "panelOrderInfo";
            this.panelOrderInfo.Size = new System.Drawing.Size(970, 114);
            this.panelOrderInfo.TabIndex = 0;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(565, 81);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 22);
            this.txtDT.TabIndex = 9;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(493, 84);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(42, 17);
            this.lblDT.TabIndex = 8;
            this.lblDT.Text = "Date:";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(149, 81);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(100, 22);
            this.txtStaff.TabIndex = 7;
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(565, 27);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(100, 22);
            this.txtTid.TabIndex = 6;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(67, 84);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(41, 17);
            this.lblStaff.TabIndex = 5;
            this.lblStaff.Text = "Staff:";
            this.lblStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(493, 31);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(65, 17);
            this.lblTid.TabIndex = 4;
            this.lblTid.Text = "Table ID:";
            // 
            // txtOid
            // 
            this.txtOid.Location = new System.Drawing.Point(149, 28);
            this.txtOid.Name = "txtOid";
            this.txtOid.Size = new System.Drawing.Size(100, 22);
            this.txtOid.TabIndex = 3;
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.Location = new System.Drawing.Point(67, 31);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(66, 17);
            this.lblOid.TabIndex = 2;
            this.lblOid.Text = "Order ID:";
            // 
            // panelFood
            // 
            this.panelFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFood.AutoScroll = true;
            this.panelFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFood.Controls.Add(this.lblStatus);
            this.panelFood.Controls.Add(this.btnReset);
            this.panelFood.Controls.Add(this.btnUpdate);
            this.panelFood.Controls.Add(this.label2);
            this.panelFood.Controls.Add(this.lblFood);
            this.panelFood.Controls.Add(this.label1);
            this.panelFood.Controls.Add(this.lblPrice);
            this.panelFood.Location = new System.Drawing.Point(0, 114);
            this.panelFood.Margin = new System.Windows.Forms.Padding(0);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(970, 350);
            this.panelFood.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(833, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(508, 293);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 31);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(251, 293);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order type";
            // 
            // lblFood
            // 
            this.lblFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(67, 13);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(44, 17);
            this.lblFood.TabIndex = 1;
            this.lblFood.Text = "Food:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(453, 13);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Unit Price";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelOrderInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFood, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.78448F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.21552F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 464);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "panelOrderDetail";
            this.Size = new System.Drawing.Size(970, 464);
            this.Load += new System.EventHandler(this.panelOrderDetail_Load);
            this.panelOrderInfo.ResumeLayout(false);
            this.panelOrderInfo.PerformLayout();
            this.panelFood.ResumeLayout(false);
            this.panelFood.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrderInfo;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblOid;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtStaff;
        public System.Windows.Forms.TextBox txtTid;
        public System.Windows.Forms.TextBox txtOid;
        public System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label lblDT;
        public System.Windows.Forms.Panel panelFood;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Button btnUpdate;
    }
}
