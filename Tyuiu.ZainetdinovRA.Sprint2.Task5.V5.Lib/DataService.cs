using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string result = "";
            switch (value)
            {
                case 6:
                    result = "Шестерка";
                    break;
                case 7:
                    result = "семерка";
                    break;
                case 8:
                    result = "восьмерка";
                    break;
                case 9:
                    result = "девятка";
                    break;
                case 10:
                    result = "десятка";
                    break;
                case 11:
                    result = "валет";
                    break;
                case 12:
                    result = "дама";
                    break;
                case 13:
                    result = "король";
                    break;
                case 14:
                    result = "туз";
                    break;
                default:
                    result = "Такой карты не существует";
                    break;
                    
            }
            return result;
        }
    }
}
