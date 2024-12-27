using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MacuacuaRa.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            double q = Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            double w = Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 10;
            double z = q / w;
            return Math.Round(z, 3);
        }
    }
}
