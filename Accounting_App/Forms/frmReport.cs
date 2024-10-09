using Accounting_DataLayer;
using Accounting_DataLayer.Context;
using Accounting_Utility.ToShamsi;
using Accounting_ViewModel;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Events;

namespace Accounting_App
{
    public partial class frmReport : Form
    {
        public int frmId = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (frmId == 1)
            {
                this.Text = "گزارش پرداختی ها";
            }
            else if (frmId == 2)
            {
                this.Text = "گزارش دریافتی ها";
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                // string[] result = db.CustomerRepository.GetAllCustomers().Select(n => n.fullname).ToArray();
                //  cmbName.Items.AddRange(result);
                List<ListCustomerViewModel> lists = new List<ListCustomerViewModel>();
                lists.Add(new ListCustomerViewModel { ID = 0, Fullname = " طرف حساب را انتخاب کنید" });
                lists.AddRange(db.CustomerRepository.GetCustomerByName());
                cmbName.DataSource = lists;
                cmbName.DisplayMember = "Fullname";
                cmbName.ValueMember = "ID";
            }
            filter();

        }

        public void filter()
        {

            dg_Report.Rows.Clear();


            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting> result = new List<Accounting>();
                DateTime? startDate;
                DateTime? endDate;
                if ((int)cmbName.SelectedValue != 0)
                {
                    int id = int.Parse(cmbName.SelectedValue.ToString());
                    result.AddRange(db.GenericRepositoty.Get(i => i.C_Type_Id == frmId && i.Customer_Id == id));
                }
                else
                {
                    result.AddRange(db.GenericRepositoty.Get(i => i.C_Type_Id == frmId));
                }
                if (mtxtFDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(mtxtFDate.Text);
                    startDate = DataToShamsi.Tomiladi(startDate.Value);
                    result = result.Where(i => i.DateTime >= startDate.Value).ToList();
                }
                if (mtxtTDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(mtxtTDate.Text);
                    endDate = DataToShamsi.Tomiladi(endDate.Value);
                    result = result.Where(i => i.DateTime < endDate.Value || i.DateTime == endDate.Value).ToList();
                }

                foreach (var item in result)
                {
                    var fullname = db.CustomerRepository.GetNameById((int)item.Customer_Id);
                    var date = item.DateTime.ToShamsi();
                    dg_Report.Rows.Add(item.Accounting_Id, fullname, item.Amount, date, item.C_Description);
                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dg_Report.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف این کاربر مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.GenericRepositoty.Delete(int.Parse(dg_Report.CurrentRow.Cells[0].Value.ToString()));
                        db.save();

                    }
                    filter();
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dg_Report.CurrentRow != null)
            {
                frmNewTransaction frmNew = new frmNewTransaction();
                frmNew.state = int.Parse(dg_Report.CurrentRow.Cells[0].Value.ToString());
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    filter();
                }
            }
        }

        private void mtxtFDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter();

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Description");
            foreach (DataGridViewRow item in dg_Report.Rows)
            {
                dataTable.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            stiReport1.RegData("DT", dataTable);
            stiReport1.Load(Application.StartupPath + "/Report.mrt");
            stiReport1.Show();
        }
    }
}
