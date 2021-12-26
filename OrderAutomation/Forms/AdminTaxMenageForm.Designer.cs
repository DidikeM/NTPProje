
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTaxMenageForm));
            this.dgwTax = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxTaxPercent = new System.Windows.Forms.TextBox();
            this.tbxTaxName = new System.Windows.Forms.TextBox();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.lblTaxName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTax)).BeginInit();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTax
            // 
            this.dgwTax.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgwTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTax.Location = new System.Drawing.Point(244, 63);
            this.dgwTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwTax.Name = "dgwTax";
            this.dgwTax.RowHeadersWidth = 62;
            this.dgwTax.Size = new System.Drawing.Size(617, 315);
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
            this.gbxAdd.Location = new System.Drawing.Point(308, 398);
            this.gbxAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxAdd.Size = new System.Drawing.Size(480, 231);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Vergi Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(269, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxTaxPercent
            // 
            this.tbxTaxPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxTaxPercent.Location = new System.Drawing.Point(252, 122);
            this.tbxTaxPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTaxPercent.Name = "tbxTaxPercent";
            this.tbxTaxPercent.Size = new System.Drawing.Size(148, 26);
            this.tbxTaxPercent.TabIndex = 3;
            this.tbxTaxPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTaxPercent_KeyPress);
            // 
            // tbxTaxName
            // 
            this.tbxTaxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxTaxName.Location = new System.Drawing.Point(252, 55);
            this.tbxTaxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxTaxName.Name = "tbxTaxName";
            this.tbxTaxName.Size = new System.Drawing.Size(148, 26);
            this.tbxTaxName.TabIndex = 2;
            // 
            // lblTaxPercent
            // 
            this.lblTaxPercent.AutoSize = true;
            this.lblTaxPercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPercent.Location = new System.Drawing.Point(14, 122);
            this.lblTaxPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxPercent.Name = "lblTaxPercent";
            this.lblTaxPercent.Size = new System.Drawing.Size(230, 27);
            this.lblTaxPercent.TabIndex = 1;
            this.lblTaxPercent.Text = "Vergi Oranı (yüzdelik):";
            // 
            // lblTaxName
            // 
            this.lblTaxName.AutoSize = true;
            this.lblTaxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxName.Location = new System.Drawing.Point(181, 55);
            this.lblTaxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxName.Name = "lblTaxName";
            this.lblTaxName.Size = new System.Drawing.Size(53, 27);
            this.lblTaxName.TabIndex = 0;
            this.lblTaxName.Text = "Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1015, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 425);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(864, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // AdminTaxMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1096, 688);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwTax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminTaxMenageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTaxMenageForm";
            this.Load += new System.EventHandler(this.AdminTaxMenageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTax)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}