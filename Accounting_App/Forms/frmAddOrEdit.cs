using Accounting_DataLayer;
using Accounting_DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting_App
{
    public partial class frmAddOrEdit : Form
    {
        string filename = "no-profile-image.gif";
        public int customerId = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (!(customerId == 0))
            {
                this.Text = "ویرایش شخص";
                button1.Text = "ویرایش";
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Customers person = unitOfWork.CustomerRepository.GetCustomersById(customerId);
                    txtAddress.Text = person.address;
                    txtEmail.Text = person.email;
                    txtFullname.Text = person.fullname;
                    txtMobile.Text = person.mobile;
                    txtFathername.Text = person.fathername;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + person.customer_image;
                }
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png|JPG|*.jpg"; // "Text files (*.txt)|*.txt|All files (*.*)|*.*"'
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFileDialog.FileName;
                filename = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
               //if (txtMobile.Text)
                {

                }
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + filename);
               
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (customerId == 0)
                    {
                        Customers customers = new Customers()
                        {
                            address = txtAddress.Text,
                            customer_image = filename,
                            email = txtEmail.Text,
                            fathername = txtFathername.Text,
                            fullname = txtFullname.Text,
                            mobile = txtMobile.Text
                        };
                        db.CustomerRepository.InsertCustomer(customers);
                    }
                    else
                    {
                        Customers customers = new Customers()
                        {
                            id = customerId,
                            address = txtAddress.Text,
                            customer_image = filename,
                            email = txtEmail.Text,
                            fathername = txtFathername.Text,
                            fullname = txtFullname.Text,
                            mobile = txtMobile.Text
                        };
                        db.CustomerRepository.UpdateCustomer(customers);
                    }
                    db.save();
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
