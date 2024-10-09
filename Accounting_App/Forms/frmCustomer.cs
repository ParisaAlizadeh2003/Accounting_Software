using Accounting_DataLayer.Context;
using Accounting_Utility.ToShamsi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_App
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.Text = "لیست اشخاص" + "  " + DateTime.Now.ToShamsi();
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = unitOfWork.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
            txtFilter.Text = "";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                string name = dgCustomers.CurrentRow.Cells[1].Value.ToString();
                int result = Convert.ToInt32(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show($"آیا از حذف {name}  اطمینان دارید؟", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        unitOfWork.CustomerRepository.DeleteCustomer(result);
                        unitOfWork.save();
                        BindGrid();
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                dgCustomers.DataSource = unitOfWork.CustomerRepository.CustomerFilter(txtFilter.Text);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void frmCustomer_Activated(object sender, EventArgs e)
        {
            //BindGrid();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
            frmAddOrEdit.customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
