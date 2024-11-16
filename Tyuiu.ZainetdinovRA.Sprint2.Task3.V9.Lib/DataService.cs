using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                if (x == 7)
                {
                    Console.WriteLine("Error: Division by zero is not possible!");
                    return double.NaN;
                }
                else
                {
                    y = x * Math.Pow((x + 15 )/ (x - 7), x);
                }
            } 
            else if (x == 0)
            {
                if ((Math.Cos(x) - Math.Sin(x) == 0)) 
                {
                    Console.WriteLine("Error: Division by zero is not possible!");
                    return double.NaN;
                }
                else
                {
                    y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
                }
            }
            else if ( - 13 < x && x < 0)
            {
                y = Math.Pow(1 + 4 / Math.Pow(x, 2), x);
            }
            else if (x < - 13)
            {
                y = x + 10 * x + (1 / x);
            }
            return Math.Round(y, 3);
        }
    }
}
