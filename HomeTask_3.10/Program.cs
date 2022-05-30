using System;

namespace HomeTask_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HomeTask_3.10");

            #region exersice 1
            int userNumber;

            Console.WriteLine($"Введите целое число");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"Цисло {userNumber} - четное");
            }
            else
            {
                Console.WriteLine($"Цисло {userNumber} - НЕчетное");
            }
            #endregion

            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey(); Console.Clear();

            #region exercise 2 "blackjack"
            int amount_card = 0;
            int value_card = 0;
            int average = 0;

            Console.WriteLine("День добрый, сколько у Вас на руках карт?");
            amount_card = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount_card; i++)
            {

                Console.WriteLine($"Введите номинал карты");
                var enter_card = Console.ReadLine();
                if (enter_card == "J") value_card = 10;
                else if (enter_card == "Q") value_card = 10;
                else if (enter_card == "K") value_card = 10;
                else if (enter_card == "T") value_card = 10;
                else
                    switch (enter_card)
                    {
                        case "1":
                            value_card = 1;
                            break;
                        case "2":
                            value_card = 2;
                            break;
                        case "3":
                            value_card = 3;
                            break;
                        case "4":
                            value_card = 4;
                            break;
                        case "5":
                            value_card = 5;
                            break;
                        case "6":
                            value_card = 6;
                            break;
                        case "7":
                            value_card = 7;
                            break;
                        case "8":
                            value_card = 8;
                            break;
                        case "9":
                            value_card = 9;
                            break;
                        case "10":
                            value_card = 10;
                            break;
                    }
                average += value_card;

            }
            Console.WriteLine($"Ваша сумма {average}");
            #endregion

            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey(); Console.Clear();

            #region exercise 3 "Простое число"

            Console.WriteLine("Введите число: ");
            int num_1 = int.Parse(Console.ReadLine());
            int k= 2;
            bool word = true;
            while (k < num_1)
            {
                if (num_1 % k == 0)
                {
                    word = true;
                    break;
                }
                else
                {
                    word = false;
                    k += 1;
                }
            }
            if (word == true) Console.WriteLine($"Число {num_1} не простое");
            else Console.WriteLine($"Число {num_1} простое");
            Console.WriteLine("Нажмите клавишу для завершения програмыы");
            Console.ReadKey();



            #endregion
        }
    }
}