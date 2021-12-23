
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
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.gbxItemAdd.SuspendLayout();
            this.gbxItemUpAndDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwItem
            // 
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Location = new System.Drawing.Point(12, 12);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.Size = new System.Drawing.Size(776, 198);
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
            this.gbxItemAdd.Location = new System.Drawing.Point(12, 216);
            this.gbxItemAdd.Name = "gbxItemAdd";
            this.gbxItemAdd.Size = new System.Drawing.Size(344, 222);
            this.gbxItemAdd.TabIndex = 1;
            this.gbxItemAdd.TabStop = false;
            this.gbxItemAdd.Text = "Ürün Ekle";
            // 
            // cbxAddTax
            // 
            this.cbxAddTax.FormattingEnabled = true;
            this.cbxAddTax.Location = new System.Drawing.Point(128, 93);
            this.cbxAddTax.Name = "cbxAddTax";
            this.cbxAddTax.Size = new System.Drawing.Size(110, 21);
            this.cbxAddTax.TabIndex = 3;
            this.cbxAddTax.SelectedIndexChanged += new System.EventHandler(this.cbxAddTax_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 49);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddDescription
            // 
            this.tbxAddDescription.Location = new System.Drawing.Point(128, 167);
            this.tbxAddDescription.Multiline = true;
            this.tbxAddDescription.Name = "tbxAddDescription";
            this.tbxAddDescription.Size = new System.Drawing.Size(110, 49);
            this.tbxAddDescription.TabIndex = 9;
            this.tbxAddDescription.TextChanged += new System.EventHandler(this.tbxAddDescription_TextChanged);
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(19, 170);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(83, 13);
            this.lblAddDescription.TabIndex = 8;
            this.lblAddDescription.Text = "Ürün Açıklaması";
            // 
            // tbxAddPrice
            // 
            this.tbxAddPrice.Location = new System.Drawing.Point(128, 129);
            this.tbxAddPrice.Name = "tbxAddPrice";
            this.tbxAddPrice.Size = new System.Drawing.Size(110, 20);
            this.tbxAddPrice.TabIndex = 7;
            this.tbxAddPrice.TextChanged += new System.EventHandler(this.tbxAddPrice_TextChanged);
            this.tbxAddPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddPrice_KeyPress);
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(19, 132);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(29, 13);
            this.lblAddPrice.TabIndex = 6;
            this.lblAddPrice.Text = "Fiyat";
            // 
            // lblAddTax
            // 
            this.lblAddTax.AutoSize = true;
            this.lblAddTax.Location = new System.Drawing.Point(19, 96);
            this.lblAddTax.Name = "lblAddTax";
            this.lblAddTax.Size = new System.Drawing.Size(65, 13);
            this.lblAddTax.TabIndex = 4;
            this.lblAddTax.Text = "Vergi Miktarı";
            // 
            // tbxAddShippingWeight
            // 
            this.tbxAddShippingWeight.Location = new System.Drawing.Point(128, 58);
            this.tbxAddShippingWeight.Name = "tbxAddShippingWeight";
            this.tbxAddShippingWeight.Size = new System.Drawing.Size(110, 20);
            this.tbxAddShippingWeight.TabIndex = 2;
            this.tbxAddShippingWeight.TextChanged += new System.EventHandler(this.tbxAddShippingWeight_TextChanged);
            this.tbxAddShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddShippingWeight_KeyPress);
            // 
            // lblAddShippingWeight
            // 
            this.lblAddShippingWeight.AutoSize = true;
            this.lblAddShippingWeight.Location = new System.Drawing.Point(19, 61);
            this.lblAddShippingWeight.Name = "lblAddShippingWeight";
            this.lblAddShippingWeight.Size = new System.Drawing.Size(68, 13);
            this.lblAddShippingWeight.TabIndex = 2;
            this.lblAddShippingWeight.Text = "Kargo Ağırlığı";
            // 
            // tbxAddItemName
            // 
            this.tbxAddItemName.Location = new System.Drawing.Point(128, 23);
            this.tbxAddItemName.Name = "tbxAddItemName";
            this.tbxAddItemName.Size = new System.Drawing.Size(110, 20);
            this.tbxAddItemName.TabIndex = 1;
            this.tbxAddItemName.TextChanged += new System.EventHandler(this.tbxAddItemName_TextChanged);
            // 
            // lblIAddItemName
            // 
            this.lblIAddItemName.AutoSize = true;
            this.lblIAddItemName.Location = new System.Drawing.Point(19, 26);
            this.lblIAddItemName.Name = "lblIAddItemName";
            this.lblIAddItemName.Size = new System.Drawing.Size(48, 13);
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
            this.gbxItemUpAndDel.Location = new System.Drawing.Point(444, 216);
            this.gbxItemUpAndDel.Name = "gbxItemUpAndDel";
            this.gbxItemUpAndDel.Size = new System.Drawing.Size(344, 222);
            this.gbxItemUpAndDel.TabIndex = 2;
            this.gbxItemUpAndDel.TabStop = false;
            this.gbxItemUpAndDel.Text = "Ürün Düzenle/Sil";
            // 
            // cbxUpdateTax
            // 
            this.cbxUpdateTax.FormattingEnabled = true;
            this.cbxUpdateTax.Location = new System.Drawing.Point(128, 93);
            this.cbxUpdateTax.Name = "cbxUpdateTax";
            this.cbxUpdateTax.Size = new System.Drawing.Size(110, 21);
            this.cbxUpdateTax.TabIndex = 3;
            this.cbxUpdateTax.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateTax_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(252, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 49);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Ürün\'ü Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateDescription
            // 
            this.tbxUpdateDescription.Location = new System.Drawing.Point(128, 167);
            this.tbxUpdateDescription.Multiline = true;
            this.tbxUpdateDescription.Name = "tbxUpdateDescription";
            this.tbxUpdateDescription.Size = new System.Drawing.Size(110, 49);
            this.tbxUpdateDescription.TabIndex = 9;
            this.tbxUpdateDescription.TextChanged += new System.EventHandler(this.tbxUpdateDescription_TextChanged);
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(19, 170);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(83, 13);
            this.lblUpdateDescription.TabIndex = 8;
            this.lblUpdateDescription.Text = "Ürün Açıklaması";
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(128, 129);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(110, 20);
            this.tbxUpdatePrice.TabIndex = 7;
            this.tbxUpdatePrice.TextChanged += new System.EventHandler(this.tbxUpdatePrice_TextChanged);
            this.tbxUpdatePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUpdatePrice_KeyPress);
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(19, 132);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(29, 13);
            this.lblUpdatePrice.TabIndex = 6;
            this.lblUpdatePrice.Text = "Fiyat";
            // 
            // lblUpdateTax
            // 
            this.lblUpdateTax.AutoSize = true;
            this.lblUpdateTax.Location = new System.Drawing.Point(19, 96);
            this.lblUpdateTax.Name = "lblUpdateTax";
            this.lblUpdateTax.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateTax.TabIndex = 4;
            this.lblUpdateTax.Text = "Vergi Miktarı";
            // 
            // tbxUpdateShippingWeight
            // 
            this.tbxUpdateShippingWeight.Location = new System.Drawing.Point(128, 58);
            this.tbxUpdateShippingWeight.Name = "tbxUpdateShippingWeight";
            this.tbxUpdateShippingWeight.Size = new System.Drawing.Size(110, 20);
            this.tbxUpdateShippingWeight.TabIndex = 2;
            this.tbxUpdateShippingWeight.TextChanged += new System.EventHandler(this.tbxUpdateShippingWeight_TextChanged);
            this.tbxUpdateShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUpdateShippingWeight_KeyPress);
            // 
            // lblUpdateShippingWeight
            // 
            this.lblUpdateShippingWeight.AutoSize = true;
            this.lblUpdateShippingWeight.Location = new System.Drawing.Point(19, 61);
            this.lblUpdateShippingWeight.Name = "lblUpdateShippingWeight";
            this.lblUpdateShippingWeight.Size = new System.Drawing.Size(68, 13);
            this.lblUpdateShippingWeight.TabIndex = 2;
            this.lblUpdateShippingWeight.Text = "Kargo Ağırlığı";
            // 
            // tbxUpdateItemName
            // 
            this.tbxUpdateItemName.Location = new System.Drawing.Point(128, 23);
            this.tbxUpdateItemName.Name = "tbxUpdateItemName";
            this.tbxUpdateItemName.Size = new System.Drawing.Size(110, 20);
            this.tbxUpdateItemName.TabIndex = 1;
            this.tbxUpdateItemName.TextChanged += new System.EventHandler(this.tbxUpdateItemName_TextChanged);
            // 
            // lblUpdateItemName
            // 
            this.lblUpdateItemName.AutoSize = true;
            this.lblUpdateItemName.Location = new System.Drawing.Point(19, 26);
            this.lblUpdateItemName.Name = "lblUpdateItemName";
            this.lblUpdateItemName.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateItemName.TabIndex = 0;
            this.lblUpdateItemName.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Ürün\'ü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminItemMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxItemUpAndDel);
            this.Controls.Add(this.gbxItemAdd);
            this.Controls.Add(this.dgwItem);
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