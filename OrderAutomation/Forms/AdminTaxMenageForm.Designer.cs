
namespace OrderAutomation.Forms
{
    partial class AdminTaxMenageForm
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
            this.dgwTax = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.lblTaxName = new System.Windows.Forms.Label();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.tbxTaxName = new System.Windows.Forms.TextBox();
            this.tbxTaxPercent = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTax)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTax
            // 
            this.dgwTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTax.Location = new System.Drawing.Point(12, 12);
            this.dgwTax.Name = "dgwTax";
            this.dgwTax.Size = new System.Drawing.Size(356, 150);
            this.dgwTax.TabIndex = 0;
            this.dgwTax.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTax_CellClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxTaxPercent);
            this.gbxAdd.Controls.Add(this.tbxTaxName);
            this.gbxAdd.Controls.Add(this.lblTaxPercent);
            this.gbxAdd.Controls.Add(this.lblTaxName);
            this.gbxAdd.Location = new System.Drawing.Point(399, 12);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(320, 150);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Vergi Ekle";
            // 
            // lblTaxName
            // 
            this.lblTaxName.AutoSize = true;
            this.lblTaxName.Location = new System.Drawing.Point(15, 39);
            this.lblTaxName.Name = "lblTaxName";
            this.lblTaxName.Size = new System.Drawing.Size(22, 13);
            this.lblTaxName.TabIndex = 0;
            this.lblTaxName.Text = "Adı";
            // 
            // lblTaxPercent
            // 
            this.lblTaxPercent.AutoSize = true;
            this.lblTaxPercent.Location = new System.Drawing.Point(15, 82);
            this.lblTaxPercent.Name = "lblTaxPercent";
            this.lblTaxPercent.Size = new System.Drawing.Size(106, 13);
            this.lblTaxPercent.TabIndex = 1;
            this.lblTaxPercent.Text = "Vergi Oranı (yüzdelik)";
            // 
            // tbxTaxName
            // 
            this.tbxTaxName.Location = new System.Drawing.Point(168, 36);
            this.tbxTaxName.Name = "tbxTaxName";
            this.tbxTaxName.Size = new System.Drawing.Size(100, 20);
            this.tbxTaxName.TabIndex = 2;
            // 
            // tbxTaxPercent
            // 
            this.tbxTaxPercent.Location = new System.Drawing.Point(168, 79);
            this.tbxTaxPercent.Name = "tbxTaxPercent";
            this.tbxTaxPercent.Size = new System.Drawing.Size(100, 20);
            this.tbxTaxPercent.TabIndex = 3;
            this.tbxTaxPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTaxPercent_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AdminTaxMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 301);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwTax);
            this.Name = "AdminTaxMenageForm";
            this.Text = "AdminTaxMenageForm";
            this.Load += new System.EventHandler(this.AdminTaxMenageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTax)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTax;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxTaxPercent;
        private System.Windows.Forms.TextBox tbxTaxName;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.Label lblTaxName;
    }
}