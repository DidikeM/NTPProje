﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomation.Entities.Dal;

namespace OrderAutomation.Forms
{
    public partial class AdminCustomerMenageForm : Form
    {
        public AdminCustomerMenageForm()
        {
            InitializeComponent();
        }

        private CustomerDal _customerDal = new CustomerDal();
        private OrderDal _orderDal = new OrderDal();
        private OrderDetailDal _orderDetailDal = new OrderDetailDal();

        private void AdminCustomerMenageForm_Load(object sender, EventArgs e)
        {
            LoadCustomerDgw();
        }

        private void LoadCustomerDgw()
        {
            dgwCustomer.DataSource = _customerDal.GetAll();
        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrderDgw();
        }

        private void LoadOrderDgw()
        {
            dgwOrder.DataSource = _orderDal.GetByCustomerID(Convert.ToInt32(dgwCustomer.CurrentRow.Cells[0].Value));
        }

        private void dgwOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrderDetailDgw();
        }

        private void LoadOrderDetailDgw()
        {
            dgwOrderDetail.DataSource = _orderDetailDal.GetByOrderID(Convert.ToInt32(dgwOrder.CurrentRow.Cells[0].Value));
        }
    }
}
