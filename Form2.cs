using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    // форма
    public partial class Читатель : Form
    {
        protected UserManager user_register_book;
        protected BookManager book_search;

        public InfoForm info_form;

        public Читатель()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string full_list = "";
            // spisok knig
            for (int i = 0; i < LibraryBase.kniga_list.Count; i++)
            {
                string info = "---------------\n";
                info =        "Название: " + LibraryBase.kniga_list[i].name + "\n" +
                              "Автор: " + LibraryBase.kniga_list[i].author + "\n"  +
                              "Описание: " + LibraryBase.kniga_list[i].description + "\n" + 
                              "Код издания: " + LibraryBase.kniga_list[i].code + "\n";

                info += "---------------\n";
                full_list += info;
            }

            info_form = new InfoForm(full_list);
            info_form.Show();

        }

        public bool Add4itatelBook(User user, string name, string author, string code_izd, string description )
        {
            for (int i = 0; i < LibraryBase.kniga_list.Count; i++)
            {
                if ( // поиск по всем возможным вариантам
                    LibraryBase.kniga_list[i].name == name &&
                    LibraryBase.kniga_list[i].author == author &&
                    LibraryBase.kniga_list[i].code == code_izd &&
                    LibraryBase.kniga_list[i].description == description
                    )
                {
                    for (int j = 0; j < LibraryBase.kniga_list[i].kniga_taked.Count; j++)
                    {
                        if (
                            LibraryBase.kniga_list[i].kniga_taked[j].name == user.name &&
                            LibraryBase.kniga_list[i].kniga_taked[j].pre_name == user.pre_name &&
                            LibraryBase.kniga_list[i].kniga_taked[j].ot4estvo == user.ot4estvo &&
                            LibraryBase.kniga_list[i].kniga_taked[j].phone_number == user.phone_number &&
                            LibraryBase.kniga_list[i].kniga_taked[j].read_idcode == user.read_idcode)
                        {
                            MessageBox.Show("Книга уже выдана");
                            return false;
                        }
                    }

                    LibraryBase.kniga_list[i].kniga_taked.Add( user );
                    MessageBox.Show("Книга выдана пользователю");
                    return true;
                }
            }
            MessageBox.Show("Ошибка. Книга не найдена");
            return false;
        }

        public bool SearchBook(string name, string author, string code, string description)
        {
            for (int i = 0; i < LibraryBase.kniga_list.Count; i++)
            {
                if ( // поиск по всем возможным вариантам
                    LibraryBase.kniga_list[i].name == name ||
                    LibraryBase.kniga_list[i].author == author ||
                    LibraryBase.kniga_list[i].code == code ||
                    LibraryBase.kniga_list[i].description == description 
                    )
                {

                    string info =   "Название: " + LibraryBase.kniga_list[i].name + "\n" +
                                    "Автор: " + LibraryBase.kniga_list[i].author + "\n" +
                                    "Описание: " + LibraryBase.kniga_list[i].description + "\n" +
                                    "Код издания: " + LibraryBase.kniga_list[i].code + "\n";

                    info_form = new InfoForm(info);
                    info_form.Show();
                    return true;
                }
            }
            MessageBox.Show("Ошибка. Книга не найдена");
            return false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // iskat' knigu
            

            BookManager book_search = new BookManager(SearchBook);
            book_search.code_izdanie = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            book_search.description  = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            book_search.Show();


        }


        private void button3_Click(object sender, EventArgs e)
        {
            // take kniga
            UserManager.Callback function = Add4itatelBook;
            user_register_book = new UserManager(function);
            user_register_book.Show();

        }
    }
}
