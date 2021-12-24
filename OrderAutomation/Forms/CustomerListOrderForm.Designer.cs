
namespace OrderAutomation.Forms
{
    partial class CustomerListOrderForm
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
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.btnToOrder = new System.Windows.Forms.Button();
            this.dgwOrderDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOrder
            // 
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Location = new System.Drawing.Point(12, 12);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.Size = new System.Drawing.Size(729, 198);
            this.dgwOrder.TabIndex = 0;
            this.dgwOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrder_CellClick);
            // 
            // btnToOrder
            // 
            this.btnToOrder.Location = new System.Drawing.Point(768, 45);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(182, 73);
            this.btnToOrder.TabIndex = 1;
            this.btnToOrder.Text = "Yeni sipariş oluştur";
            this.btnToOrder.UseVisualStyleBackColor = true;
            this.btnToOrder.Click += new System.EventHandler(this.btnToOrder_Click);
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(12, 240);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.Size = new System.Drawing.Size(729, 198);
            this.dgwOrderDetail.TabIndex = 2;
            // 
            // CustomerListOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.dgwOrder);
            this.Name = "CustomerListOrderForm";
            this.Text = "CustomerListOrderForm";
            this.Load += new System.EventHandler(this.CustomerListOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.Button btnToOrder;
        private System.Windows.Forms.DataGridView dgwOrderDetail;
    }
}