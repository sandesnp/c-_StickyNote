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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateUser CU = new CreateUser();
            CU.ShowDialog();
            this.Close();
            
        }
        ClassLogin loginobject = new ClassLogin();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text != "" && txtpassword.Text != "")
                {
                    loginobject.Classusername = txtusername.Text;
                    loginobject.Classpassword = txtpassword.Text;

                    bool loginornot = loginobject.checkUser().Item1;
                    if (loginornot == true)
                    {
                        this.Hide();
                        int userid = loginobject.checkUser().Item2;
                        StickyNotes notesshowing = new StickyNotes(userid);
                        notesshowing.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Either password or Username is incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Please Do Not leave the Box Empty.");
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }



           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
