using Tyuiu.ZainetdinovRA.Sprint2.Task0.V16.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            int x = 1025;
            int y = 275;
            bool[] wait = { true, false, true, false, true, false };
            bool[] result = ds.GetCompareOperations(x, y);
            Assert.AreEqual(string.Join(",", result), string.Join(",", result));
        }
    }
}
