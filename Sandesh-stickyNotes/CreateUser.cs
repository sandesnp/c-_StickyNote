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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        ClassCreateUser CreateUserClass = new ClassCreateUser();
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "")
            {
                MessageBox.Show("Please type in your Username.");
                txtusername.Focus();
                return;
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please type in your Password.");
                txtpassword.Focus();
                return;
            }
            else if (txtfname.Text == "")
            {
                MessageBox.Show("Please type in your First Name.");
                txtfname.Focus();
                return;
            }
            else if (txtlname.Text == "")
            {
                MessageBox.Show("Please type in your last Name.");
                txtlname.Focus();
                return;
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Please type in your Address.");
                txtaddress.Focus();
                return;
            }
            else if (txtphnumber.Text == "")
            {
                MessageBox.Show("Please type in your Phone Number.");
                txtphnumber.Focus();
                return;
            }
            else if (radiomale.Checked == false && radiofemale.Checked == false && radioothers.Checked == false)
            {
                MessageBox.Show("Please choose Gender.");
                return;
            }




            string gender="";
            if(radiomale.Checked==true)
            {
               
                gender = "Male";
            }
            else if(radiofemale.Checked==true)
            {
                gender = "Female";

            }

            else if(radioothers.Checked==true)
            {
                gender = "Others";

            }
            CreateUserClass.Classusername = txtusername.Text;
            CreateUserClass.Classpassword = txtpassword.Text;
            CreateUserClass.ClassFname = txtfname.Text;
            CreateUserClass.ClassLname = txtlname.Text;
            CreateUserClass.ClassAddress = txtaddress.Text;
            CreateUserClass.ClassPhoneNo = txtphnumber.Text;
            CreateUserClass.Classgender = gender;
            string result1 = CreateUserClass.insertuser();
            
            MessageBox.Show(result1);

        }

     

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login gotologin = new Login();
            gotologin.ShowDialog();
            this.Close();


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtphnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

       
    }
}
