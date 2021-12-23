
namespace OrderAutomation.Forms
{
    partial class CustomerToOrder
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
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.lblComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwItem
            // 
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Location = new System.Drawing.Point(12, 12);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.Size = new System.Drawing.Size(398, 205);
            this.dgwItem.TabIndex = 0;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(13, 250);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(111, 13);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = "Sipariş oluşturmak için";
            // 
            // CustomerToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.dgwItem);
            this.Name = "CustomerToOrder";
            this.Text = "CustomerToOrder";
            this.Load += new System.EventHandler(this.CustomerToOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.Label lblComment;
    }
}