using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomation.Entities;
using OrderAutomation.Entities.Dal;

namespace OrderAutomation.Forms
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private Customer _customer = new Customer();
        private CustomerDal _customerDal = new CustomerDal();
        private void CusstomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz");
            }
            else
            {
                //MessageBox.Show(_customerDal.GetByUsername(tbxUsername.Text).Username);
                if (_customerDal.GetByUsername(tbxUsername.Text) == null)
                {
                    MessageBox.Show("Bu kullanıcı sisteme kayıtlı değildir.");
                }
                else if (!_customerDal.CheckByLogin(tbxUsername.Text, tbxPassword.Text))
                {
                    MessageBox.Show("Yanlış şifre girdiniz.");
                }
                else
                {
                    MessageBox.Show("Giriş başarılı");
                }
            }
        }
    }
}
