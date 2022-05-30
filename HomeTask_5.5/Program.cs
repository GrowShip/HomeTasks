using System;

namespace HomeTask_5._5
{
    class Program
    {

        static string[] DeviderSentence(string text)
        {
            string[] deviderArray = text.Split(" ");
            return deviderArray;
        }

        static void  PrintingDeviders(string [] args)
        {
            foreach (var e in args)
            {
                Console.WriteLine($"{e}");
            }
            
        }

        static string ReversWords(string inputPhrase)
        {
            string[] deviderArray = DeviderSentence(inputPhrase);
            string resultstring = "";
            for (int i = (deviderArray.Length - 1); i >= 0; i--)
            {
                string word = Convert.ToString(deviderArray[i]);
                resultstring += word + " ";
            }
            return resultstring;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HomeYask_5.5");

            #region Exercise1.toDivideStrings

            Console.WriteLine($"Введите длинное предложение:");
            string sentence1 = Console.ReadLine();
            string[] wordsArray1 = DeviderSentence(sentence1);
            Console.Clear();
            PrintingDeviders(wordsArray1);
            Console.WriteLine($"Нажмите любую клавишу для продолжения");
            Console.ReadKey(); Console.Clear();

            #endregion

            #region Exercise2. toReplaceWords
            
            Console.WriteLine($"Введите длинное предложение");
            string sentence2 = Console.ReadLine();
            string words2 = ReversWords(sentence2);
            Console.WriteLine($"Предложение наоборот {words2}");
            Console.WriteLine($"Нажмите любую клавишу для продолжения");
            Console.ReadKey(); Console.Clear();

            #endregion
        }
    }
}
