
namespace OrderAutomation.Forms
{
    partial class CustomerRegisterForm
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
            this.gbxUserProparties = new System.Windows.Forms.GroupBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxDescriotion = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxDistrict = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.btnCheckAndPush = new System.Windows.Forms.Button();
            this.gbxUserProparties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUserProparties
            // 
            this.gbxUserProparties.Controls.Add(this.tbxPassword);
            this.gbxUserProparties.Controls.Add(this.tbxUsername);
            this.gbxUserProparties.Controls.Add(this.tbxPhoneNumber);
            this.gbxUserProparties.Controls.Add(this.tbxName);
            this.gbxUserProparties.Controls.Add(this.lblName);
            this.gbxUserProparties.Controls.Add(this.lblPhoneNumber);
            this.gbxUserProparties.Controls.Add(this.lblPassword);
            this.gbxUserProparties.Controls.Add(this.lblUsername);
            this.gbxUserProparties.Location = new System.Drawing.Point(12, 12);
            this.gbxUserProparties.Name = "gbxUserProparties";
            this.gbxUserProparties.Size = new System.Drawing.Size(320, 282);
            this.gbxUserProparties.TabIndex = 0;
            this.gbxUserProparties.TabStop = false;
            this.gbxUserProparties.Text = "Kullanıcı Bilgileri";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(132, 142);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 7;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(132, 109);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 6;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(132, 70);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxPhoneNumber.TabIndex = 5;
            this.tbxPhoneNumber.TextChanged += new System.EventHandler(this.tbxPhoneNumber_TextChanged);
            this.tbxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(132, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 4;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ad Soyad";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 73);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(90, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Telefon Numarası";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxDescriotion);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.tbxNo);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.tbxStreet);
            this.groupBox1.Controls.Add(this.tbxDistrict);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.tbxCountry);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.lblDistrict);
            this.groupBox1.Location = new System.Drawing.Point(393, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 282);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // tbxDescriotion
            // 
            this.tbxDescriotion.Location = new System.Drawing.Point(132, 217);
            this.tbxDescriotion.Name = "tbxDescriotion";
            this.tbxDescriotion.Size = new System.Drawing.Size(100, 20);
            this.tbxDescriotion.TabIndex = 11;
            this.tbxDescriotion.TextChanged += new System.EventHandler(this.tbxDescriotion_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 220);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(50, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Açıklama";
            // 
            // tbxNo
            // 
            this.tbxNo.Location = new System.Drawing.Point(132, 179);
            this.tbxNo.Name = "tbxNo";
            this.tbxNo.Size = new System.Drawing.Size(100, 20);
            this.tbxNo.TabIndex = 9;
            this.tbxNo.TextChanged += new System.EventHandler(this.tbxNo_TextChanged);
            this.tbxNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNo_KeyPress);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(6, 182);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(21, 13);
            this.lblNo.TabIndex = 8;
            this.lblNo.Text = "No";
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(132, 142);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(100, 20);
            this.tbxStreet.TabIndex = 7;
            this.tbxStreet.TextChanged += new System.EventHandler(this.tbxStreet_TextChanged);
            // 
            // tbxDistrict
            // 
            this.tbxDistrict.Location = new System.Drawing.Point(132, 109);
            this.tbxDistrict.Name = "tbxDistrict";
            this.tbxDistrict.Size = new System.Drawing.Size(100, 20);
            this.tbxDistrict.TabIndex = 6;
            this.tbxDistrict.TextChanged += new System.EventHandler(this.tbxDistrict_TextChanged);
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(132, 70);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 20);
            this.tbxCity.TabIndex = 5;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(132, 37);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(100, 20);
            this.tbxCountry.TabIndex = 4;
            this.tbxCountry.TextChanged += new System.EventHandler(this.tbxCountry_TextChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(6, 40);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(29, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Ülke";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 73);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(12, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "İl";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 145);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(75, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Cadde, Sokak";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(6, 112);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(24, 13);
            this.lblDistrict.TabIndex = 0;
            this.lblDistrict.Text = "İlçe";
            // 
            // btnCheckAndPush
            // 
            this.btnCheckAndPush.Location = new System.Drawing.Point(525, 326);
            this.btnCheckAndPush.Name = "btnCheckAndPush";
            this.btnCheckAndPush.Size = new System.Drawing.Size(188, 55);
            this.btnCheckAndPush.TabIndex = 9;
            this.btnCheckAndPush.Text = "Gönder";
            this.btnCheckAndPush.UseVisualStyleBackColor = true;
            this.btnCheckAndPush.Click += new System.EventHandler(this.btnCheckAndPush_Click);
            // 
            // CustomerRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckAndPush);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxUserProparties);
            this.Name = "CustomerRegisterForm";
            this.Text = "CustomerRegisterForm";
            this.Load += new System.EventHandler(this.CustomerRegisterForm_Load);
            this.gbxUserProparties.ResumeLayout(false);
            this.gbxUserProparties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUserProparties;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxDescriotion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxDistrict;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Button btnCheckAndPush;
    }
}