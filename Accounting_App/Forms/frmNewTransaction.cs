using Accounting_DataLayer;
using Accounting_DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting_App
{
    public partial class frmNewTransaction : Form
    {
        public int state = 0;
        UnitOfWork db;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvNameOfCustomer.AutoGenerateColumns = false;
            //dataGridView1.DataSource = db.CustomerRepository.GetAllCustomers();
            //var result = db.CustomerRepository.GetCustomerByName();
            //foreach (var name in result)
            //{
            //    dataGridView1.Rows.Add(name);
            //}
            dgvNameOfCustomer.DataSource = db.CustomerRepository.GetCustomerByName();
            if (state == 0)
            {
                this.Text = "ثبت تراکنش جدید";

            }
            else
            {
                button1.Text = "ویرایش";
                this.Text = "ویرایش تراکنش";
                var result = db.GenericRepositoty.GetById(state);
               // txtName.Text = db.CustomerRepository.GetNameById(result.Customer_Id);
                txtDescription.Text = result.C_Description;
                numPrice.Value = result.Amount;
                dtpOne.Value = result.DateTime;
                var c = result.C_Type_Id == 1 ? rbPay.Checked = true : rbRecive.Checked = true;
            }
            db.Dispose();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            //var result = db.CustomerRepository.GetCustomerByName(txtFilter.Text);
            //dataGridView1.Rows.Clear();
            //foreach (var name in result)
            //{
            //    dataGridView1.Rows.Add(name);
            //}
            dgvNameOfCustomer.DataSource = db.CustomerRepository.GetCustomerByName(txtFilter.Text);
            db.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtFilter.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvNameOfCustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    db = new UnitOfWork();
                    Accounting accounting = new Accounting()
                    {
                        C_Type_Id = rbPay.Checked ? 1 : 2,
                        Customer_Id = db.CustomerRepository.GetIdCustomerByName(txtName.Text),
                        Amount = int.Parse(numPrice.Value.ToString()),
                        C_Description = txtDescription.Text,
                        DateTime = dtpOne.Value
                    };
                    if (state == 0)
                    {
                        db.GenericRepositoty.Insert(accounting);
                    }
                    else
                    {
                        accounting.Accounting_Id = state;
                        db.GenericRepositoty.Update(accounting);

                    }

                    db.save();
                    DialogResult = DialogResult.OK;
                    db.Dispose();
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Stop,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
        }
    }
}
