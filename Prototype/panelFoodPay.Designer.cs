namespace Prototype
{
    partial class panelFoodPay
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
            this.lblFid = new System.Windows.Forms.Label();
            this.lblUniP = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSubT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFid
            // 
            this.lblFid.AutoSize = true;
            this.lblFid.Location = new System.Drawing.Point(7, 34);
            this.lblFid.Name = "lblFid";
            this.lblFid.Size = new System.Drawing.Size(41, 17);
            this.lblFid.TabIndex = 12;
            this.lblFid.Text = "lblFid";
            this.lblFid.Visible = false;
            // 
            // lblUniP
            // 
            this.lblUniP.AutoSize = true;
            this.lblUniP.Location = new System.Drawing.Point(457, 34);
            this.lblUniP.Name = "lblUniP";
            this.lblUniP.Size = new System.Drawing.Size(52, 17);
            this.lblUniP.TabIndex = 8;
            this.lblUniP.Text = "lblUniP";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(71, 35);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(54, 17);
            this.lblFood.TabIndex = 7;
            this.lblFood.Text = "lblFood";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(587, 34);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(44, 17);
            this.lblQty.TabIndex = 14;
            this.lblQty.Text = "lblQty";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(709, 34);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(54, 17);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "lblType";
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.Location = new System.Drawing.Point(831, 35);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(56, 17);
            this.lblSubT.TabIndex = 16;
            this.lblSubT.Text = "lblSubT";
            // 
            // panelFoodPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSubT);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblFid);
            this.Controls.Add(this.lblUniP);
            this.Controls.Add(this.lblFood);
            this.Name = "panelFoodPay";
            this.Size = new System.Drawing.Size(970, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblFid;
        public System.Windows.Forms.Label lblUniP;
        public System.Windows.Forms.Label lblFood;
        public System.Windows.Forms.Label lblQty;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.Label lblSubT;
    }
}
