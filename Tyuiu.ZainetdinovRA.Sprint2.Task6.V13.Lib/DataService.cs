using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            return (g, m, n) switch
            {
                (_, 12, 31) => ($"{g + 1}-01-01"),
                (_, 1, 31) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 2, 28) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 3, 31) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 4, 30) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 5, 31) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 6, 30) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 7, 31) => ($"{g + 1}-{m + 1:D2}-,01"),
                (_, 8, 31) => ($"{g + 1}-{m + 1:D2}-01"),
                (_, 9, 30) => ($"{g + 1}{m + 1:D2}-01"),
                (_, 10, 31) => ($"{g + 1}-{m + 1}-01"),
                (_, 11, 30) => ($"{g + 1}-{m + 1}-01"),
                _ => ($"{g}-{m:D2}-{n + 1:D2}")

            };
        }
    }
}
