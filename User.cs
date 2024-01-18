using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    // класс пользователя
    public class User
    {
        // имя пользователя
        public string ot4estvo;
        public string pre_name; // фамилия
        public string name;
        public string phone_number;
        public string read_idcode; // номер билета.

        public User(string pre_name, string name, string ot4estvo, string phone_number, string read_idcode)
        {
            this.name = name;
            this.pre_name = pre_name;
            this.ot4estvo = ot4estvo;
            this.phone_number = phone_number;
            this.read_idcode = read_idcode;
        }
    }
}
