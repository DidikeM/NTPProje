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
    public partial class CustomerToOrder : Form
    {
        public CustomerToOrder(Customer customer)
        {
            InitializeComponent();
        }

        private ItemDal _itemDal = new ItemDal();

        private void CustomerToOrder_Load(object sender, EventArgs e)
        {
            LoadItem();
        }

        private void LoadItem()
        {
            dgwItem.DataSource = _itemDal.GetAll();
        }
    }
}
