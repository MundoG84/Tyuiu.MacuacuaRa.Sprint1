

using Tyuiu.MacuacuaRa.Sprint1.Task7.V13.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task7.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double x = 45;
            double y = 30;
            var res = service1.Calculate(x, y);
            Assert.AreEqual(1, 001, res);
        }
    }
}
