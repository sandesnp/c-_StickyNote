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
    public partial class CreateCategory : Form
    {
        private int _userid;
        public CreateCategory(int useridd)
        {
            _userid = useridd;
            InitializeComponent();
        }
        ClassCategory gotoclasscategory = new ClassCategory();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcategory.Text != "")
            {
                gotoclasscategory.category123 = txtcategory.Text;
                gotoclasscategory.userid123 = _userid;
                string existing = gotoclasscategory.insertcategory();
                if (existing == "success")
                {

                    MessageBox.Show("Created!");
                    StickyNotes gotoclassnotes = new StickyNotes(_userid);

                }
                else
                {
                    MessageBox.Show(existing);
                }
            }
            else
            {
                MessageBox.Show("Please Dont leave Category Empty.");
            }
            
            

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes gotonotes = new StickyNotes(_userid);
            gotonotes.ShowDialog();
            this.Close();
        }

      

       
    }
}
