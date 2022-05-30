using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HomeTask._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("HomeTask.6.6.");
                char key1 = '1';
                char key2 = '2';
                char key3 = '3';
                char key4 = '4';
                char key5 = '5';
                char key6 = '6';
                char key7 = '7';
                char keyD = 'д';

                while (true)
                {
                //Меню управления
                Class11.Welcome();
                char keyChoice = Console.ReadKey(true).KeyChar;
                Console.Clear();

                //Список
                if (key1 == keyChoice)
                {
                    if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "infoData.txt"))) Class11.ReadingFile();
                    else Console.WriteLine("Файл infoData.txt не существует");
                }

                //Добавление
                else if (key2 == keyChoice)
                {
                    string infoID = string.Empty;
                    infoID = Class11.AddNewID();
                    Class11.WritingFile(infoID);
                    Console.Clear();
                }

                //Удаление
                else if (key3 == keyChoice)
                {
                    Console.WriteLine("Введите фамилию или ID сотрудника для удаления");
                    string nameDeleting = Class11.FirstLetterUp(Console.ReadLine());
                    Console.WriteLine(nameDeleting);
                    int indexDel;
                    Class11.SearchingID(nameDeleting, out indexDel);
                    Class11.DeletingID(indexDel);
                }

                //Редактирование
                else if (key4 == keyChoice)
                {
                    Class11.ReadingFile();
                    Console.WriteLine("Данные какого сотрудника вы хотите поменять?");
                    string secondname = Class11.FirstLetterUp(Console.ReadLine());
                    Console.WriteLine("Какие данные вы бы хотели поменять: ID, фамилия, имя, отчество, дата рождения, место рождения?");
                    string whatChange = Console.ReadLine().ToLower();
                    int indexline;
                    Class11.SearchingID(secondname, out indexline);
                    Class11.ChangeInfo(whatChange, indexline);
                }

                //Отображение записей в диапозоне дат
                else if (key5 == keyChoice)
                {
                    Class11.PrintingLimitDate();
                }

                //Наличие файла
                else if (key6 == keyChoice)
                {
                    Class11.IsFileExist();
                }

                //Сортировка по датам по возрастанию или убыванию
                else if (key7 == keyChoice)
                {
                    Console.WriteLine("Хотите отсортировать по ID или Датам?");
                    string sort7 = Console.ReadLine().ToLower();
                    Class11.WhichSort(sort7);

                }

                //Выход
                else break;
                }
                Console.Clear();
        }
       
    }
}