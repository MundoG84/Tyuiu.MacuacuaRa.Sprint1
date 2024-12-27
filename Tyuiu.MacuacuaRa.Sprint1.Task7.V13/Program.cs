
using Tyuiu.MacuacuaRa.Sprint1.Task7.V13.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y=");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("   y^2+cos(x^2)+10");
            Console.WriteLine("z=-----------------=" + ds.Calculate(x, y));
            Console.WriteLine("   x^2+sin(y^2)+10");

            Console.ReadKey();
        }
    }
}
