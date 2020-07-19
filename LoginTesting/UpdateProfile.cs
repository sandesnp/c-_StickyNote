using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;
using System.Data;

namespace LoginTesting
{
    [TestClass]
    public class UpdateProfile
    {
        [TestMethod]
        public void TestMethod1()
        {
            //        Testing if the values in the database is changed through Profile Edit.

            ClassMyProfileE gotomyprofile = new ClassMyProfileE();
            DatabaseConnection DB = new DatabaseConnection();
            gotomyprofile.userid123 = 1;
            
            gotomyprofile.password123 = "admin";
            gotomyprofile.firstname123 = "adminTester";
            gotomyprofile.lastname123 = "admin";
            gotomyprofile.address123 = "admin";
            gotomyprofile.phoneno123 = "12345";
            gotomyprofile.gender123 = "Others";
            gotomyprofile.EditCertainUser();

            string query = "select * from users where fname='admintester'";
            DataTable dt = DB.retrive(query);
            Assert.IsNotNull(dt.Rows[0][0].ToString());

        }
    }
}
