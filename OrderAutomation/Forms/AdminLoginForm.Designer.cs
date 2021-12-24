
namespace OrderAutomation.Forms
{
    partial class AdminLoginForm
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.gbxMenage = new System.Windows.Forms.GroupBox();
            this.gbxLogin.SuspendLayout();
            this.gbxMenage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(593, 100);
            this.gbxLogin.TabIndex = 0;
            this.gbxLogin.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Kullanıcı Adı";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(115, 39);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(329, 39);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(266, 42);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(475, 37);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(36, 35);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(138, 66);
            this.btnItem.TabIndex = 5;
            this.btnItem.Text = "Ürünler";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(224, 35);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(138, 66);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Müşteriler";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(412, 35);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(138, 66);
            this.btnTax.TabIndex = 7;
            this.btnTax.Text = "Vergiler";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // gbxMenage
            // 
            this.gbxMenage.Controls.Add(this.btnItem);
            this.gbxMenage.Controls.Add(this.btnTax);
            this.gbxMenage.Controls.Add(this.btnCustomer);
            this.gbxMenage.Location = new System.Drawing.Point(12, 145);
            this.gbxMenage.Name = "gbxMenage";
            this.gbxMenage.Size = new System.Drawing.Size(593, 136);
            this.gbxMenage.TabIndex = 8;
            this.gbxMenage.TabStop = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 332);
            this.Controls.Add(this.gbxMenage);
            this.Controls.Add(this.gbxLogin);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxMenage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.GroupBox gbxMenage;
    }
}