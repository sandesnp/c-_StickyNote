using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    public class ClassNotes
    {
        DatabaseConnection DC = new DatabaseConnection();
        
       

        private int userid;
        public int userid123 { get { return userid; } set { userid = value; } }


        //--------------------------------UserName of this userid-----------------
        public Tuple<string,string> usernameofthisID()
        {

            try
            {
                string query = "select username,usertypeid from users where userid = " + userid;
                DataTable dt = DC.retrive(query);
                string username114 = dt.Rows[0][0].ToString();
                string usertypeid114 = dt.Rows[0][1].ToString();
                return Tuple.Create(username114, usertypeid114);

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




        //---------------------------------For first time category creation----------------------


        public string example1()
        {
            try
            {
                string query2 = "select max(categoryid) from category where userid=" + userid;
                DataTable dt2 = DC.retrive(query2);
                if (dt2.Rows[0][0].ToString() != "")
                {
                    return "existingcategory";
                }
                else
                {
                    return "nonexistingcategory";
                }

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

        //--------------------------------list for combobox---------------

        public DataTable comboboxcategory()
        {
            try
            {
                string query2;

                query2 = "select category, categoryid from category where userid=" + userid;
                DataTable dt2 = DC.retrive(query2);
                return dt2;

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

        //-----------------------------Inserting in note--------

        private string title;
        private string content;
        private string stick;
        private string completed;
        private int categoryid;

        public string title123 { get {return title; } set {title=value; } }

        public string content123 { get {return content; } set {content=value; } }

        public string stick123 { get {return stick; } set {stick=value; } }

        public string completed123 { get {return completed; } set {completed=value; } }

        

        public int categoryid123 { get {return categoryid; } set {categoryid=value; } }


        public string insertnotes()
        {

            try
            {
                string query2 = "insert into notes(datecreated,title,contents,stickied,completed,userid,categoryid)values('" + DateTime.Now.ToString("MM-dd-yyyy") + "','" + title + "','" + content + "','" + stick + "','" + completed + "'," + userid + "," + categoryid + ")";
                DC.manipulate(query2);
                return "Note Added!";

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

        


        //-------------------------for counting number of notes of a user----------------------------------------

        private int onecategory;

        public int onecategory123 { get { return onecategory; } set { onecategory = value; } }

        public int countnotes()
        {

            try
            {
                string query2 = "select count(noteid) from notes where userid=" + userid + " and stickied='true' and categoryid=" + onecategory;

                DataTable dt2 = DC.retrive(query2);
                int countingnotes = int.Parse(dt2.Rows[0][0].ToString());
                return countingnotes;

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
            finally
            {
                GC.Collect();
            }

            
        }




        //---------------------------------for firstime notes--------------------------------------------


        public bool firsttimenotes()
        {
            try
            {
                string query2 = "select max(noteid) from notes where userid=" + userid;
                DataTable dt2 = DC.retrive(query2);

                if (dt2.Rows[0][0].ToString() != "")
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                GC.Collect();
            }


            
        }

        //-----------------------------getting saved notes----------------------------------------

        public DataTable retrivenoteid()
        {

            try
            {
                string query2 = "select noteid from notes where userid=" + userid + " and stickied='true' and categoryid=" + onecategory + " order by noteid asc";
                DataTable dt2 = DC.retrive(query2);
                return dt2;

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

        private int noteid;

        public int noteid123 { get {return noteid; } set {noteid=value; } }

        public DataTable retrivecontent()
        {

            try
            {
                string query2 = "select contents, title from notes where userid=" + userid + " and noteid=" + noteid;
                DataTable dt2 = DC.retrive(query2);
                return dt2;

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





        //------------------------------------------delete and edit---------------------------------------


        private int noteiddelandedit;
        private string contents123;
        private string titlex;
        private string ifcomplete;


        public string contents321 { get {return contents123; } set {contents123=value; } }

        public string titleABC { get { return titlex; } set { titlex = value; } }

        public string ifcomplete123 { get {return ifcomplete; } set {ifcomplete=value; } }
        public int receivenoteid { get {return noteiddelandedit; } set {noteiddelandedit=value; } }

        public void manipulatedelete()
        {
            try
            {
                string query = "delete from notes where noteid=" + noteiddelandedit;
                DC.manipulate(query);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            finally
            {
                GC.Collect();
            }

            
        }

        public void manipulateedit()
        {
            try
            {
                if (ifcomplete == "true")
                {
                    string query = "update notes set contents='" + contents123 + "', title = '" + titlex + "', completed='true', stickied='false' where noteid=" + noteiddelandedit;

                    DC.manipulate(query);
                }
                else if (ifcomplete == "false")
                {
                    string query = "update notes set contents='" + contents123 + "', title = '" + titlex + "', completed='false', stickied='true' where noteid=" + noteiddelandedit;

                    DC.manipulate(query);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            finally
            {
                GC.Collect();
            }


            
        }


        //------------------------------------------after delete -----
        private Boolean checks12=false;

        public Boolean checks123 { get {return checks12; } set {checks12=value; } }

        public Boolean checkins12345()
        {
            return checks12;

        }


        //--------------------------------------Searching----------------------------------------

        private string searchcategory;
        private string searchtitle;

        public string Scat { get {return searchcategory; } set {searchcategory=value; } }

        public string stit { get {return searchtitle; } set {searchtitle=value; } }


        public DataTable ForCmbOption()
        {
            try
            {
                string query = "select title from notes n, category c where n.categoryid=c.categoryid and category='" + searchcategory + "'  and c.userid=" + userid;
                DataTable dt = DC.retrive(query);
                return dt;

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






        public Boolean maxsearching()
        {

            try
            {
                string query2 = "select max(noteid) from notes n, category c where n.categoryid=c.categoryid and category='" + searchcategory + "' and title='" + searchtitle + "' and c.userid=" + userid;
                DataTable dt2 = DC.retrive(query2);

                if (dt2.Rows[0][0].ToString() != "")
                {

                    return true;

                }
                else
                {
                    return false;

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                GC.Collect();
            }

           
        }
        public int countSearching()
        {
            try
            {
                string query2 = "select count(noteid) from notes n, category c where n.categoryid=c.categoryid and category='" + searchcategory + "' and title='" + searchtitle + "' and c.userid=" + userid;
                DataTable dt2 = DC.retrive(query2);
                int countingsearch = int.Parse(dt2.Rows[0][0].ToString());
                return countingsearch;

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
            finally
            {
                GC.Collect();
            }

            
        }

        public DataTable Searching()
        {
            try
            {

                string query2 = "select * from notes n, category c where n.categoryid=c.categoryid and category='" + searchcategory + "' and title='" + searchtitle + "' and c.userid=" + userid + "order by noteid asc";
                DataTable dt2 = DC.retrive(query2);
                return dt2;

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



        //-------------------------------------------Deleting category-----------------------------------------


        public void deletecategory()
        {

            try
            {
                string query = "delete from notes where categoryid=" + onecategory;
                DC.manipulate(query);

                string query2 = "delete from category where categoryid=" + onecategory;
                DC.manipulate(query2);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            finally
            {
                GC.Collect();
            }
            
        }


        //---------------------------------------Delete yourself-----------------------------------------------------

        public void DeleteAccount()
        {
            try
            {
                string query = "delete from notes where userid=" + userid + " delete from category where userid=" + userid + " delete from users where userid=" + userid;
                DC.manipulate(query);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                
            }
            finally
            {
                GC.Collect();
            }

            
        }

    }


}
