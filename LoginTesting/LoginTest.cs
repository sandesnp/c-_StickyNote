using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;


namespace LoginTesting
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        

        public void TestMethod1()
        {
            //-----------------------Testing Login with username and password, admin.----------------------------

            ClassLogin GoCL = new ClassLogin();
            GoCL.Classusername = "Admin";
            GoCL.Classpassword = "Admin";
           
            Boolean Needed = true;
            
            Boolean Checking = GoCL.checkUser().Item1;
            Assert.AreEqual(Checking, Needed);


        }
    }
}
