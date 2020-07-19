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
    public partial class GraphFoNotes : Form
    {
       private int userid;
        public GraphFoNotes(int _userid)
        {
            //;
            userid = _userid;
            InitializeComponent();
        }
        GraphClass GC = new GraphClass();


        private void GraphFoNotes_Load(object sender, EventArgs e)
        {
            GC._username = userid;

            int thisdayC = GC.CurrentdayF().Item1;
            int thisdayS = GC.CurrentdayF().Item2;
            if (thisdayC >0 || thisdayS > 0)
            {
                double daypercentC = (thisdayC * 100) / (thisdayC + thisdayS);
                double daypercentS = 100 - daypercentC;
                notechart.Series["Completed"].Points.AddXY("Today", daypercentC);
                notechart.Series["Stickied"].Points.AddXY("Today", daypercentS);
            }
            else
            {
                notechart.Series["Completed"].Points.AddXY("Today (No Record)", 0);
                notechart.Series["Stickied"].Points.AddXY("Today (No Record)", 0);
            }






            int thisweekC = GC.thisweekF().Item1;
            int thisweekS = GC.thisweekF().Item2;
            if (thisweekC > 0 || thisweekS > 0)
            {
                double weekpercentC = (thisweekC * 100) / (thisweekC + thisweekS);
                double weekpercentS = 100 - weekpercentC;
                notechart.Series["Completed"].Points.AddXY("This Week", weekpercentC);
                notechart.Series["Stickied"].Points.AddXY("This Week", weekpercentS);
            }
            else
            {
                notechart.Series["Completed"].Points.AddXY("This Week (No Record)", 0);
                notechart.Series["Stickied"].Points.AddXY("This Week (No Record)", 0);
            }







            int thismonthC = GC.thismonthF().Item1;
            int thismonthS = GC.thismonthF().Item2;
            if (thismonthC > 0 || thisdayS > 0)
            {
                double monthpercentC = (thismonthC * 100) / (thismonthC + thismonthS);
                double monthpercentS = 100 - monthpercentC;
                notechart.Series["Completed"].Points.AddXY("This Month", monthpercentC);
                notechart.Series["Stickied"].Points.AddXY("This Month", monthpercentS);
            }
            else

            {
                notechart.Series["Completed"].Points.AddXY("This Month (No Record)", 0);
                notechart.Series["Stickied"].Points.AddXY("This Month (No Record)", 0);
            }






            
            int thisyearC = GC.thisyearF().Item1;
            int thisyearS = GC.thisyearF().Item2;
            if (thisyearC > 0 || thisyearS > 0)
            {
                double yearpercentC = (thisyearC * 100) / (thisyearC + thisyearS);
                double yearpercentS = 100 - yearpercentC;
                notechart.Series["Completed"].Points.AddXY("This Year", yearpercentC);
                notechart.Series["Stickied"].Points.AddXY("This Year", yearpercentS);

            }
            else
            {
                notechart.Series["Completed"].Points.AddXY("This Year (No Record)", 0);
                notechart.Series["Stickied"].Points.AddXY("This Year (No Record)", 0);
            }


            int thisoverrallC = GC.thisoverrallF().Item1;
            int thisoverrallS = GC.thisoverrallF().Item2;
            if (thisoverrallC > 0 || thisoverrallS > 0)
            {
                double overrallpercentC = (thisoverrallC * 100) / (thisoverrallC + thisoverrallS);
                double overrallpercentS = 100 - overrallpercentC;
                notechart.Series["Completed"].Points.AddXY("Overrall", overrallpercentC);
                notechart.Series["Stickied"].Points.AddXY("Overrall", overrallpercentS);
            }
            else
            {
                notechart.Series["Completed"].Points.AddXY("Overrall (No Record)", 0);
                notechart.Series["Stickied"].Points.AddXY("Overrall (No Record)", 0);
            }
            // MessageBox.Show(thisoverrallC.ToString()+ "     " + thisoverrallS.ToString());












        }

        
    }
}
