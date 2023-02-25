using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7HomeworkConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Бурда Владимир Алексеевич";
            byte age = 32;
            string eMail = "lordpunk4@gmail.com";
            double programPoint = 11.2;
            double mathScores = 9.8;
            double pointInPhysics = 8.2;

            string pattern = "Ф.И.О.: {0} Возраст: {1} Электроная почта: {2} Балы по программированию: {3} Балы по математике: {4} Балы по физике: {5}\n";
            

            Console.WriteLine(
                            pattern,
                            fullName,
                            age,
                            eMail,
                            programPoint,
                            mathScores,
                            pointInPhysics);

            double pointSum = (programPoint + mathScores + pointInPhysics) / 3;

            Console.ReadKey();

            Console.WriteLine("Средний бал ученика: {0}\n", pointSum);

            Console.ReadKey();



            string fName = "Балюра Лидия Михайловна";
            byte fullYears = 25;
            string gMail = "lili@gmail.com";
            double pPoint = 6.2;
            double mScores = 7.3;
            double pInPhysics = 11.6;

            double a = pPoint;
            double b = mScores;
            double c = pInPhysics;

            double d = (a+b+c)/3;

            string newPattern = "Ф.И.О.: {0} \nВозраст: {1} \nЭлектроная почта: {2} \nБалы по программированию: {3} \nБалы по математике: {4} \nБалы по физике: {5}\n";

            Console.WriteLine(
                            newPattern,
                            fName,
                            fullYears,
                            gMail,
                            pPoint,
                            mScores,
                            pInPhysics);

            Console.ReadKey();

            Console.WriteLine("Средний бал ученика: {0}\n", d);

            Console.ReadKey();

            var fName1 = "ФИО:";
            var fAge1 = "Полных лет:";
            var eMail1 = "ЭЛ.Почта:";
            var pPoint1 = "Оценка по Информатике:";
            var mScores1 = "Оценка по Математике:";
            var pInPhysics1 = "Оченка по Физике:";
            var averageStudentScore = "Средний бал учиника:";

            Console.WriteLine($"{fName1,23} {fName,23}");
            Console.WriteLine($"{fAge1,23} {fullYears,23}");
            Console.WriteLine($"{eMail1,23} {gMail,23}");
            Console.WriteLine($"{pPoint1,23} {pPoint,23}");
            Console.WriteLine($"{mScores1,23} {mScores,23}");
            Console.WriteLine($"{pInPhysics1,23} {pInPhysics,23}\n");

            Console.ReadKey();

            Console.WriteLine($"{averageStudentScore,23} {d,23}\n");

            Console.ReadKey();

            Console.WriteLine($"{fName1,23} {fName}");
            Console.WriteLine($"{fAge1,23} {fullYears}");
            Console.WriteLine($"{eMail1,23} {gMail}");
            Console.WriteLine($"{pPoint1,23} {pPoint}");
            Console.WriteLine($"{mScores1,23} {mScores}");
            Console.WriteLine($"{pInPhysics1,23} {pInPhysics}\n");

            Console.ReadKey();

            Console.WriteLine($"{averageStudentScore,23} {d}");

            //Попробывал все варианты. Надеюсь я справился.

            Console.ReadKey();
        }
    }
}
