using Tyuiu.MacuacuaRa.Sprint1.Task4.V25.Lib;

namespace Tyuiu.MacuacuaRa.Sprint1.Task4.V25.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 30;
            double wait = Math.Round(0.866362, 3);
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}
