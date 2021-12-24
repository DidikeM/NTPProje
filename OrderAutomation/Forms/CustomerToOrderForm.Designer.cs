﻿
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
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Location = new System.Drawing.Point(12, 12);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.Size = new System.Drawing.Size(487, 205);
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
            this.gbxItemAdd.Location = new System.Drawing.Point(516, 12);
            this.gbxItemAdd.Name = "gbxItemAdd";
            this.gbxItemAdd.Size = new System.Drawing.Size(344, 205);
            this.gbxItemAdd.TabIndex = 2;
            this.gbxItemAdd.TabStop = false;
            this.gbxItemAdd.Text = "Ürün Ekle";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(109, 144);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxQuantity.TabIndex = 17;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.AutoSize = true;
            this.lblQuantityText.Location = new System.Drawing.Point(19, 148);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(71, 13);
            this.lblQuantityText.TabIndex = 16;
            this.lblQuantityText.Text = "Sipariş Adedi:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(106, 122);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(13, 13);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "_";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(106, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(13, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "_";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(106, 75);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(13, 13);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "_";
            // 
            // lblShippingWeight
            // 
            this.lblShippingWeight.AutoSize = true;
            this.lblShippingWeight.Location = new System.Drawing.Point(106, 51);
            this.lblShippingWeight.Name = "lblShippingWeight";
            this.lblShippingWeight.Size = new System.Drawing.Size(13, 13);
            this.lblShippingWeight.TabIndex = 12;
            this.lblShippingWeight.Text = "_";
            // 
            // lblIItemName
            // 
            this.lblIItemName.AutoSize = true;
            this.lblIItemName.Location = new System.Drawing.Point(106, 26);
            this.lblIItemName.Name = "lblIItemName";
            this.lblIItemName.Size = new System.Drawing.Size(13, 13);
            this.lblIItemName.TabIndex = 11;
            this.lblIItemName.Text = "_";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 21);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Location = new System.Drawing.Point(19, 122);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(86, 13);
            this.lblDescriptionText.TabIndex = 8;
            this.lblDescriptionText.Text = "Ürün Açıklaması:";
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Location = new System.Drawing.Point(19, 98);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(32, 13);
            this.lblPriceText.TabIndex = 6;
            this.lblPriceText.Text = "Fiyat:";
            // 
            // lblTaxText
            // 
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(19, 75);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(68, 13);
            this.lblTaxText.TabIndex = 4;
            this.lblTaxText.Text = "Vergi Miktarı:";
            // 
            // lblShippingWeightText
            // 
            this.lblShippingWeightText.AutoSize = true;
            this.lblShippingWeightText.Location = new System.Drawing.Point(19, 51);
            this.lblShippingWeightText.Name = "lblShippingWeightText";
            this.lblShippingWeightText.Size = new System.Drawing.Size(71, 13);
            this.lblShippingWeightText.TabIndex = 2;
            this.lblShippingWeightText.Text = "Kargo Ağırlığı:";
            // 
            // lblIItemNameText
            // 
            this.lblIItemNameText.AutoSize = true;
            this.lblIItemNameText.Location = new System.Drawing.Point(19, 26);
            this.lblIItemNameText.Name = "lblIItemNameText";
            this.lblIItemNameText.Size = new System.Drawing.Size(51, 13);
            this.lblIItemNameText.TabIndex = 0;
            this.lblIItemNameText.Text = "Ürün Adı:";
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(12, 239);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.Size = new System.Drawing.Size(487, 205);
            this.dgwOrderDetail.TabIndex = 3;
            // 
            // btnToOrder
            // 
            this.btnToOrder.Location = new System.Drawing.Point(561, 404);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(94, 23);
            this.btnToOrder.TabIndex = 4;
            this.btnToOrder.Text = "Siparişi Tamamla";
            this.btnToOrder.UseVisualStyleBackColor = true;
            this.btnToOrder.Click += new System.EventHandler(this.btnToOrder_Click);
            // 
            // CustomerToOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 456);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.gbxItemAdd);
            this.Controls.Add(this.dgwItem);
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