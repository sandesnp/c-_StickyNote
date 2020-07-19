using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sandesh_stickyNotes
{
    public partial class StickyNotes : Form
    {
        private int _userid;
        //private string _enablenotes;

        ClassNotes gotoclassnotes = new ClassNotes();
        public StickyNotes(int username)
        {
            //_enablenotes = enablingnotes;
            _userid = username;
            InitializeComponent();
        }
       // int a = 10, b = 50;
        private void txtmainpanel_Paint(object sender, PaintEventArgs e)
        {
           // returning(a, b);
        }

        


        private void StickyNotes_Load(object sender, EventArgs e)
        {
            gotoclassnotes.userid123 = _userid;
            //Admin menu will only be enabled if its loggod on by admin himself.
            string checkUserType = gotoclassnotes.usernameofthisID().Item2;
            if (checkUserType == "1")
            {   MIadminprivileges.Enabled = true;   }

            else

            {   MIadminprivileges.Enabled = false;  }


            
            txtusername1.Text =gotoclassnotes.usernameofthisID().Item1;


            refreshpanal();
            
        }
        int widthCP = 10;
        int height = 60;

        private Boolean refreshcmb = false;




        public void refreshpanal()
        {

            //This is for Enabling and disabling Note button.
            //gotoclassnotes.userid123 = _userid;
            string check = gotoclassnotes.example1();
            if (check == "existingcategory")
            {
                btnaddnote.Enabled = true;
            }
            else
            {
               
                btnaddnote.Enabled = false;
                
            }
            

            //giving category options


            if (refreshcmb == false)
            {
                cmbcategory.DataSource = gotoclassnotes.comboboxcategory();
                cmbcategory.DisplayMember = "category";
                cmbcategory.ValueMember = "categoryid";
            }
            else { refreshcmb = false; }

            //-----------------------for loading notes

            bool checking = gotoclassnotes.firsttimenotes();
            if (checking == true)
            {

                checking321 = gotoclassnotes.checkins12345();
                if (checking321 == true)
                {
                    
                    widthCP = 10;
                    height = 60;
                }



                 widthCPnotes = gotoclassnotes.countnotes();


                for ( i = 0; i < widthCPnotes; i++)
                {
                    //&& height < txtmainpanel.Height  Removed this from bottom two.

                    if (widthCP < txtmainpanel.Width )
                    {
                        widthCP = childpanel12(widthCP, height).Item1;
                    }
                    else if (widthCP > txtmainpanel.Width )
                    {

                        //widthCP = 10;

                        height = childpanel12(10, height + 320).Item2;

                        widthCP = 320;

                    }


                }
            }
            else
            {
                return;
            }
        }



        public int widthCPnotes;
        public int i;



        int ContentRow = 0;
        Boolean checking321;
        public Tuple<int,int> childpanel12(int x, int y)
        {


            checking321 = gotoclassnotes.checkins12345();
            if (checking321 == true)
            {
                ContentRow = 0;
                //x = 10;
                //y = 50;
            }
            gotoclassnotes.checks123 = false;
            if (y < txtmainpanel.Height)
            {
                //int fla = ContentRow;
                DataTable dt = gotoclassnotes.retrivenoteid();
                int noteid = int.Parse(dt.Rows[ContentRow][0].ToString());
                string userid1011 = noteid.ToString();


                gotoclassnotes.noteid123 = noteid;
                DataTable dt2 = gotoclassnotes.retrivecontent();
                string contentx = dt2.Rows[0][0].ToString();
                string titlex = dt2.Rows[0][1].ToString();

                Panel childpanel = new Panel();
                childpanel.Location = new Point(x, y);
                childpanel.BackColor = Color.AliceBlue;
                childpanel.Size = new Size(300, 300);

                Label lbltitle = new Label();
                lbltitle.Text = "Category: "+cmbcategory.Text;;
                lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbltitle.Size = new Size(200, 20);
                lbltitle.Location = new Point(10, 10);

                TextBox txttitle = new TextBox();
                txttitle.Text = titlex;
                txttitle.Size = new Size(200, 20);
                txttitle.Location = new Point(50, 50);

               
                TextBox txtcontent = new TextBox();
                txtcontent.Text = contentx;
                txtcontent.Name = userid1011;
                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(50, 70);
                txtcontent.Multiline = true;

                RadioButton sticked = new RadioButton();
                sticked.Text = "Stickied";
                sticked.Name = "txtsticked";
                sticked.Location = new Point(50, 220);
                sticked.Checked = true;

                RadioButton completed = new RadioButton();
                completed.Text = "Completed";
                completed.Name = "txtcompleted";
                completed.Location = new Point(110, 220);

                Button btn = new Button();
                btn.Text = "Save";
                btn.Name = userid1011;
                btn.Location = new Point(50, 250);
                btn.Click += (s, a) =>
                {
                    if (completed.Checked == true)
                    {
                        gotoclassnotes.ifcomplete123 = "true";
                        

                    }
                    else if (sticked.Checked == true)
                    {
                        gotoclassnotes.ifcomplete123 = "false";
                    }
                    else if(sticked.Checked==false && completed.Checked==false)
                    {
                        MessageBox.Show("Please choose one of the option!");
                        return;
                    }

                    
                    
                    int editid = int.Parse(btn.Name);

                    gotoclassnotes.receivenoteid = editid;

                    gotoclassnotes.contents321 = txtcontent.Text;
                    gotoclassnotes.titleABC = txttitle.Text;
                    gotoclassnotes.manipulateedit();
                    MessageBox.Show("Edited");
                    if (completed.Checked == true)
                    {
                        gotoclassnotes.checks123 = true;
                        txtmainpanel.Controls.Clear();
                        refreshpanal();

                    }



                };
                //in every delete/ btn2 button the saved noteid is encoded in the form of their name.
                Button btn2 = new Button();
                btn2.Text = "Delete";
                btn2.Name = userid1011;
                btn2.Location = new Point(200, 250);
                btn2.Click += (s, a) =>
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this Note?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        int deleteid = int.Parse(btn2.Name);

                        gotoclassnotes.receivenoteid = deleteid;

                        gotoclassnotes.manipulatedelete();

                        MessageBox.Show("Deleted");

                        gotoclassnotes.checks123 = true;
                        txtmainpanel.Controls.Clear();
                        refreshpanal();


                    }


                };
                childpanel.Controls.Add(btn2);
                childpanel.Controls.Add(completed);
                childpanel.Controls.Add(sticked);
                childpanel.Controls.Add(lbltitle);
                childpanel.Controls.Add(txtcontent);
                childpanel.Controls.Add(txttitle);
                childpanel.Controls.Add(btn);


                txtmainpanel.Controls.Add(childpanel);
                x = x + childpanel.Width + 10;

                ContentRow = ContentRow + 1;

                return Tuple.Create(x, y);
                
            }
            else
            {
                return Tuple.Create(x, y);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (cmbcategory.SelectedValue.ToString() != "")
            {

                int sendcategory = int.Parse(cmbcategory.SelectedValue.ToString());

                this.Hide();
                AddingNote gonote = new AddingNote(sendcategory, _userid, cmbcategory.Text);
                gonote.ShowDialog();

                this.Close();
            }
            else { MessageBox.Show("Please create a category."); }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(loginform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

           
        }


        Thread th;
        private void createCategoryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
             CreateCategory gotocategory = new CreateCategory(_userid);
             gotocategory.ShowDialog();
            
            this.Close();


        }
        private void loginform()
        {
            Application.Run(new Login());
        }

        private void cmbcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gotoclassnotes.onecategory123= int.Parse(cmbcategory.SelectedValue.ToString());
             //DataTable dt = gotoclassnotes.findonecategory();
            txtcategory.Text = cmbcategory.Text; //dt.Rows[0][0].ToString();
            gotoclassnotes.checks123 = true;
            refreshcmb = true;
            txtmainpanel.Controls.Clear();
            refreshpanal();




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }


        private void Scategory_Click(object sender, EventArgs e)
        {
            if(Scategory.Text== "category here                                                          .")
            {
                Scategory.Text = "";
            }
        }

    

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(Scategory.Text=="")
            {
                MessageBox.Show("Please type in category.");


                Scategory.Focus();
            }
            else if(CMBsearchbox.Text=="")
            {
                MessageBox.Show("Please Choose or type in title.");
                CMBsearchbox.Focus();
            }
            else
            {
                gotoclassnotes.Scat = Scategory.Text;
                gotoclassnotes.stit = CMBsearchbox.Text;
                gotoclassnotes.checks123 = true;
                txtmainpanel.Controls.Clear();
                refreshpanal2();

            }
        }

        public void refreshpanal2()
        {


            bool istheresearchresult = gotoclassnotes.maxsearching();
            if (istheresearchresult == true)
            {
                refresh31();
                
            }
            else if(istheresearchresult==false)
            {
                MessageBox.Show("Not available.");
            }
            return;
        }


        public void refresh31()
        {
            checking321 = gotoclassnotes.checkins12345();
            if (checking321 == true)
            {

                widthCP = 10;
                height = 60;
            }



            int widthCPnotes = gotoclassnotes.countSearching();


            for (int i = 0; i < widthCPnotes; i++)
            {
                //&& height < txtmainpanel.Height  Removed this from bottom two.

                if (widthCP < txtmainpanel.Width)
                {
                    widthCP = childpanel123(widthCP, height).Item1;
                }
                else if (widthCP > txtmainpanel.Width)
                {

                    //widthCP = 10;

                    height = childpanel123(10, height + 320).Item2;

                    widthCP = 320;

                }


            }
        }


        public Tuple<int, int> childpanel123(int x, int y)
        {


            checking321 = gotoclassnotes.checkins12345();
            if (checking321 == true)
            {
                ContentRow = 0;
                //x = 10;
                //y = 50;
            }
            gotoclassnotes.checks123 = false;
            if (y < txtmainpanel.Height)
            {
                //int fla = ContentRow;
                DataTable dt = gotoclassnotes.Searching();

                string userid1011 = dt.Rows[ContentRow][0].ToString();
                string titlex = dt.Rows[ContentRow][2].ToString();
                string contentx = dt.Rows[ContentRow][3].ToString();
                
                string TorFradio = dt.Rows[ContentRow][4].ToString();


                Panel childpanel = new Panel();
                childpanel.Location = new Point(x, y);
                childpanel.BackColor = Color.AliceBlue;
                childpanel.Size = new Size(300, 300);

                Label lbltitle = new Label();
                lbltitle.Text = "Category: "+Scategory.Text;
                lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbltitle.Size = new Size(200, 20);
                lbltitle.Location = new Point(10, 10);

                TextBox txttitle = new TextBox();
                txttitle.Text = titlex;
                txttitle.Size = new Size(200, 20);
                txttitle.Location = new Point(50, 50);


                TextBox txtcontent = new TextBox();
                txtcontent.Text = contentx;
                txtcontent.Name = userid1011;
                txtcontent.Size = new Size(200, 150);
                txtcontent.Location = new Point(50, 70);
                txtcontent.Multiline = true;

                RadioButton sticked = new RadioButton();
                sticked.Text = "Stickied";
                sticked.Name = "txtsticked";
                sticked.Location = new Point(50, 220);

                RadioButton completed = new RadioButton();
                completed.Text = "Completed";
                completed.Name = "txtcompleted";
                completed.Location = new Point(110, 220);


                if(TorFradio=="True")
                {
                    sticked.Checked = true;
                }
                else
                {
                    completed.Checked = true;
                }


                Button btn = new Button();
                btn.Text = "Save";
                btn.Name = userid1011;
                btn.Location = new Point(50, 250);
                btn.Click += (s, a) =>
                {
                    if (completed.Checked == true)
                    {
                        gotoclassnotes.ifcomplete123 = "true";


                    }
                    else if (sticked.Checked == true)
                    {
                        gotoclassnotes.ifcomplete123 = "false";
                    }
                    else if (sticked.Checked == false && completed.Checked == false)
                    {
                        MessageBox.Show("Please choose one of the option!");
                        return;
                    }



                    int editid = int.Parse(btn.Name);

                    gotoclassnotes.receivenoteid = editid;

                    gotoclassnotes.contents321 = txtcontent.Text;
                    gotoclassnotes.titleABC = txttitle.Text;
                    gotoclassnotes.manipulateedit();
                    MessageBox.Show("Edited");
                    //gotoclassnotes.checks123 = true;
                    //txtmainpanel.Controls.Clear();
                    //refresh31();
                    





                };
                //in every delete/ btn2 button the saved noteid is encoded in the form of their name.
                Button btn2 = new Button();
                btn2.Text = "Delete";
                btn2.Name = userid1011;
                btn2.Location = new Point(200, 250);
                btn2.Click += (s, a) =>
                {
                    DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this Note?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {

                        int deleteid = int.Parse(btn2.Name);

                        gotoclassnotes.receivenoteid = deleteid;

                        gotoclassnotes.manipulatedelete();

                        MessageBox.Show("Deleted");

                        gotoclassnotes.checks123 = true;
                        txtmainpanel.Controls.Clear();
                        refresh31();

                    }



                };
                childpanel.Controls.Add(btn2);
                childpanel.Controls.Add(completed);
                childpanel.Controls.Add(sticked);
                childpanel.Controls.Add(lbltitle);
                childpanel.Controls.Add(txtcontent);
                childpanel.Controls.Add(txttitle);
                childpanel.Controls.Add(btn);


                txtmainpanel.Controls.Add(childpanel);
                x = x + childpanel.Width + 10;

                ContentRow = ContentRow + 1;

                return Tuple.Create(x, y);

            }
            else
            {
                return Tuple.Create(x, y);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete category, " +cmbcategory.Text+" ?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                txtcategory.Text = "Select Category";
                gotoclassnotes.deletecategory();

                txtmainpanel.Controls.Clear();
                refreshpanal();
            }
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphFoNotes graphO = new GraphFoNotes(_userid);
            graphO.ShowDialog();
        }

        private void MIadminprivileges_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPrivilige APO = new AdminPrivilige(_userid);
            APO.ShowDialog();
            this.Close();
        }

        private void profileEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfileEdit GotoMPE = new MyProfileEdit(_userid);
            GotoMPE.ShowDialog();
            this.Close();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_userid != 1)
            {
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to Delete your Account?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    gotoclassnotes.DeleteAccount();
                    this.Close();
                    th = new Thread(loginform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();



                }
            }
            else
            {
                MessageBox.Show("Sorry, Original Admin is necessary.");
            }
        }

        private void Scategory_TextChanged(object sender, EventArgs e)
        {
            if (Scategory.Text != "")
            {
                gotoclassnotes.Scat = Scategory.Text;
                DataTable dt = gotoclassnotes.ForCmbOption();
                if (dt.Rows.Count > 0)
                {
                    CMBsearchbox.DataSource = dt;
                    CMBsearchbox.DisplayMember = "Title";
                    // CMBsearchbox.ValueMember = "ItemID";
                }
            }
           
        }

       
    }
}

