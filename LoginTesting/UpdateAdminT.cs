using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;
using System.Data;

namespace LoginTesting
{
    [TestClass]
    public class UpdateAdminT
    {
        [TestMethod]
        public void TestMethod1()
        {
            //                 Testing if the value is updated or not in the database thought Admin Privileges.   


            ClassAPrivilige PriviligeO = new ClassAPrivilige();
            DatabaseConnection DB = new DatabaseConnection();
            PriviligeO.CertainID = 1;
            
            PriviligeO.password123 = "admin";
            PriviligeO.firstname123 = "adminTes";
            PriviligeO.lastname123 = "admin";
            PriviligeO.address123 = "admin";
            PriviligeO.phoneno123 = "12345";
            PriviligeO.gender123 = "Others";
            PriviligeO.usertype123 = "Admin";
            PriviligeO.EditCertainUser();

            string query = "select * from users where fname='adminTes'";
            DataTable dt = DB.retrive(query);
            Assert.IsNotNull(dt.Rows[0][0].ToString());
        }
    }
}
