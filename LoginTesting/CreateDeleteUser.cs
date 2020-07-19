using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;
using System.Data;

namespace LoginTesting
{
    [TestClass]
    public class CreateDeleteUser
    {
        [TestMethod]
        public void TestMethod1()
        {
             //Testing of the Registeration of User  into database. 
             //Note, username is unique value to our database 

            // Here user is created with username 'TestUsername'.

            ClassCreateUser Gotoclasscreateuser = new ClassCreateUser();

            Gotoclasscreateuser.Classusername = "TestUsername";
            Gotoclasscreateuser.Classpassword = "Testpassword";
            Gotoclasscreateuser.ClassFname = "testfname";
            Gotoclasscreateuser.ClassLname = "testlname";
            Gotoclasscreateuser.ClassAddress = "testaddress";
            Gotoclasscreateuser.ClassPhoneNo = "123456";
            Gotoclasscreateuser.Classgender = "Others";
            string resultant = Gotoclasscreateuser.insertuser();
            //string needed = "Username already Exists";

            string needed = "Success!";
            Assert.AreEqual(needed, resultant);
        }

        public void TestMethod2()
        {
            //Here we are gonna delete   'TestUsername'   user via  'Delete user'   on Dashboard MenuBar.

            //Note, this test will only be successful if the user create test is successful.

            DatabaseConnection DB = new DatabaseConnection();
            ClassNotes gotoCN =new ClassNotes();
            string query1 = "select userid from users where username='TestUsername'";
            DataTable dt1 = DB.retrive(query1);
            int userid=int.Parse(dt1.Rows[0][0].ToString());


            gotoCN.userid123 = userid;
            gotoCN.DeleteAccount();

            string query2 = "select * from users where username=TestUsername";
            DataTable dt2 = DB.retrive(query2);



            Assert.IsNull(dt2.Rows.Count);
        }
    }
}
