using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        string login, name, surname;
        int age;
        public readonly DateTime date;
        public string Login        //Логин
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "Поле не заполнено";
                return login;
            }
        }
        public string Name   //Имя
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "Поле не заполнено";
                return name;
            }
        }
        public string Surname   //Фамилия
        {
            set { surname = value; }
            get
            {
                if (surname == null)
                    return "Поле не заполнено";
                return surname;
            }
        }
        public int Age          //Возраст
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }
        public User()
        {
            date = DateTime.Now;    //Дата
        }
        public User(string login, string name, string surname, int age)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            date = DateTime.Now;
        }
    }
}
