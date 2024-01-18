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
    public partial class BookManager : Form
    {
        public string book_name;
        public string book_author;
        public string code_izdanie;
        public string description;

        public delegate bool Callback ( string name, string author, string code, string description );

        Callback callback_function;
        public BookManager( Callback fn )
        {
            callback_function = fn;
            book_name = "";
            book_author = "";
            code_izdanie = "";
            description = "";
            InitializeComponent();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            book_name = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            book_author = (sender as TextBox).Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            code_izdanie = (sender as TextBox).Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            description = (sender as TextBox).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // проверка на наличие пустых полей
            if (book_name != "" &&
                book_author != "" &&
                code_izdanie != "" &&
                description != "")
            {
                callback_function(book_name, book_author, code_izdanie, description);
                return;
            }

            MessageBox.Show("Ошибка. Одно из полей не заполнено");
        }
    }
}
