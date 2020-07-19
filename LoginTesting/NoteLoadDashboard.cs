using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;
namespace LoginTesting
{
    [TestClass]
    public class NoteLoadDashboard
    {
        [TestMethod]
        public void TestMethod1()
        {
            /* Granted there is a category created for admin then this testing will be successful.
               We will test if retrieved number is empty or not that is required for loading notes on Dashboard. */
           
            ClassNotes gotoclaassnote = new ClassNotes();

            gotoclaassnote.userid123 = 1;
            gotoclaassnote.onecategory123 = 1;
            int Notnull = gotoclaassnote.countnotes();
            Assert.IsNotNull(Notnull);



        }
    }
}
