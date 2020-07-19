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
    public partial class AddingNote : Form
    {
        private int category123;
        private int _userid1;
        private string category22;
        public AddingNote(int receivecate, int userid12, string categoryname1)
        {
            category123 = receivecate;
            _userid1 = userid12;
            category22 = categoryname1;
            InitializeComponent();
        }

        ClassNotes newnoteOB = new ClassNotes();
        private void AddingNote_Load(object sender, EventArgs e)
        {
            
            newnoteOB.onecategory123 = category123;
            newnoteOB.userid123 = _userid1;
            lbltitle.Text = category22;
            
        }









        private void button1_Click(object sender, EventArgs e)
        {
            if (sticked.Checked == true)
            {
                newnoteOB.stick123 = "true";
                newnoteOB.completed123 = "false";
            }
            else if (completed.Checked == true)
            {
                newnoteOB.stick123 = "false";
                newnoteOB.completed123 = "true";
            }
            else if (sticked.Checked == false && completed.Checked == false)
            {
                MessageBox.Show("Please choose one of the option!");
                return;
            }
            newnoteOB.title123 = txttitle.Text;
            newnoteOB.content123 = txtcontent.Text;



            newnoteOB.categoryid123 = category123;

            string Added= newnoteOB.insertnotes();
            txtcontent.Text = "";
            txttitle.Text = "";
            MessageBox.Show(Added);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes gotoSnotes = new StickyNotes(_userid1);
            gotoSnotes.ShowDialog();
            this.Close();
        }

    
    }
}
