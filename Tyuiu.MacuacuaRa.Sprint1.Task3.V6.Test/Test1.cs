using Tyuiu.MacuacuaRa.Sprint1.Task3.V6.Lib;

namespace Tyuiu.MacuacuaRa.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double distance = 67.0;
            double gasFlow = 8.5;
            double gasPrice = 6.5;

            var res = ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(74.035, res);
        }
    }
}
