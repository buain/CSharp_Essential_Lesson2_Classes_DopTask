using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User xxx = new User();
            xxx.Login = "Kontor";
            xxx.Name = "Vladimir";
            xxx.Surname = "Mikhaylov";
            xxx.Age = 34;
           
            Console.WriteLine("Информация о пользователе: Логин {0}, Имя {1}, Фамилия {2}, Возраст {3}, время {4}", xxx.Login, xxx.Name, xxx.Surname, xxx.Age, DateTime.Now);

            //Delay
            Console.ReadLine();
        }
    }
}
