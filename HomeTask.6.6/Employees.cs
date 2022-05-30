using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace HomeTask._6._6
{
    /// <summary>
    /// Структура для записи в базу данных
    /// </summary>
    public struct Employees
    {
        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">ID сотрудника</param>
        /// <param name="dateAdd">Дата добавления сотрудника</param>
        /// <param name="fullName">ФИО сотрудника</param>
        /// <param name="age">Возраст сотрудника</param>
        /// <param name="height">Рост сотрудника</param>
        /// <param name="birthDay">Дата рождения сотрудника</param>
        /// <param name="birthCity">Город рождения сотрудника</param>
        public Employees(int ID, DateTime dateadd,
            string secondname, string firstname, string middlename,
            int age, int height, DateTime birthday, string birthcity)
        {
            this.id = ID;
            this.dateadd = dateadd;
            this.secondname = secondname;
            this.firstname = firstname;
            this.middlename = middlename;
            this.age = age;
            this.height = height;
            this.birthday = birthday;
            this.birthcity = birthcity;
        }
        #endregion

        #region Перегрузки

        public Employees(int ID, DateTime dateAdd,string secondName, string firstName, string middleName,int age, int height, DateTime birthDay):
                this (ID, dateAdd, secondName, firstName, middleName, age, height, birthDay, string.Empty)
        { }

        public Employees(int ID, DateTime dateAdd, string secondName, string firstName, string middleName, int age, int height) :
                this(ID, dateAdd, secondName, firstName, middleName, age, height, new DateTime(2000,1,1,0,0,0), string.Empty)
        { }

        public Employees(int ID, DateTime dateAdd, string secondName, string firstName, string middleName, int age) :
                this(ID, dateAdd, secondName, firstName, middleName, age, 0, new DateTime(2000, 1, 1, 0, 0, 0), string.Empty)
        { }

        public Employees(int ID, DateTime dateAdd, string secondName, string firstName, string middleName) :
                this(ID, dateAdd, secondName, firstName, middleName, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0), string.Empty)
        { }
        public Employees(int ID, DateTime dateAdd, string secondName, string firstName) :
                this(ID, dateAdd, secondName, firstName, string.Empty, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0), string.Empty)
        { }
        public Employees(int ID, DateTime dateAdd, string secondName) :
                this(ID, dateAdd, secondName, string.Empty, string.Empty, 0, 0, new DateTime(2000, 1, 1, 0, 0, 0), string.Empty)
        { }

        #endregion


        #region Методы
        public string Print()
        {
            Console.WriteLine($"{"ID",6} {"Дата и Время",18} {"Фамилия",10} " +
                $"{"Имя",7} {"Отчество",12} {"Возраст",8} {"Рост",5} " +
                $"{"Дата рождения",14} {"Место рождения",16}");
            return $"{ID,6} {dateadd,18} " +
                $"{secondname,10} {firstname,7} {middlename,12} " +
                $"{age,8} {height,5} {birthday,14} {birthcity,16}";
        }

        #endregion


        #region Свойства

        public int ID { get { return this.ID; } set => this.id = value; }
        public DateTime DataAdd { get { return this.dateadd; } set { this.dateadd = value; } }
        public string FirstName { get { return this.firstname; } set { this.firstname = value; } }
        public string SecondName { get { return this.secondname; } set { this.secondname = value; } }
        public string MiddleName { get { return this.middlename; } set { this.middlename = value; } }
        public int Age { get { return this.age; } set => this.age = value; }
        public int Height { get { return this.height; } set => this.height = value; }
        public DateTime BirthDay { get { return this.birthday; } set { this.birthday = value; } }
        public string BirthCity { get { return this.birthcity; } set { this.birthcity = value; } }

        #endregion


        #region Поля сотрудника
        /// <summary>
        /// ID сотрудника
        /// </summary>
        private int id;
        /// <summary>
        /// Дата и время добавления
        /// </summary>
        private DateTime dateadd;
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        private string firstname;
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        private string secondname;
        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        private string middlename;
        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        private int age;
        /// <summary>
        /// Рост сотрудника
        /// </summary>
        private int height;
        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        private DateTime birthday;
        /// <summary>
        /// Город рождения
        /// </summary>
        private string birthcity;

        #endregion
    }
}
