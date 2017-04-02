namespace Prototype
{
    partial class panelFoods
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
            this.lblFood = new System.Windows.Forms.Label();
            this.lblUniP = new System.Windows.Forms.Label();
            this.noQty = new System.Windows.Forms.NumericUpDown();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblFid = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(67, 24);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(46, 17);
            this.lblFood.TabIndex = 0;
            this.lblFood.Text = "label1";
            // 
            // lblUniP
            // 
            this.lblUniP.AutoSize = true;
            this.lblUniP.Location = new System.Drawing.Point(453, 23);
            this.lblUniP.Name = "lblUniP";
            this.lblUniP.Size = new System.Drawing.Size(46, 17);
            this.lblUniP.TabIndex = 1;
            this.lblUniP.Text = "label2";
            // 
            // noQty
            // 
            this.noQty.Location = new System.Drawing.Point(588, 18);
            this.noQty.Margin = new System.Windows.Forms.Padding(4);
            this.noQty.Name = "noQty";
            this.noQty.Size = new System.Drawing.Size(44, 22);
            this.noQty.TabIndex = 2;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "stay",
            "To go"});
            this.cbxType.Location = new System.Drawing.Point(709, 18);
            this.cbxType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(111, 24);
            this.cbxType.TabIndex = 3;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Preparing",
            "Delivered"});
            this.cbxStatus.Location = new System.Drawing.Point(833, 18);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(114, 24);
            this.cbxStatus.TabIndex = 4;
            // 
            // lblFid
            // 
            this.lblFid.AutoSize = true;
            this.lblFid.Location = new System.Drawing.Point(3, 23);
            this.lblFid.Name = "lblFid";
            this.lblFid.Size = new System.Drawing.Size(46, 17);
            this.lblFid.TabIndex = 5;
            this.lblFid.Text = "label1";
            this.lblFid.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(16, 16);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(33, 30);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panelFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblFid);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.noQty);
            this.Controls.Add(this.lblUniP);
            this.Controls.Add(this.lblFood);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panelFoods";
            this.Size = new System.Drawing.Size(970, 60);
            ((System.ComponentModel.ISupportInitialize)(this.noQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFood;
        public System.Windows.Forms.Label lblUniP;
        public System.Windows.Forms.NumericUpDown noQty;
        public System.Windows.Forms.ComboBox cbxType;
        public System.Windows.Forms.ComboBox cbxStatus;
        public System.Windows.Forms.Label lblFid;
        private System.Windows.Forms.Button btnDel;
    }
}
