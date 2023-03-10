using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Polymorfism
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
        public virtual void Show()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate.ToShortDateString()}"); //чтобы дата выводилась в сокращенном виде
        }
    }
    public class Employee : Human
    {
        double _salary;

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        { }
        public Employee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            _salary = salary;
        }
        public Employee(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate)
        {
            _salary = salary;
        }
        public override void Show()
        {
            base.Show();
            WriteLine($"Зарплата: {_salary}$");
        }
    }

    public class Jedy : Employee
    {
        string _position;
        string _swordColor;
        public Jedy(string firstName, string lastName, DateTime birthDate, double salary, string position, string swordColor) : base(firstName, lastName, birthDate, salary)
        {
            _position = position;
            _swordColor = swordColor;
        }
        public override void Show()
        {
            base.Show();
            WriteLine($"Должность: {_position}\nЦвет меча: {_swordColor}\n");
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

        public override void Show()
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
        public override void Show()
        {
            base.Show();
            WriteLine($"Планета проживания: {_planet}\nПартия: {_side}\n");
        }
    }

    internal class Polymorfism
    {
        static void Main(string[] args)
        {
            Human[] people =
            {
                new Jedy("Obi Van", "Kenobi", new DateTime(1955, 4, 24), 250000, "Master Jedy", "Blue"),
                new Jedy("Mase", "Windu", new DateTime(1935, 8, 1), 300000, "Master Jedy", "Purple"),
                new Sith("Darth", "Vader", new DateTime(1967, 7, 18), 350000, "Lord Sith", "Red", "Emperor Palpatin"),
                new Sith("Darth", "Maul", new DateTime(1933, 3, 10), 340000, "Apprentice Sith", "Red", "Emperor Palpatin"),
                new Citizen("Padme", "Amidala", new DateTime(1978, 12, 2), 80000, "Nabou", "Republic"),
                new Citizen("Jaja", "Bings", new DateTime(1980, 5, 13), 50000, "Nabou", "Republic"),
            };

            foreach(Human item in people)
            {
                item.Show();
            }
        }
    }
}

