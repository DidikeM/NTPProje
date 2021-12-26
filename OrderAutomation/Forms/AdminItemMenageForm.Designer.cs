
namespace OrderAutomation.Forms
{
    partial class AdminItemMenageForm
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
            this.gbxItemAdd = new System.Windows.Forms.GroupBox();
            this.cbxAddTax = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.tbxAddPrice = new System.Windows.Forms.TextBox();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddTax = new System.Windows.Forms.Label();
            this.tbxAddShippingWeight = new System.Windows.Forms.TextBox();
            this.lblAddShippingWeight = new System.Windows.Forms.Label();
            this.tbxAddItemName = new System.Windows.Forms.TextBox();
            this.lblIAddItemName = new System.Windows.Forms.Label();
            this.gbxItemUpAndDel = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxUpdateTax = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateDescription = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.lblUpdateTax = new System.Windows.Forms.Label();
            this.tbxUpdateShippingWeight = new System.Windows.Forms.TextBox();
            this.lblUpdateShippingWeight = new System.Windows.Forms.Label();
            this.tbxUpdateItemName = new System.Windows.Forms.TextBox();
            this.lblUpdateItemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.gbxItemAdd.SuspendLayout();
            this.gbxItemUpAndDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwItem
            // 
            this.dgwItem.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Location = new System.Drawing.Point(18, 18);
            this.dgwItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.RowHeadersWidth = 62;
            this.dgwItem.Size = new System.Drawing.Size(1164, 305);
            this.dgwItem.TabIndex = 0;
            this.dgwItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellClick);
            // 
            // gbxItemAdd
            // 
            this.gbxItemAdd.Controls.Add(this.cbxAddTax);
            this.gbxItemAdd.Controls.Add(this.btnAdd);
            this.gbxItemAdd.Controls.Add(this.tbxAddDescription);
            this.gbxItemAdd.Controls.Add(this.lblAddDescription);
            this.gbxItemAdd.Controls.Add(this.tbxAddPrice);
            this.gbxItemAdd.Controls.Add(this.lblAddPrice);
            this.gbxItemAdd.Controls.Add(this.lblAddTax);
            this.gbxItemAdd.Controls.Add(this.tbxAddShippingWeight);
            this.gbxItemAdd.Controls.Add(this.lblAddShippingWeight);
            this.gbxItemAdd.Controls.Add(this.tbxAddItemName);
            this.gbxItemAdd.Controls.Add(this.lblIAddItemName);
            this.gbxItemAdd.Location = new System.Drawing.Point(18, 332);
            this.gbxItemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItemAdd.Name = "gbxItemAdd";
            this.gbxItemAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItemAdd.Size = new System.Drawing.Size(516, 342);
            this.gbxItemAdd.TabIndex = 1;
            this.gbxItemAdd.TabStop = false;
            this.gbxItemAdd.Text = "Ürün Ekle";
            // 
            // cbxAddTax
            // 
            this.cbxAddTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cbxAddTax.FormattingEnabled = true;
            this.cbxAddTax.Location = new System.Drawing.Point(192, 143);
            this.cbxAddTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAddTax.Name = "cbxAddTax";
            this.cbxAddTax.Size = new System.Drawing.Size(163, 28);
            this.cbxAddTax.TabIndex = 3;
            this.cbxAddTax.SelectedIndexChanged += new System.EventHandler(this.cbxAddTax_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(378, 257);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 75);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddDescription
            // 
            this.tbxAddDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddDescription.Location = new System.Drawing.Point(192, 257);
            this.tbxAddDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAddDescription.Multiline = true;
            this.tbxAddDescription.Name = "tbxAddDescription";
            this.tbxAddDescription.Size = new System.Drawing.Size(163, 73);
            this.tbxAddDescription.TabIndex = 9;
            this.tbxAddDescription.TextChanged += new System.EventHandler(this.tbxAddDescription_TextChanged);
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDescription.Location = new System.Drawing.Point(8, 262);
            this.lblAddDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(161, 25);
            this.lblAddDescription.TabIndex = 8;
            this.lblAddDescription.Text = "Ürün Açıklaması";
            // 
            // tbxAddPrice
            // 
            this.tbxAddPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddPrice.Location = new System.Drawing.Point(192, 198);
            this.tbxAddPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAddPrice.Name = "tbxAddPrice";
            this.tbxAddPrice.Size = new System.Drawing.Size(163, 26);
            this.tbxAddPrice.TabIndex = 7;
            this.tbxAddPrice.TextChanged += new System.EventHandler(this.tbxAddPrice_TextChanged);
            this.tbxAddPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddPrice_KeyPress);
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrice.Location = new System.Drawing.Point(100, 199);
            this.lblAddPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(57, 25);
            this.lblAddPrice.TabIndex = 6;
            this.lblAddPrice.Text = "Fiyat";
            // 
            // lblAddTax
            // 
            this.lblAddTax.AutoSize = true;
            this.lblAddTax.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTax.Location = new System.Drawing.Point(36, 148);
            this.lblAddTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddTax.Name = "lblAddTax";
            this.lblAddTax.Size = new System.Drawing.Size(129, 25);
            this.lblAddTax.TabIndex = 4;
            this.lblAddTax.Text = "Vergi Miktarı";
            // 
            // tbxAddShippingWeight
            // 
            this.tbxAddShippingWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddShippingWeight.Location = new System.Drawing.Point(192, 89);
            this.tbxAddShippingWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAddShippingWeight.Name = "tbxAddShippingWeight";
            this.tbxAddShippingWeight.Size = new System.Drawing.Size(163, 26);
            this.tbxAddShippingWeight.TabIndex = 2;
            this.tbxAddShippingWeight.TextChanged += new System.EventHandler(this.tbxAddShippingWeight_TextChanged);
            this.tbxAddShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddShippingWeight_KeyPress);
            // 
            // lblAddShippingWeight
            // 
            this.lblAddShippingWeight.AutoSize = true;
            this.lblAddShippingWeight.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddShippingWeight.Location = new System.Drawing.Point(28, 94);
            this.lblAddShippingWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddShippingWeight.Name = "lblAddShippingWeight";
            this.lblAddShippingWeight.Size = new System.Drawing.Size(137, 25);
            this.lblAddShippingWeight.TabIndex = 2;
            this.lblAddShippingWeight.Text = "Kargo Ağırlığı";
            // 
            // tbxAddItemName
            // 
            this.tbxAddItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddItemName.Location = new System.Drawing.Point(192, 35);
            this.tbxAddItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxAddItemName.Name = "tbxAddItemName";
            this.tbxAddItemName.Size = new System.Drawing.Size(163, 26);
            this.tbxAddItemName.TabIndex = 1;
            this.tbxAddItemName.TextChanged += new System.EventHandler(this.tbxAddItemName_TextChanged);
            // 
            // lblIAddItemName
            // 
            this.lblIAddItemName.AutoSize = true;
            this.lblIAddItemName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIAddItemName.Location = new System.Drawing.Point(63, 40);
            this.lblIAddItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIAddItemName.Name = "lblIAddItemName";
            this.lblIAddItemName.Size = new System.Drawing.Size(94, 25);
            this.lblIAddItemName.TabIndex = 0;
            this.lblIAddItemName.Text = "Ürün Adı";
            // 
            // gbxItemUpAndDel
            // 
            this.gbxItemUpAndDel.Controls.Add(this.btnDelete);
            this.gbxItemUpAndDel.Controls.Add(this.cbxUpdateTax);
            this.gbxItemUpAndDel.Controls.Add(this.btnUpdate);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdateDescription);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateDescription);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdatePrice);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdatePrice);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateTax);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdateShippingWeight);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateShippingWeight);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdateItemName);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateItemName);
            this.gbxItemUpAndDel.Location = new System.Drawing.Point(666, 332);
            this.gbxItemUpAndDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItemUpAndDel.Name = "gbxItemUpAndDel";
            this.gbxItemUpAndDel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItemUpAndDel.Size = new System.Drawing.Size(516, 342);
            this.gbxItemUpAndDel.TabIndex = 2;
            this.gbxItemUpAndDel.TabStop = false;
            this.gbxItemUpAndDel.Text = "Ürün Düzenle/Sil";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(378, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 75);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Ürün\'ü Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxUpdateTax
            // 
            this.cbxUpdateTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cbxUpdateTax.FormattingEnabled = true;
            this.cbxUpdateTax.Location = new System.Drawing.Point(192, 143);
            this.cbxUpdateTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxUpdateTax.Name = "cbxUpdateTax";
            this.cbxUpdateTax.Size = new System.Drawing.Size(163, 28);
            this.cbxUpdateTax.TabIndex = 3;
            this.cbxUpdateTax.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateTax_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(378, 257);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 75);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Ürün\'ü Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateDescription
            // 
            this.tbxUpdateDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdateDescription.Location = new System.Drawing.Point(192, 257);
            this.tbxUpdateDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUpdateDescription.Multiline = true;
            this.tbxUpdateDescription.Name = "tbxUpdateDescription";
            this.tbxUpdateDescription.Size = new System.Drawing.Size(163, 73);
            this.tbxUpdateDescription.TabIndex = 9;
            this.tbxUpdateDescription.TextChanged += new System.EventHandler(this.tbxUpdateDescription_TextChanged);
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(28, 262);
            this.lblUpdateDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(123, 20);
            this.lblUpdateDescription.TabIndex = 8;
            this.lblUpdateDescription.Text = "Ürün Açıklaması";
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdatePrice.Location = new System.Drawing.Point(192, 198);
            this.tbxUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(163, 26);
            this.tbxUpdatePrice.TabIndex = 7;
            this.tbxUpdatePrice.TextChanged += new System.EventHandler(this.tbxUpdatePrice_TextChanged);
            this.tbxUpdatePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUpdatePrice_KeyPress);
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(28, 203);
            this.lblUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(43, 20);
            this.lblUpdatePrice.TabIndex = 6;
            this.lblUpdatePrice.Text = "Fiyat";
            // 
            // lblUpdateTax
            // 
            this.lblUpdateTax.AutoSize = true;
            this.lblUpdateTax.Location = new System.Drawing.Point(28, 148);
            this.lblUpdateTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateTax.Name = "lblUpdateTax";
            this.lblUpdateTax.Size = new System.Drawing.Size(96, 20);
            this.lblUpdateTax.TabIndex = 4;
            this.lblUpdateTax.Text = "Vergi Miktarı";
            // 
            // tbxUpdateShippingWeight
            // 
            this.tbxUpdateShippingWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdateShippingWeight.Location = new System.Drawing.Point(192, 89);
            this.tbxUpdateShippingWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUpdateShippingWeight.Name = "tbxUpdateShippingWeight";
            this.tbxUpdateShippingWeight.Size = new System.Drawing.Size(163, 26);
            this.tbxUpdateShippingWeight.TabIndex = 2;
            this.tbxUpdateShippingWeight.TextChanged += new System.EventHandler(this.tbxUpdateShippingWeight_TextChanged);
            this.tbxUpdateShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUpdateShippingWeight_KeyPress);
            // 
            // lblUpdateShippingWeight
            // 
            this.lblUpdateShippingWeight.AutoSize = true;
            this.lblUpdateShippingWeight.Location = new System.Drawing.Point(28, 94);
            this.lblUpdateShippingWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateShippingWeight.Name = "lblUpdateShippingWeight";
            this.lblUpdateShippingWeight.Size = new System.Drawing.Size(101, 20);
            this.lblUpdateShippingWeight.TabIndex = 2;
            this.lblUpdateShippingWeight.Text = "Kargo Ağırlığı";
            // 
            // tbxUpdateItemName
            // 
            this.tbxUpdateItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdateItemName.Location = new System.Drawing.Point(192, 35);
            this.tbxUpdateItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxUpdateItemName.Name = "tbxUpdateItemName";
            this.tbxUpdateItemName.Size = new System.Drawing.Size(163, 26);
            this.tbxUpdateItemName.TabIndex = 1;
            this.tbxUpdateItemName.TextChanged += new System.EventHandler(this.tbxUpdateItemName_TextChanged);
            // 
            // lblUpdateItemName
            // 
            this.lblUpdateItemName.AutoSize = true;
            this.lblUpdateItemName.Location = new System.Drawing.Point(28, 40);
            this.lblUpdateItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateItemName.Name = "lblUpdateItemName";
            this.lblUpdateItemName.Size = new System.Drawing.Size(71, 20);
            this.lblUpdateItemName.TabIndex = 0;
            this.lblUpdateItemName.Text = "Ürün Adı";
            // 
            // AdminItemMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gbxItemUpAndDel);
            this.Controls.Add(this.gbxItemAdd);
            this.Controls.Add(this.dgwItem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminItemMenageForm";
            this.Text = "AdminİtemMenageForm";
            this.Load += new System.EventHandler(this.AdminİtemMenageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.gbxItemAdd.ResumeLayout(false);
            this.gbxItemAdd.PerformLayout();
            this.gbxItemUpAndDel.ResumeLayout(false);
            this.gbxItemUpAndDel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.GroupBox gbxItemAdd;
        private System.Windows.Forms.TextBox tbxAddItemName;
        private System.Windows.Forms.Label lblIAddItemName;
        private System.Windows.Forms.TextBox tbxAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.TextBox tbxAddPrice;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.ComboBox cbxAddTax;
        private System.Windows.Forms.Label lblAddTax;
        private System.Windows.Forms.TextBox tbxAddShippingWeight;
        private System.Windows.Forms.Label lblAddShippingWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxItemUpAndDel;
        private System.Windows.Forms.ComboBox cbxUpdateTax;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateDescription;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.Label lblUpdateTax;
        private System.Windows.Forms.TextBox tbxUpdateShippingWeight;
        private System.Windows.Forms.Label lblUpdateShippingWeight;
        private System.Windows.Forms.TextBox tbxUpdateItemName;
        private System.Windows.Forms.Label lblUpdateItemName;
        private System.Windows.Forms.Button btnDelete;
    }
}