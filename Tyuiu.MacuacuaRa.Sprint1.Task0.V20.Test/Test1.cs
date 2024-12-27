
using Tyuiu.MacuacuaRa.Sprint1.Task0.V20.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task0.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}
