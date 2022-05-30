using System;
namespace HomeTask._6._6
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    struct IDList
    {
        /// <summary>
        /// БД сотрудников
        /// </summary>
        private Employees[] Employee;

        public Employees this [int index]
        {
            get { return Employee[index]; }
            set { Employee[index] = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="args">Список сотрудников</param>
        public IDList(params Employees[] args)
        {
            Employee = args;
        }
    }
}
