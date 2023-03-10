﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstract
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

        public abstract void Think();
        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate.ToShortDateString()}";
        }

    }

    public abstract class Learner : Human
        {
        string _institution;

        public Learner(string firstName, string lastName, DateTime birthDate, string institution):base(firstName, lastName, birthDate)
        {
            _institution = institution;
        }
        public abstract void Study();
        public override string ToString()
        {
            return base.ToString()+ $"\nУчебное заведение: {_institution}";
        }
        }

    class Student : Learner
    {
        string _groupName;

        public Student(string firstName, string lastName, DateTime birthDate, string institution, string groupName) : base(firstName, lastName, birthDate, institution)
        {
            _groupName = groupName;
        }

        public override void Think()
        {
            WriteLine("Я думаю, что я студент");
        }
        public override void Study()
        {
            WriteLine("Я изучаю много предметов в институте\n");
        }
        public override string ToString()
        {
            return base.ToString()+ $"\nГруппа: {_groupName}";
        }
    }

    class SchoolChild : Learner
    {
        string _className;

        public SchoolChild(string firstName, string lastName, DateTime birthDate, string institution, string className) : base(firstName, lastName, birthDate, institution)
        {
            _className = className;
        }

        public override void Think()
        {
            WriteLine("Я думаю, что я школьник");
        }
        public override void Study()
        {
            WriteLine("Я изучаю 10 предметов в школе\n");
        }
        public override string ToString()
        {
           return base.ToString()+ $"\nКласс: {_className}";
        }
    }

    internal class Abstract
    {
        static void Main(string[] args)
        {
            Learner[] learners =
            {
                new Student("Legolas", "Greenleaf", new DateTime(1002, 3, 5), "Rivendell", "WPU221" ),
                new Student("Gendalf", "Grey", new DateTime(999, 12, 12), "MiddleEarth", "SR678" ),
                new SchoolChild("Frodo", "Baggins", new DateTime(1955, 10, 20), "Sheer Ring High School", "10"),
                new SchoolChild("Gimli", "Durin", new DateTime(1655, 9, 3), "Erebor School", "9"),
            };
            foreach(Learner item in learners)
            {
                WriteLine(item);
                item.Think();
                item.Study();
            }
        }
    }
}
