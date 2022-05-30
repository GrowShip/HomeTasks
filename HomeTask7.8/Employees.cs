using System;
namespace HomeTask7._8
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
        public Employees(int ID, DateTime dateAdd, string fullName, int age, int height, DateTime birthDay, string birthCity)
        {
            this.IDd = ID;
            this.dateAdd = dateAdd;
            this.fullName = fullName;
            this.age = age;
            this.height = height;
            this.birthDay = birthDay;
            this.birthCity = birthCity;
        }

        #endregion

        public int ID { get { return this.ID; } set => this.IDd = value; }
        public DateTime dataAdd { get { return this.dataAdd; } set { this.dataAdd = value; } }

        #region Методы
        public string Print()
        {
            return $"{ID,6} {dateAdd,20} {fullName,25} {age,8} {height,5} {birthDay,20} {birthCity,15}";
        }

        #endregion


        #region Свойства


        #endregion


        #region Поля сотрудника
        /// <summary>
        /// ID сотрудника
        /// </summary>
        private int IDd;
        /// <summary>
        /// Дата и время добавления
        /// </summary>
        private DateTime dateAdd;
        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        private string fullName;
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
        private DateTime birthDay;
        /// <summary>
        /// Город рождения
        /// </summary>
        private string birthCity;
        #endregion
    }
}
