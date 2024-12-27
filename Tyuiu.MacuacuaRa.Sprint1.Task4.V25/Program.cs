using Tyuiu.MacuacuaRa.Sprint1.Task4.V25.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            double a;

            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("(1 - cosa)/((sina)^2 = " + Math.Round(ds.Calculate(a), 3));
            Console.ReadKey();
        }
    }
}
