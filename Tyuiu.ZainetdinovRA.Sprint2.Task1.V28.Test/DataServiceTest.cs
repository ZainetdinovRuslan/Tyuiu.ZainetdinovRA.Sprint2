using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[] { c == d | d == c, c != d & d != c, a < b || b < c, b > a && a > c, !(a >= d), d >= a ^ c >= d };
        }
    }
}