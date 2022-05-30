using System;

namespace HomeTask_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Home Task 2.7");
            #region exercise 1
            string fullname = "Шипицын Илья Юрьевич";
            byte age = 23;
            string mail = "suppurpose@gmail.com";
            float exam_program = 70;
            float exam_math = 88;
            float exam_phisics = 78;

            string person_info = "ФИО: {0} \nВозраст: {1} \nПочта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(person_info,
                fullname, age, mail, exam_program, exam_math, exam_phisics);
            #endregion

            #region exercise 2
            float sum_exam = (exam_program + exam_math + exam_phisics);
            float aprox_exam = sum_exam / 3;
            Console.ReadKey();
            Console.WriteLine($"\nСредний бал по трем предметам - {aprox_exam.ToString("#.#")} \nСумма за 3 предмета - {sum_exam}.");
            #endregion
        }
    }
}
