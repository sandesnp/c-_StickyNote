using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandesh_stickyNotes
{
    public class ClassCategory
    {
        private string category;
        private int userid;

        public string category123 { get {return category; } set {category=value; } }

        public int userid123 { get {return userid; } set {userid=value; } }
        DatabaseConnection CN = new DatabaseConnection();

        public string insertcategory()
        {
            try
            {
                string query3 = " select * from category where category='" + category + "'and userid=" + userid;
                DataTable dt2 = CN.retrive(query3);
                if (dt2.Rows.Count > 0)
                {
                    return "Category already Exists";

                }
                else
                {
                    string query2 = "insert into category(category,userid)values('" + category + "'," + userid + ")";
                    CN.manipulate(query2);

                    return "success";
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
