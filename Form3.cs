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
    public partial class Form3 : Form
    {
        static string kniga_name; // имя книги

        protected InfoForm info_form; // поле с выводом информации
        BookManager register_book;
        BookManager delete_book;
        BookManager search_book;
        public Form3()
        {
            kniga_name = "";
            InitializeComponent();
        }

        private bool AddBook(string name, string author, string code, string description)
        {
            LibraryBase.kniga_list.Add( new Kniga(kniga_name, author, code, description) );
            return true;
        }

        private bool DeleteBook(string name, string author, string code, string description)
        {
            for (int i = 0; i < LibraryBase.kniga_list.Count; i++)
            {
                if (
                    LibraryBase.kniga_list[i].name == name &&
                    LibraryBase.kniga_list[i].author == author &&
                    LibraryBase.kniga_list[i].code == code &&
                    LibraryBase.kniga_list[i].description == description
                    )
                {
                    LibraryBase.kniga_list.RemoveAt(i);
                    MessageBox.Show("Книга успешно удалена из базы");
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
                if (
                    LibraryBase.kniga_list[i].name == name &&
                    LibraryBase.kniga_list[i].author == author &&
                    LibraryBase.kniga_list[i].code == code &&
                    LibraryBase.kniga_list[i].description == description
                    )
                {
                    string x4itatel = "";

                    for (int j = 0; j < LibraryBase.kniga_list[i].kniga_taked.Count; j++)
                    {
                        string Name = "Сотрудник: " + LibraryBase.kniga_list[i].kniga_taked[j].name + "\n";
                        x4itatel += Name;
                    }

                    string info = "Название: " + LibraryBase.kniga_list[i].name + "\n" +
                                  "Автор: " + LibraryBase.kniga_list[i].author + "\n" +
                                  "Список сотрудников, взявших книгу: \n" + x4itatel;

                    info_form = new InfoForm(info);
                    info_form.Show();
                    return true;
                }
            }
            MessageBox.Show("Ошибка. Книга не найдена");
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add kniga
            BookManager.Callback function = AddBook;
            register_book = new BookManager(function);
            register_book.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // delete kniga
            BookManager.Callback function = DeleteBook;
            delete_book = new BookManager( function );
            delete_book.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // kniga search name
            kniga_name = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // iskat' knigu

            BookManager.Callback function = SearchBook;
            search_book = new BookManager(function);
            search_book.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
