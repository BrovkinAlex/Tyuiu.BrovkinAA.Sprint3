using Tyuiu.BrovkinAA.Sprint3.Task5.V17.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 12);
            double wait = 143.624;

            Assert.AreEqual(wait, res);
        }
    }
}