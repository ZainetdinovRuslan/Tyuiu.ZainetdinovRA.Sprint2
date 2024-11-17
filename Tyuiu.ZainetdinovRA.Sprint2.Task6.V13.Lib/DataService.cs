using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            return (g, m, n) switch
            {
                (_, 12, 31) => ($"01.01.{g + 1}"),
                (_, 1, 31) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 2, 28) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 3, 31) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 4, 30) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 5, 31) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 6, 30) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 7, 31) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 8, 31) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 9, 30) => ($"{n + 1:D2}.{m + 1:D2}.{g}"),
                (_, 10, 31) => ($"{n + 1:D2}.{m + 1}.{g}"),
                (_, 11, 30) => ($"{n + 1:D2}.{m + 1}.{g}"),
                _ => ($"{n + 1:D2}.{m:D2}.{g}")

            };
        }
    }
}
