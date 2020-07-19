using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;
namespace LoginTesting
{
    [TestClass]
    public class CategoryCreation
    {
        [TestMethod]
        public void TestMethod1()
        {
            /* For Creation of "TestCategory" Category, it can be only done once. It needs to be changed
            for next test because Category name is uniquely saved. */

            ClassCategory gotoClassCategory = new ClassCategory();
            gotoClassCategory.userid123 = 1;
            gotoClassCategory.category123 = "TestCategory";
            string resultant = gotoClassCategory.insertcategory();
            string Needed = "success";
            Assert.AreEqual(Needed, resultant);
        }
    }
}
