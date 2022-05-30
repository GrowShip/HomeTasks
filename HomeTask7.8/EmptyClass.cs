using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask._6._6
{
    public struct EmptyClass
    {

    }

    /// <summary>
    /// Чтение
    /// </summary>
    public static void ReadingFile()
    {
        Console.WriteLine($"{"ID",6} {"Дата и Время",18} {"Фамилия",10} " +
            $"{"Имя",7} {"Отчество",12} {"Возраст",8} {"Рост",5} " +
            $"{"Дата рождения",14} {"Место рождения",16}");
        string[] textFile = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "infoData.txt"));

        foreach (var e in textFile)
        {
            string[] arrayFile = e.Split('#', '\n');

            Console.Write($"{arrayFile[0],6} {arrayFile[1],18} {arrayFile[2],10} " +
                                $"{arrayFile[3],7} {arrayFile[4],12} {arrayFile[5],8} " +
                                $"{arrayFile[6],5} {arrayFile[7],14} {arrayFile[8],16}"); Console.Write('\n');
        }

        return;
    }
}
