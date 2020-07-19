using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    public class ClassCreateUser
    {
        private string username;
        private string password;
        private string FirstName;
        private string LastName;
        private string Address;
        private string PhoneNo;
        private string gender;

        public string Classusername { get { return username; } set { username = value; } }

        public string Classpassword { get { return password; } set { password = value; } }

        public string ClassFname { get { return FirstName; } set { FirstName = value; } }
        public string ClassLname { get { return LastName; } set { LastName = value; } }

        public string ClassAddress { get { return Address; } set { Address = value; } }

        public string ClassPhoneNo { get { return PhoneNo; } set { PhoneNo = value; } }


        public string Classgender { get { return gender; } set { gender = value; } }


        DatabaseConnection DC = new DatabaseConnection();
        public string insertuser()
        {

            try
            {
                string query1 = "select max(usertypeid) from usertype";
                DataTable dt1 = DC.retrive(query1);
                if (dt1.Rows[0][0].ToString() != "")
                {
                    string query4 = "select * from users where username='" + username + "'";
                    DataTable dt4 = DC.retrive(query4);
                    if (dt4.Rows.Count > 0)
                    {
                        return "Username already Exists";

                    }
                    else
                    {
                        string query3 = "insert into users(username,password,fname,lname,useraddress,phone,gender,usertypeid)values('" + username + "','" + password + "','" + FirstName + "','" + LastName + "','" + Address + "','" + PhoneNo + "','" + gender + "'," + 2 + ")";
                        DC.manipulate(query3);
                        return "Success!";
                    }

                }
                else
                {
                    //insert into usertype(usertype)values('admin'),('Regular')
                    string query2 = "insert into usertype(usertype) values('" + " admin" + "'),('" + "Regular" + "')";
                    DC.manipulate(query2);
                    string query3 = "insert into users(username,password,fname,lname,useraddress,phone,gender,usertypeid)values('" + "admin" + "','" + "admin" + "','" + "admin" + "','" + "admin" + "','" + "admin" + "','" + "12345" + "','" + "others" + "'," + 1 + "),('" + username + "','" + password + "','" + FirstName + "','" + LastName + "','" + Address + "','" + PhoneNo + "','" + gender + "'," + 2 + ")";
                    DC.manipulate(query3);
                    return "Success!";
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
    }
}
    

   
