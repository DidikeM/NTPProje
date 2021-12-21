
namespace OrderAutomation.Forms
{
    partial class DnmForm
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
            this.dgwdeneme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwdeneme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwdeneme
            // 
            this.dgwdeneme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwdeneme.Location = new System.Drawing.Point(12, 12);
            this.dgwdeneme.Name = "dgwdeneme";
            this.dgwdeneme.Size = new System.Drawing.Size(765, 241);
            this.dgwdeneme.TabIndex = 0;
            this.dgwdeneme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DnmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwdeneme);
            this.Name = "DnmForm";
            this.Text = "DnmForm";
            this.Load += new System.EventHandler(this.DnmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwdeneme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwdeneme;
    }
}