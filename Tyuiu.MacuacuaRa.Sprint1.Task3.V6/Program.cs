using Tyuiu.MacuacuaRa.Sprint1.Task3.V6.Lib;
namespace Tyuiu.MacuacuaRa.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double distance = 67.0;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            Console.WriteLine("Расстояние до дачи(км) = " + distance);
            Console.WriteLine("Расход бензина (литров на 100 км пробега) = " + gasFlow);
            Console.WriteLine("Цена литра бензина (руб.) = " + gasPrice);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Поездка на дачу и обратно обойдется в " + ds.TravelCost(distance, gasFlow, gasPrice) + "руб.");
            Console.ReadLine();
        }
    }
}
