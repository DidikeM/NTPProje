
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
            this.dgwOrder.Location = new System.Drawing.Point(18, 18);
            this.dgwOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.RowHeadersWidth = 62;
            this.dgwOrder.Size = new System.Drawing.Size(1094, 305);
            this.dgwOrder.TabIndex = 0;
            this.dgwOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrder_CellClick);
            // 
            // btnToOrder
            // 
            this.btnToOrder.Location = new System.Drawing.Point(1152, 69);
            this.btnToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(273, 112);
            this.btnToOrder.TabIndex = 1;
            this.btnToOrder.Text = "Yeni sipariş oluştur";
            this.btnToOrder.UseVisualStyleBackColor = true;
            this.btnToOrder.Click += new System.EventHandler(this.btnToOrder_Click);
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(18, 369);
            this.dgwOrderDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.RowHeadersWidth = 62;
            this.dgwOrderDetail.Size = new System.Drawing.Size(1094, 305);
            this.dgwOrderDetail.TabIndex = 2;
            // 
            // CustomerListOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1545, 692);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.dgwOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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