namespace Sandesh_stickyNotes
{
    partial class StickyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtmainpanel = new System.Windows.Forms.Panel();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.txtusername1 = new System.Windows.Forms.Label();
            this.btnaddnote = new System.Windows.Forms.Button();
            this.txtcategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCategoryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIadminprivileges = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMBsearchbox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Scategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmainpanel
            // 
            this.txtmainpanel.AutoScroll = true;
            this.txtmainpanel.BackColor = System.Drawing.Color.LightCoral;
            this.txtmainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtmainpanel.Location = new System.Drawing.Point(0, 49);
            this.txtmainpanel.Name = "txtmainpanel";
            this.txtmainpanel.Size = new System.Drawing.Size(3037, 1161);
            this.txtmainpanel.TabIndex = 0;
            this.txtmainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.txtmainpanel_Paint);
            // 
            // cmbcategory
            // 
            this.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Items.AddRange(new object[] {
            "Category"});
            this.cmbcategory.Location = new System.Drawing.Point(16, 70);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(229, 39);
            this.cmbcategory.TabIndex = 2;
            this.cmbcategory.SelectionChangeCommitted += new System.EventHandler(this.cmbcategory_SelectionChangeCommitted);
            // 
            // txtusername1
            // 
            this.txtusername1.AutoSize = true;
            this.txtusername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername1.Location = new System.Drawing.Point(12, 11);
            this.txtusername1.Name = "txtusername1";
            this.txtusername1.Size = new System.Drawing.Size(254, 44);
            this.txtusername1.TabIndex = 4;
            this.txtusername1.Text = "Txtusername";
            // 
            // btnaddnote
            // 
            this.btnaddnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnote.Location = new System.Drawing.Point(510, 27);
            this.btnaddnote.Name = "btnaddnote";
            this.btnaddnote.Size = new System.Drawing.Size(261, 69);
            this.btnaddnote.TabIndex = 1;
            this.btnaddnote.Text = "Add Note";
            this.btnaddnote.UseVisualStyleBackColor = true;
            this.btnaddnote.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.AutoSize = true;
            this.txtcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcategory.Location = new System.Drawing.Point(6, 0);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(381, 55);
            this.txtcategory.TabIndex = 2;
            this.txtcategory.Text = "Select Category";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCategoryToolStripMenuItem,
            this.createCategoryToolStripMenuItem2,
            this.graphToolStripMenuItem,
            this.MIadminprivileges});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(3037, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createCategoryToolStripMenuItem
            // 
            this.createCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileEditToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.toolStripSeparator1,
            this.signOutToolStripMenuItem});
            this.createCategoryToolStripMenuItem.Name = "createCategoryToolStripMenuItem";
            this.createCategoryToolStripMenuItem.Size = new System.Drawing.Size(136, 45);
            this.createCategoryToolStripMenuItem.Text = "Options";
            // 
            // profileEditToolStripMenuItem
            // 
            this.profileEditToolStripMenuItem.Name = "profileEditToolStripMenuItem";
            this.profileEditToolStripMenuItem.Size = new System.Drawing.Size(286, 46);
            this.profileEditToolStripMenuItem.Text = "Profile Edit";
            this.profileEditToolStripMenuItem.Click += new System.EventHandler(this.profileEditToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(286, 46);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(286, 46);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // createCategoryToolStripMenuItem2
            // 
            this.createCategoryToolStripMenuItem2.Name = "createCategoryToolStripMenuItem2";
            this.createCategoryToolStripMenuItem2.Size = new System.Drawing.Size(245, 45);
            this.createCategoryToolStripMenuItem2.Text = "Create Category";
            this.createCategoryToolStripMenuItem2.Click += new System.EventHandler(this.createCategoryToolStripMenuItem2_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(111, 45);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
            // 
            // MIadminprivileges
            // 
            this.MIadminprivileges.Name = "MIadminprivileges";
            this.MIadminprivileges.Size = new System.Drawing.Size(241, 45);
            this.MIadminprivileges.Text = "Admin Priviliges";
            this.MIadminprivileges.Click += new System.EventHandler(this.MIadminprivileges_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtusername1);
            this.panel1.Controls.Add(this.btnaddnote);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3037, 124);
            this.panel1.TabIndex = 2;
            // 
            // CMBsearchbox
            // 
            this.CMBsearchbox.FormattingEnabled = true;
            this.CMBsearchbox.Location = new System.Drawing.Point(464, 81);
            this.CMBsearchbox.Name = "CMBsearchbox";
            this.CMBsearchbox.Size = new System.Drawing.Size(488, 39);
            this.CMBsearchbox.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete current category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(958, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = ":";
            // 
            // Scategory
            // 
            this.Scategory.Location = new System.Drawing.Point(16, 82);
            this.Scategory.Name = "Scategory";
            this.Scategory.Size = new System.Drawing.Size(402, 38);
            this.Scategory.TabIndex = 4;
            this.Scategory.Text = "category here                                                          .";
            this.Scategory.Click += new System.EventHandler(this.Scategory_Click);
            this.Scategory.TextChanged += new System.EventHandler(this.Scategory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcategory);
            this.groupBox1.Controls.Add(this.cmbcategory);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(972, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CMBsearchbox);
            this.groupBox2.Controls.Add(this.Scategory);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(2077, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1433, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".";
            // 
            // StickyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3037, 1210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtmainpanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StickyNotes";
            this.Text = "StickyNotes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StickyNotes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel txtmainpanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileEditToolStripMenuItem;
        private System.Windows.Forms.Label txtcategory;
        private System.Windows.Forms.Button btnaddnote;
        private System.Windows.Forms.Label txtusername1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MIadminprivileges;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.ToolStripMenuItem createCategoryToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Scategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ComboBox CMBsearchbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}