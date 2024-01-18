using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class LibraryBase
    {
        public static List<Kniga> kniga_list;
 
        public static void InitBookList()
        {
            LibraryBase.kniga_list = new List<Kniga>();

            LibraryBase.kniga_list.Add(new Kniga("K1", "1", "1", "1"));
            LibraryBase.kniga_list.Add(new Kniga("K2", "2", "2", "2"));
            LibraryBase.kniga_list.Add(new Kniga("K3", "3", "3", "3"));
        }
    }
}
