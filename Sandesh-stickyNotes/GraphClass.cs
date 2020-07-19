using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    class GraphClass
    {

        private int userid;
        private string currentday;
        private string thisweek;
        private string thismonth;
        private string overall;


        public int _username { get {return userid; } set {userid=value; } }


        
        DatabaseConnection dc = new DatabaseConnection();

        public Tuple<int,int> CurrentdayF()
        {
            try
            {
                string query1 = "select Count(noteid) from notes where datecreated='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and completed='true' and userid=" + userid;
                DataTable dt1 = dc.retrive(query1);
                int countcompletedtoday = int.Parse(dt1.Rows[0][0].ToString());

                string query2 = "select Count(noteid) from notes where datecreated='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and stickied='true' and userid=" + userid;
                DataTable dt2 = dc.retrive(query2);
                int countstickedtoday = int.Parse(dt2.Rows[0][0].ToString());
                return Tuple.Create(countcompletedtoday, countstickedtoday);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                GC.Collect();
            }



            

        }


        public Tuple<int, int> thisweekF()
        {
            try
            {
                string query1 = "select Count(noteid) from notes where datecreated>'" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + "' and completed='true' and userid=" + userid;
                DataTable dt1 = dc.retrive(query1);
                int countcompletedtoday = int.Parse(dt1.Rows[0][0].ToString());

                string query2 = "select Count(noteid) from notes where datecreated>'" + DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd") + "' and stickied='true' and userid=" + userid;
                DataTable dt2 = dc.retrive(query2);
                int countstickedtoday = int.Parse(dt2.Rows[0][0].ToString());
                return Tuple.Create(countcompletedtoday, countstickedtoday);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                GC.Collect();
            }


            

        }


        public Tuple<int, int> thismonthF()
        {
            try
            {
                string query1 = "select Count(noteid) from notes where DATEDIFF (month, datecreated, getdate()) between 0 and 0 and completed='true' and userid=" + userid;
                DataTable dt1 = dc.retrive(query1);
                int countcompletedtoday = int.Parse(dt1.Rows[0][0].ToString());

                string query2 = "select Count(noteid) from notes where DATEDIFF (month, datecreated, getdate()) between 0 and 0 and stickied='true' and userid=" + userid;
                DataTable dt2 = dc.retrive(query2);
                int countstickedtoday = int.Parse(dt2.Rows[0][0].ToString());
                return Tuple.Create(countcompletedtoday, countstickedtoday);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                GC.Collect();
            }


            

        }



        public Tuple<int, int> thisyearF()
        {
            try
            {
                string query1 = "select Count(noteid) from notes where DATEDIFF (Year, datecreated, getdate()) between 0 and 0 and completed='true' and userid=" + userid;
                DataTable dt1 = dc.retrive(query1);
                int countcompletedtoday = int.Parse(dt1.Rows[0][0].ToString());

                string query2 = "select Count(noteid) from notes where DATEDIFF (Year, datecreated, getdate()) between 0 and 0 and stickied='true' and userid=" + userid;
                DataTable dt2 = dc.retrive(query2);
                int countstickedtoday = int.Parse(dt2.Rows[0][0].ToString());
                return Tuple.Create(countcompletedtoday, countstickedtoday);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                GC.Collect();
            }

            

        }


        public Tuple<int, int> thisoverrallF()
        {
            try
            {
                string query1 = "select Count(noteid) from notes where completed='true' and userid=" + userid;
                DataTable dt1 = dc.retrive(query1);
                int countcompletedtoday = int.Parse(dt1.Rows[0][0].ToString());

                string query2 = "select Count(noteid) from notes where stickied='true' and userid=" + userid;
                DataTable dt2 = dc.retrive(query2);
                int countstickedtoday = int.Parse(dt2.Rows[0][0].ToString());
                return Tuple.Create(countcompletedtoday, countstickedtoday);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                GC.Collect();
            }


            

        }


    }
}
