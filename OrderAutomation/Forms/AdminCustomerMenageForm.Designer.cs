
namespace OrderAutomation.Forms
{
    partial class AdminCustomerMenageForm
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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.dgwOrderDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(18, 18);
            this.dgwCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.RowHeadersWidth = 62;
            this.dgwCustomer.Size = new System.Drawing.Size(1164, 237);
            this.dgwCustomer.TabIndex = 0;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // dgwOrder
            // 
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Location = new System.Drawing.Point(18, 265);
            this.dgwOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.RowHeadersWidth = 62;
            this.dgwOrder.Size = new System.Drawing.Size(1164, 237);
            this.dgwOrder.TabIndex = 1;
            this.dgwOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrder_CellClick);
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(18, 511);
            this.dgwOrderDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.RowHeadersWidth = 62;
            this.dgwOrderDetail.Size = new System.Drawing.Size(1164, 237);
            this.dgwOrderDetail.TabIndex = 2;
            // 
            // AdminCustomerMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1200, 763);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.dgwOrder);
            this.Controls.Add(this.dgwCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminCustomerMenageForm";
            this.Text = "AdminCustomerMenageForm";
            this.Load += new System.EventHandler(this.AdminCustomerMenageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.DataGridView dgwOrderDetail;
    }
}