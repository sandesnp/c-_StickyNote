using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    public class ClassAPrivilige
    {
        DatabaseConnection DC = new DatabaseConnection();

        public DataTable retrieveUsers()
        {
            

            try
            {
                string query = "select * from Users";
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


        //---------------------Retrieve Certain Users---------------

        private int userid;
        public int CertainID { get {return userid; } set {userid=value; } }

        public DataTable retrieveCertainUser()
        {
            try
            {
                string query = "select * from users where userid=" + userid;
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


        //----------------------Delete------------------------------------

        public void DeleteCertainUser()
        {
            try
            {
                string query = "delete from notes where userid=" + userid + " delete from category where userid=" + userid + " delete from users where userid=" + userid;
                DC.manipulate(query);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ;
            }
            finally
            {
                GC.Collect();
            }
           
        }

        //---------------------Edit------------------------------------------------------

        
        private string password;
        private string firstname;
        private string lastname;
        private string address;
        private string phoneno;
        private string gender;
        private string usertype;

       

        public string password123 { get { return password; } set {password= value ; } }

        public string firstname123 { get { return firstname; } set {firstname= value; } }

        public string lastname123 { get { return lastname; } set {lastname= value; } }

        public string address123 { get { return address; } set {address= value; } }

        public string phoneno123 { get { return phoneno; } set {phoneno= value; } }

        public string gender123 { get { return gender; } set {gender= value; } }

        public string usertype123 { get { return usertype; } set {usertype= value; } }

        int usertypeid;
        public void EditCertainUser()
        {

            try
            {
                if (usertype == "Admin")
                {
                    usertypeid = 1;

                }
                else
                {
                    usertypeid = 2;
                }
                string query = "update users set password='" + password + "',fname='" + firstname + "',lname='" + lastname + "',useraddress='" + address + "',phone='" + phoneno + "',gender='" + gender + "',usertypeid=" + usertypeid + "where userid=" + userid;
                DC.manipulate(query);


            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ;
            }
            finally
            {
                GC.Collect();
            }


           
        }
    }
}
