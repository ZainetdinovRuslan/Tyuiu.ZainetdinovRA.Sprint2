using Tyuiu.ZainetdinovRA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int g = 2006;
            int m = 3;
            int n = 26;
            string wait = "2006-03-27";
            string result = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, result);
        }
    }
}
