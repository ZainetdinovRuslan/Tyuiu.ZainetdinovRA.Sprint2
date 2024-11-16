using System.Transactions;
using Tyuiu.ZainetdinovRA.Sprint2.Task3.V9.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint2.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService(); 
            double x = 1;
            double wait = -2.667;
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }
    }
}
