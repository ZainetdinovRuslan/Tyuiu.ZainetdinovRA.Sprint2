using Tyuiu.ZainetdinovRA.Sprint2.Task4.V10.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double wait = 8;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
