using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    public class ClassMyProfileE
    {

        DatabaseConnection DC = new DatabaseConnection();

        private int userid;

        public int userid123 { get {return userid; } set {userid=value; } }

        //public int userid123 { get {; } set {; } }
        public DataTable retrieveCertainUser()
        {

            try
            {
                string query = "Select * from users where userid=" + userid;
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

        //---------------------------------------Update-------------------------------

       
        private string password;
        private string firstname;
        private string lastname;
        private string address;
        private string phoneno;
        private string gender;
        

       

        public string password123 { get { return password; } set { password = value; } }

        public string firstname123 { get { return firstname; } set { firstname = value; } }

        public string lastname123 { get { return lastname; } set { lastname = value; } }

        public string address123 { get { return address; } set { address = value; } }

        public string phoneno123 { get { return phoneno; } set { phoneno = value; } }

        public string gender123 { get { return gender; } set { gender = value; } }

        

        
        public void EditCertainUser()
        {

            try
            {
                string query = "update users set password='" + password + "',fname='" + firstname + "',lname='" + lastname + "',useraddress='" + address + "',phone='" + phoneno + "',gender='" + gender + "' where userid=" + userid;
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
