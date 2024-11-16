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
                    result = "Семерка";
                    break;
                case 8:
                    result = "Восьмерка";
                    break;
                case 9:
                    result = "Девятка";
                    break;
                case 10:
                    result = "Десятка";
                    break;
                case 11:
                    result = "Валет";
                    break;
                case 12:
                    result = "Дама";
                    break;
                case 13:
                    result = "Король";
                    break;
                case 14:
                    result = "Туз";
                    break;
                default:
                    result = "Такой карты не существует";
                    break;
                    
            }
            return result;
        }
    }
}
