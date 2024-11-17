using System.Text;
using Tyuiu.ZainetdinovRA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Спринт #2 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год) *");
            Console.WriteLine("* , m (порядковый номер месяца) и n (число). По заданным g, n и m         *");
            Console.WriteLine("* определить дату следующего дня. Заданный год является високосным.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int mounth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDateOfNextDay(year, mounth, day);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Дата следующего дня: {result}");

        }
    }
}
