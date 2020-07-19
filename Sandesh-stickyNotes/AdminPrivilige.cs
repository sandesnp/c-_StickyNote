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
    public partial class AdminPrivilige : Form
    {
        private int _userid;
        public AdminPrivilige(int userid)
        {
            _userid = userid;
            InitializeComponent();
        }
        ClassAPrivilige PriviligeO = new ClassAPrivilige();
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if( txtpassword.Text=="" || txtfirstname.Text=="" || txtlastname.Text=="" || txtaddress.Text=="" || txtphoneno.Text=="")
            {
                MessageBox.Show("Please do not leave box Empty.");
                return;
            }

            
            
            
            PriviligeO.password123 = txtpassword.Text;
            PriviligeO.firstname123 = txtfirstname.Text;
            PriviligeO.lastname123 = txtlastname.Text;
            PriviligeO.address123 = txtaddress.Text;
            PriviligeO.phoneno123 = txtphoneno.Text;
            if(Rmale.Checked==true)
            {
                PriviligeO.gender123 = "Male";
            }
            else if(Rfemale.Checked==true)
            {
                PriviligeO.gender123 = "Female";
            }
            else if(Rother.Checked==true)
            {
                PriviligeO.gender123 = "Others";
            }
            
            PriviligeO.usertype123 = txtselecectedusertype.Text;
            PriviligeO.EditCertainUser();
            refreshGrid();
        }

        private void cmbusertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtselecectedusertype.Text= cmbusertype.Text;
            
        }

        private void AdminPrivilige_Load(object sender, EventArgs e)
        {
            Rother.Checked = true;
            refreshGrid();
        }
        int Userid;
        private void GridAllUsers_Click(object sender, EventArgs e)
        {
            int columnindex = GridAllUsers.CurrentCell.ColumnIndex;
            Userid = int.Parse(GridAllUsers.CurrentRow.Cells["userid123"].Value.ToString());

            
            
            DataTable dt;
            if (GridAllUsers.CurrentRow.Cells[columnindex].Value.ToString() == "Edit")
            {
                if(_userid==Userid )
                {
                    cmbusertype.Enabled = false;
                    txtpassword.Enabled = true;
                }
                else if( Userid == 1)
                {
                    txtpassword.Enabled = false;
                    cmbusertype.Enabled = false;
                }
                else
                {
                    cmbusertype.Enabled = true;
                    txtpassword.Enabled = true;
                }
                PriviligeO.CertainID = Userid;
                dt = PriviligeO.retrieveCertainUser();
                
                txtpassword.Text = dt.Rows[0][2].ToString();
                txtfirstname.Text = dt.Rows[0][3].ToString();
                txtlastname.Text = dt.Rows[0][4].ToString(); ;
                txtaddress.Text = dt.Rows[0][5].ToString();
                txtphoneno.Text = dt.Rows[0][6].ToString();
                string gender = dt.Rows[0][7].ToString();
                switch(gender)
                {
                    case "Male":
                        Rmale.Checked = true;
                        break;

                    case "Female":
                        Rfemale.Checked = true;
                        break;

                    default :
                        Rother.Checked = true;
                        break;
                    
                }
                string usertype = dt.Rows[0][8].ToString();
                switch(usertype)
                {
                    case "1":
                        txtselecectedusertype.Text = "Admin";
                        break;

                    default :
                        txtselecectedusertype.Text = "Regular";
                        break;

                }

                
            }

            else if (GridAllUsers.CurrentRow.Cells[columnindex].Value.ToString() == "Delete")
            {
                if (_userid != Userid)
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        PriviligeO.CertainID = Userid;
                        PriviligeO.DeleteCertainUser();
                        refreshGrid();


                    }
                }
                else
                {
                    MessageBox.Show("You cannot Delete your own Record!");
                    return;
                }
               
            }
        }

        public void refreshGrid()
        {
            DataTable dt = PriviligeO.retrieveUsers();
            GridAllUsers.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes gotonotes = new StickyNotes(_userid);
            gotonotes.ShowDialog();
            this.Close();
        }

       

      



      

        private void txtfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtusername_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtpassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
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

      
    }
}
