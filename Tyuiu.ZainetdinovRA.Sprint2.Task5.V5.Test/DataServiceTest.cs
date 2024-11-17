using Tyuiu.ZainetdinovRA.Sprint2.Task5.V5.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int value = 13;
            string wait = "король";
            string result = ds.FindCardValue(value);
            Assert.AreEqual(wait, result);
        }
    }
}
