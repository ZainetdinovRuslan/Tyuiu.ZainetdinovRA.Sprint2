using Tyuiu.ZainetdinovRA.Sprint2.Task7.V8.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
