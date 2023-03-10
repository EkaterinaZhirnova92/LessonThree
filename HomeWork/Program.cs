using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public abstract void CanDoMagic();
        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate.ToShortDateString()}";
        }

    }
    public class Muggle : Human
    {
        string _profession;

        public Muggle(string firstName, string lastName, DateTime birthDate, string profession) : base(firstName, lastName, birthDate)
        {
            _profession = profession;
        }
        public override void CanDoMagic()
        {
            WriteLine($"Я не умею коллдовать\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nРод деятельности: {_profession}";
        }
    }
    public class Wizard : Human
    {
        string _side;
        string _mentor;

        public Wizard(string firstName, string lastName, DateTime birthDate, string side, string mentor) : base(firstName, lastName, birthDate)
        {
            _side = side;
            _mentor = mentor;
        }
        public override void CanDoMagic()
        {
            WriteLine($"Я умею коллдовать\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nСторона: {_side}\nНаставник: {_mentor}";
        }
    }


    public class HalfBlood : Wizard
    {
        string _parentWizard;

        public HalfBlood(string firstName, string lastName, DateTime birthDate, string side, string mentor, string parentWizard) : base(firstName, lastName, birthDate, side, mentor)
        {
            _parentWizard = parentWizard;
        }
        public override void CanDoMagic()
        {
            WriteLine($"Я умею коллдовать\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nРодитель - волшебник: {_parentWizard}";
        }
    }

    public class HouseElf : Human
    {
        string _owner;

        public HouseElf(string firstName, string lastName, DateTime birthDate, string owner) : base(firstName, lastName, birthDate)
        {
            _owner = owner;
        }
        public override void CanDoMagic()
        {
            WriteLine($"Я умею коллдовать только в интересах хозяина\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nХозяин: {_owner}";
        }
    }

    public class Goblin : Human
    {
        string _positionInTheBank;

        public Goblin(string firstName, string lastName, DateTime birthDate, string positionInTheBank) : base(firstName, lastName, birthDate)
        {
            _positionInTheBank = positionInTheBank;
        }
        public override void CanDoMagic()
        {
            WriteLine($"Я умею коллдовать для защиты доверенных мне сбережений\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nДолжность в банке: {_positionInTheBank}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans =
            {
                new Muggle("Dursley", "Vernon", new DateTime(1965, 3, 5), "Administartor"),
                new Wizard("Garry", "Potter", new DateTime(1991, 12, 12), "Goodness", "Dambldor" ),
                new HalfBlood("Hermione", "Granger", new DateTime(1991, 5, 12), "Goodness", "Dambldor", "None"),
                new HouseElf("Dobby", "-", new DateTime(1655, 9, 3), "Lucius Malfoy"),
                new Goblin("Griphook", "-", new DateTime(1531, 9, 3), "Ordinary employee"),
            };
            foreach (Human item in humans)
            {
                WriteLine(item);
                item.CanDoMagic();
            }
        }
    }
}
