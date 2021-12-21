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

namespace OrderAutomation.Forms
{
    public partial class DnmForm : Form
    {
        public DnmForm()
        {
            InitializeComponent();
        }

        private void DnmForm_Load(object sender, EventArgs e)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                dgwdeneme.DataSource = context.Customers.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
