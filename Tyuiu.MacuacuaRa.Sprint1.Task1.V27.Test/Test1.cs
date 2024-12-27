using Tyuiu.MacuacuaRa.Sprint1.Task1.V27.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task1.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 1.0);
        }
    }
}
