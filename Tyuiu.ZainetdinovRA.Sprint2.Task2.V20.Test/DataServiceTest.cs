using Tyuiu.ZainetdinovRA.Sprint2.Task2.V20.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
