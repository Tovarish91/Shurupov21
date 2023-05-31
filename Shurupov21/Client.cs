using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shurupov21
{
    internal class Client
    {
        public int IdPerson { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string PersonPatronymic { get; set; }
        public DateTime PersonBirthday { get; set; }
        public char PersonGender { get; set; }
        public int PersonAge { get; set; }

        public Client(int id, string name, string surname, string patronymic, DateTime birthday, char gender, int age) //Можем задать значения через конструктор класса.

        {
            PersonName = name;
            PersonAge = age;
            PersonSurname = surname;
            PersonPatronymic = patronymic;
            PersonBirthday = birthday;
            PersonGender = gender;
            IdPerson = id;
        }
    }
}
