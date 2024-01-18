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
    // класс обработки формы для пользователя
    public partial class UserManager : Form
    {
        public User user;
        public string book_name;
        public string book_author;
        public string code_izdanie;
        public string description;       
        public delegate bool Callback( User user, string name, string author, string code_izd, string description  );
        protected Callback function;

        public UserManager( Callback fn )
        {
            user = new User("","","","","");
            book_name = "";
            book_author = "";
            code_izdanie = "";
            description = "";
            function = fn;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user.pre_name = (sender as TextBox).Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            user.name = (sender as TextBox).Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            user.ot4estvo = (sender as TextBox).Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            user.read_idcode = (sender as TextBox).Text; 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            user.phone_number = (sender as TextBox).Text; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // проверка на наличие пустых полей
            if (user.name != "" &&
                user.pre_name != "" &&
                user.ot4estvo != "" &&
                user.phone_number != "" &&
                user.read_idcode != "" &&
                book_author != "" &&
                book_name != "" &&
                code_izdanie != "" &&
                description != "" )
            {
                function( user, book_name, book_author, code_izdanie, description );
                return;
            }

            MessageBox.Show("Ошибка. Одно из полей не заполнено");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            book_name = (sender as TextBox).Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            book_author = (sender as TextBox).Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            code_izdanie = (sender as TextBox).Text; 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            description = (sender as TextBox).Text; 
        }

        private void UserManager_Load(object sender, EventArgs e)
        {

        }
    }
}
