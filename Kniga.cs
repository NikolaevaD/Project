using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // класс книги
    public class Kniga
    {
        // имя и автор книги
        public string name;
        public string author;
        public string code;
        public string description;

        public List<User> kniga_taked; // кто взял книгу

        public Kniga(string name, string author, string code, string description)
        {
            // инициализация листа
            kniga_taked = new List<User>();

            this.name = name;
            this.author = author;
            this.code = code;
            this.description = description;
        }
    };
}
