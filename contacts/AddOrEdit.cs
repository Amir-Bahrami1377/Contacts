using contacts.Repository;
using contacts.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contacts
{
    public partial class AddOrEdit : Form
    {
        IContactsRepository repository;
        public int contactId = 0;
        public AddOrEdit()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            if (contactId==0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                this.Text = "ویرایش";
                DataTable dt = repository.SelectRow(contactId);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtMobile.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtAddress.Text = dt.Rows[0][5].ToString();
                txtAge.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "ویرایش";

            }

        }
        bool ValidateInput()
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                bool isSuccess;

                if (contactId == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }
                else
                {
                    isSuccess = repository.Update(contactId, txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }

                if (isSuccess)
                {
                    MessageBox.Show("با موفقیت انجام شد","موفقیت",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات ناموفق","اخطار",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
