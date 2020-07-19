using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
     public class ClassLogin
    {
        private string username;
        private string password;
        DatabaseConnection DC = new DatabaseConnection();
        public string Classusername{get{ return username;}set { username = value; }}

        public string Classpassword{get{return password;}set { password = value; }}

        public Tuple<bool, int> checkUser()
        {
            try
            {
                string query2 = "select max(usertypeula) from usertype";
                DataTable dt2 = DC.retrive(query2);
                if (dt2.Rows[0][0].ToString() == "")
                {
                    string query3 = "insert into usertype(usertype) values('" + " admin" + "'),('" + "Regular" + "')";
                    DC.manipulate(query3);
                    string query4 = "insert into users(username,password,fname,lname,useraddress,phone,gender,usertypeid)values('" + "admin" + "','" + "admin" + "','" + "admin" + "','" + "admin" + "','" + "admin" + "','" + "12345" + "','" + "others" + "'," + 1 + ")";
                    DC.manipulate(query4);
                }

                string query = "select username, userid from Users where username='" + username + "' and password='" + password + "'";
                DataTable dt = DC.retrive(query);


                if (dt.Rows.Count > 0)
                {
                    int userid = int.Parse(dt.Rows[0][1].ToString());
                    return Tuple.Create(true, userid);

                }
                else
                {
                    return Tuple.Create(false, 1);
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
