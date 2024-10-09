using Accounting_Bussines;
using Accounting_DataLayer;
using Accounting_DataLayer.Context;
using Accounting_Utility.ToShamsi;
using Accounting_ViewModel.Accounting;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Report()
        {
            ReportViewModel reportView = Account.report();
            lbl_Incoming.Text = reportView.Incoming.ToString("#,0") + " تومان";
            lbl_Payments.Text = reportView.Payeing.ToString("#,0") + " تومان";
            lbl_Remain.Text = reportView.Remain.ToString("#,0") + " تومان";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Report();
            label5.Text = DateTime.Now.ToShamsi();
            this.Text = "حسابداری من" + "  " + DateTime.Now.ToShamsi();
            this.Hide();
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            if (frmNewTransaction.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.frmId = 1;
            frmReport.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.frmId = 2;
            frmReport.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            this.Font = fontDialog.Font;
            toolStrip2.Font = fontDialog.Font;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.Second.ToString()
                + " : " + DateTime.Now.Minute.ToString()
                + " : " + DateTime.Now.Hour.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Report();
        }
    }
}
