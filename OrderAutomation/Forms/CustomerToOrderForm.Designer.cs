
namespace OrderAutomation.Forms
{
    partial class CustomerToOrderForm
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
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblShippingWeight = new System.Windows.Forms.Label();
            this.lblIItemName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.lblPriceText = new System.Windows.Forms.Label();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblShippingWeightText = new System.Windows.Forms.Label();
            this.lblIItemNameText = new System.Windows.Forms.Label();
            this.dgwOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnToOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.gbxItemAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).BeginInit();
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
            this.dgwItem.Size = new System.Drawing.Size(730, 315);
            this.dgwItem.TabIndex = 0;
            this.dgwItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellClick);
            // 
            // gbxItemAdd
            // 
            this.gbxItemAdd.Controls.Add(this.tbxQuantity);
            this.gbxItemAdd.Controls.Add(this.lblQuantityText);
            this.gbxItemAdd.Controls.Add(this.lblDescription);
            this.gbxItemAdd.Controls.Add(this.lblPrice);
            this.gbxItemAdd.Controls.Add(this.lblTax);
            this.gbxItemAdd.Controls.Add(this.lblShippingWeight);
            this.gbxItemAdd.Controls.Add(this.lblIItemName);
            this.gbxItemAdd.Controls.Add(this.btnAdd);
            this.gbxItemAdd.Controls.Add(this.lblDescriptionText);
            this.gbxItemAdd.Controls.Add(this.lblPriceText);
            this.gbxItemAdd.Controls.Add(this.lblTaxText);
            this.gbxItemAdd.Controls.Add(this.lblShippingWeightText);
            this.gbxItemAdd.Controls.Add(this.lblIItemNameText);
            this.gbxItemAdd.Location = new System.Drawing.Point(778, 18);
            this.gbxItemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItemAdd.Name = "gbxItemAdd";
            this.gbxItemAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxItemAdd.Size = new System.Drawing.Size(483, 315);
            this.gbxItemAdd.TabIndex = 2;
            this.gbxItemAdd.TabStop = false;
            this.gbxItemAdd.Text = "Ürün Ekle";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxQuantity.Location = new System.Drawing.Point(212, 213);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(148, 26);
            this.tbxQuantity.TabIndex = 17;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityText.Location = new System.Drawing.Point(54, 211);
            this.lblQuantityText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(145, 27);
            this.lblQuantityText.TabIndex = 16;
            this.lblQuantityText.Text = "Sipariş Adedi:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(207, 171);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(24, 27);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "_";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(207, 134);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 27);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "_";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(207, 98);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(24, 27);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "_";
            // 
            // lblShippingWeight
            // 
            this.lblShippingWeight.AutoSize = true;
            this.lblShippingWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingWeight.Location = new System.Drawing.Point(207, 61);
            this.lblShippingWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingWeight.Name = "lblShippingWeight";
            this.lblShippingWeight.Size = new System.Drawing.Size(24, 27);
            this.lblShippingWeight.TabIndex = 12;
            this.lblShippingWeight.Text = "_";
            // 
            // lblIItemName
            // 
            this.lblIItemName.AutoSize = true;
            this.lblIItemName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIItemName.Location = new System.Drawing.Point(207, 24);
            this.lblIItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIItemName.Name = "lblIItemName";
            this.lblIItemName.Size = new System.Drawing.Size(24, 27);
            this.lblIItemName.TabIndex = 11;
            this.lblIItemName.Text = "_";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(150, 258);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 47);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionText.Location = new System.Drawing.Point(21, 171);
            this.lblDescriptionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(178, 27);
            this.lblDescriptionText.TabIndex = 8;
            this.lblDescriptionText.Text = "Ürün Açıklaması:";
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceText.Location = new System.Drawing.Point(123, 134);
            this.lblPriceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(67, 27);
            this.lblPriceText.TabIndex = 6;
            this.lblPriceText.Text = "Fiyat:";
            // 
            // lblTaxText
            // 
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxText.Location = new System.Drawing.Point(55, 98);
            this.lblTaxText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(144, 27);
            this.lblTaxText.TabIndex = 4;
            this.lblTaxText.Text = "Vergi Miktarı:";
            // 
            // lblShippingWeightText
            // 
            this.lblShippingWeightText.AutoSize = true;
            this.lblShippingWeightText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingWeightText.Location = new System.Drawing.Point(46, 61);
            this.lblShippingWeightText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingWeightText.Name = "lblShippingWeightText";
            this.lblShippingWeightText.Size = new System.Drawing.Size(153, 27);
            this.lblShippingWeightText.TabIndex = 2;
            this.lblShippingWeightText.Text = "Kargo Ağırlığı:";
            // 
            // lblIItemNameText
            // 
            this.lblIItemNameText.AutoSize = true;
            this.lblIItemNameText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIItemNameText.Location = new System.Drawing.Point(93, 24);
            this.lblIItemNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIItemNameText.Name = "lblIItemNameText";
            this.lblIItemNameText.Size = new System.Drawing.Size(106, 27);
            this.lblIItemNameText.TabIndex = 0;
            this.lblIItemNameText.Text = "Ürün Adı:";
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(18, 368);
            this.dgwOrderDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.RowHeadersWidth = 62;
            this.dgwOrderDetail.Size = new System.Drawing.Size(730, 315);
            this.dgwOrderDetail.TabIndex = 3;
            // 
            // btnToOrder
            // 
            this.btnToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnToOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToOrder.Location = new System.Drawing.Point(887, 516);
            this.btnToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(264, 100);
            this.btnToOrder.TabIndex = 4;
            this.btnToOrder.Text = "SİPARİŞİ TAMAMLA";
            this.btnToOrder.UseVisualStyleBackColor = false;
            this.btnToOrder.Click += new System.EventHandler(this.btnToOrder_Click);
            // 
            // CustomerToOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1515, 702);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.gbxItemAdd);
            this.Controls.Add(this.dgwItem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerToOrderForm";
            this.Text = "CustomerToOrder";
            this.Load += new System.EventHandler(this.CustomerToOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.gbxItemAdd.ResumeLayout(false);
            this.gbxItemAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.GroupBox gbxItemAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Label lblPriceText;
        private System.Windows.Forms.Label lblTaxText;
        private System.Windows.Forms.Label lblShippingWeightText;
        private System.Windows.Forms.Label lblIItemNameText;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblShippingWeight;
        private System.Windows.Forms.Label lblIItemName;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.DataGridView dgwOrderDetail;
        private System.Windows.Forms.Button btnToOrder;
    }
}