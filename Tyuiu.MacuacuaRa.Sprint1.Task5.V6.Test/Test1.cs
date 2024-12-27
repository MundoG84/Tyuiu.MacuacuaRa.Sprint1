using Tyuiu.MacuacuaRa.Sprint1.Task5.V6.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 20;

            DataService ds = new DataService();
            double res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 6;
            Assert.AreEqual(wait, result);
        }
    }
}
