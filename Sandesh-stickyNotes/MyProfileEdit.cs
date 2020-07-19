using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandesh_stickyNotes
{
    public partial class MyProfileEdit : Form
    {
        private int _userid;
        public MyProfileEdit(int userid)
        {
            _userid = userid;
            InitializeComponent();
        }
        ClassMyProfileE gotoCMPE = new ClassMyProfileE();

        private void MyProfileEdit_Load(object sender, EventArgs e)
        {

            
            txtpassword.Enabled = false;
            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            txtaddress.Enabled = false;
            txtphoneno.Enabled = false;
            Rmale.Enabled = false;
            Rfemale.Enabled = false;
            Rother.Enabled = false;
            
            
               
            gotoCMPE.userid123 = _userid;
            DataTable dt = gotoCMPE.retrieveCertainUser();
            
            txtpassword.Text = dt.Rows[0][2].ToString();
            txtfirstname.Text = dt.Rows[0][3].ToString();
            txtlastname.Text = dt.Rows[0][4].ToString(); ;
            txtaddress.Text = dt.Rows[0][5].ToString();
            txtphoneno.Text = dt.Rows[0][6].ToString();
            string gender = dt.Rows[0][7].ToString();
            switch (gender)
            {
                case "Male":
                    Rmale.Checked = true;
                    break;

                case "Female":
                    Rfemale.Checked = true;
                    break;

                default:
                    Rother.Checked = true;
                    break;

            }

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (btnSaveUpdate.Text == "Change")
            {
                btnSaveUpdate.Text = "Update";
                
                txtpassword.Enabled = true;
                txtfirstname.Enabled = true;
                txtlastname.Enabled = true;
                txtaddress.Enabled = true;
                txtphoneno.Enabled = true;
                Rmale.Enabled = true;
                Rfemale.Enabled = true;
                Rother.Enabled = true;
            }
            else if (btnSaveUpdate.Text == "Update")
            {

                if (txtpassword.Text == "" || txtfirstname.Text == "" || txtlastname.Text == "" || txtaddress.Text == "" || txtphoneno.Text == "")
                {
                    MessageBox.Show("Please do not leave box Empty.");
                    return;
                }



                
                gotoCMPE.password123 = txtpassword.Text;
                gotoCMPE.firstname123 = txtfirstname.Text;
                gotoCMPE.lastname123 = txtlastname.Text;
                gotoCMPE.address123 = txtaddress.Text;
                gotoCMPE.phoneno123 = txtphoneno.Text;
                if (Rmale.Checked == true)
                {
                    gotoCMPE.gender123 = "Male";
                }
                else if (Rfemale.Checked == true)
                {
                    gotoCMPE.gender123 = "Female";
                }
                else if (Rother.Checked == true)
                {
                    gotoCMPE.gender123 = "Others";
                }
                gotoCMPE.EditCertainUser();
                MessageBox.Show("Updated.");



                btnSaveUpdate.Text = "Change";
                
                txtpassword.Enabled = false;
                txtfirstname.Enabled = false;
                txtlastname.Enabled = false;
                txtaddress.Enabled = false;
                txtphoneno.Enabled = false;
                Rmale.Enabled = false;
                Rfemale.Enabled = false;
                Rother.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes gotoSn = new StickyNotes(_userid);
            gotoSn.ShowDialog();
            this.Close();
           
        }

       

       

        private void txtpassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtfirstname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtlastname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtaddress_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtphoneno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
