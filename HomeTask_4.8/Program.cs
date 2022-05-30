using System;

namespace HomeTask_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HomeTask_4.8");

            #region Exercise 1. rand_matrix

            Random r_1 = new Random();
            int sum = 0;
            Console.Write("Введите количество строк - ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов - ");
            int colomn = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Введите нижний предел для выборки цифр - ");
            int limit_1_1 = int.Parse(Console.ReadLine());
            Console.Write("Введите верхний предел для выборки цифр - ");
            int limit_1_2 = int.Parse(Console.ReadLine());
            int[,] rand_matrix = new int[line, colomn];

            Console.WriteLine("Матрица случайных чисел: ");
            Console.WriteLine("");
            for (int i = 0; i < rand_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < rand_matrix.GetLength(1); j++)
                {
                    rand_matrix[i, j] = r_1.Next(limit_1_1, limit_1_2);
                    Console.Write($"{rand_matrix[i, j],5} ");
                    sum += rand_matrix[i, j];
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine($"Сумма всех элементов матрица: {sum}");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey(); Console.Clear();

            #endregion

            #region Exercise 2. least_elem

            //Random r_2 = new Random();
            Console.WriteLine($"Введите длину последовательности");
            int length_array = int.Parse(Console.ReadLine());
            int[] array_value = new int[length_array];
            int veriable_numb = int.MaxValue;

            for (int i = 0; i < array_value.Length; i++)
            {
                Console.WriteLine($"Ввежите {i + 1} элемент: ");
                array_value[i] = int.Parse(Console.ReadLine());
                //array_value[i] = r_2.Next(-50, 50);
                //Console.Write($"{array_value[i],5}");
                if (array_value[i] < veriable_numb) veriable_numb = array_value[i];
            }

            Console.Write("Последовательность:");

            foreach (var e in array_value)
            {
                Console.Write($"{e,5}");
            }

            Console.WriteLine("");
            Console.WriteLine($"Наименьшее число последовательности равно  {veriable_numb,5}");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey(); Console.Clear();

            #endregion

            #region Exercise 3. guess_numb

            Random r_3 = new Random();
            //Console.Write("Введите нижний предел для выборки цифр - ");
            //int limit_3_1 = int.Parse(Console.ReadLine());
            Console.Write("Введите верхний предел для числового диапозона - ");
            int limit_3_2 = int.Parse(Console.ReadLine());
            int target_numb = r_3.Next(0, limit_3_2);
            int count = 0;
            Console.WriteLine($"Я загадал число от 0 до {limit_3_2,3}, попробуй угадать! ");

            while(true)
            {
                Console.WriteLine("Введите ваш вариант: ");
                var choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice)) break;
                else
                {
                    count++;
                    int choice_numb = int.Parse(choice);
                    if (choice_numb == target_numb)
                    {
                        Console.WriteLine($"Ух ты! Угадал мое число {target_numb} всего за {count} попыток!");
                        break;
                    }
                    else if (choice_numb != target_numb)
                    {
                        if (choice_numb > target_numb) Console.WriteLine("Ваше число немного больше, попробуй еще!");
                        else Console.WriteLine("Ваше число немного меньше, попрбуй еще");
                    }
                }
                
            }
                    
            #endregion
        }


    }
}
