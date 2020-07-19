using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandesh_stickyNotes;

namespace LoginTesting
{
    [TestClass]
    public class AddNote
    {
        [TestMethod]
        public void AddingNote()
        {
            //--------------------Testing of Addition of a note into the database.

            ClassNotes gotoClassNote = new ClassNotes();
            gotoClassNote.userid123 = 1;
            gotoClassNote.stick123 = "true";
            gotoClassNote.completed123 = "false";
            gotoClassNote.title123 = "Test Title";
            gotoClassNote.content123 = "Test Content";
            gotoClassNote.categoryid123 = 1;
            string Added=gotoClassNote.insertnotes();
            string Needed = "Note Added!";
            Assert.AreEqual(Needed, Added);

        }

       
    }
}
