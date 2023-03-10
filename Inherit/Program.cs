using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inherit
{
    public class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }
        public void Show()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate.ToShortDateString()}"); //чтобы дата выводилась в сокращенном виде
        }
    }
    public class Employee : Human
    {
        double _salary;

        public Employee(string firstName, string lastName) :base(firstName, lastName)
        { }
        public Employee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            _salary = salary;
        }
        public Employee(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate)
        {
            _salary = salary;
        }
        public void Print()
        {
            base.Show();
            WriteLine($" Зарплата: {_salary}$");
        }
    }

    public class Jedy : Employee
    {
        string _position;
        string _swordColor;
        public Jedy(string firstName, string lastName, DateTime birthDate, double salary,string position, string swordColor): base(firstName, lastName, birthDate, salary)
        {
            _position = position;
            _swordColor = swordColor;
        }
        public void ShowJedy()
        {
            base.Show();
            WriteLine($"Должность: {_position}\n Цвет меча: {_swordColor}\n");
        }
    }
    public class Sith : Employee
    {
        string _position;
        string _swordColor;
        string _mentor;
        public Sith(string firstName, string lastName, DateTime birthDate, double salary, string position, string swordColor, string mentor) : base(firstName, lastName, birthDate, salary)
        {
            _position = position;
            _swordColor = swordColor;
            _mentor = mentor;
        }

        public void ShowSith()
        {
            base.Show();
            WriteLine($"Должность: {_position}\nЦвет меча: {_swordColor}\nИмя наставника: {_mentor}\n");
        }
    }

    class Citizen : Employee
    {
        string _planet;
        string _side;

        public Citizen(string firstName, string lastName, DateTime birthDate, double salary, string planet, string side) : base(firstName, lastName, birthDate, salary)
        {
            _planet = planet;
            _side = side;
        }
        public void ShowCitizen()
        {
            base.Show();
            WriteLine($"Планета проживания: {_planet}\nПартия: {_side}\n");
        }
    }

        internal class Inherit
    {
        static void Main(string[] args)
        {
            Employee jedy1 = new Jedy("Люк", "Скайуокер", new DateTime(1970, 11, 11), 100000, "Мастер", "Голубой");
            Employee[] employees =
            {
                jedy1,
                new Sith("Энакин", "Скайуокер", new DateTime(1947, 02, 24), 250000, "Лорд", "Красный", "Палпатин"),
                new Citizen("Хан", "Соло", new DateTime(1945, 3, 14), 300000, "Коррелия", "Республика"),
                new Citizen("Джаджа", "Бинкс", new DateTime(1897, 12, 3), 90000, "Набу", "Республика"),
                
            };

            foreach(Employee item in employees)
            {
                //item.Show();
                //первый способ, явное приведение к типу класса
                try
                {
                    ((Jedy)item).ShowJedy();
                }
                catch
                {

                }
                //второй способ, запись item ка объект нужного класса
                Sith sith = item as Sith;
                if(sith !=null)
                {
                    sith.ShowSith();
                }
                //способ 3, сравнение типов и приведение через is
                if(item is Citizen)
                {
                    (item as Citizen).ShowCitizen();
                }

            }
        }
    }
}

