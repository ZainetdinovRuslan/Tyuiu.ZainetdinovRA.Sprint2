using System.Text;
using Tyuiu.ZainetdinovRA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task5.V5
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
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в        *");
            Console.WriteLine("* зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» —   *");
            Console.WriteLine("* 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их      *");
            Console.WriteLine("* названиям («шестерка», «девятка» и т. п.). По заданному номеру карты k  *");
            Console.WriteLine("* (6 <=k <= 14) определить достоинство соответствующей карты.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите порядковый номер карты: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string result = ds.FindCardValue(x);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Карта, которая соответсвует порядковому номеру {x} это {result}");

        }
    }
}
