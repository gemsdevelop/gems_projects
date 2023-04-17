using Gemsdev_Task0.interfaces;

namespace Gemsdev_Task0.implementations;

public class ConsoleReader : IDataInput
{
    public List<SquareEquation> input()
    {
        int equationsCount = 0;
        List<SquareEquation> list = new List<SquareEquation>();

        while (equationsCount <= 0)
        {
            Console.Write("Введите количество уравнений:\n");
            equationsCount = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Введите коэффициенты:\n");
        for (int i = 0; i < equationsCount; i++)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            SquareEquation squareEquation = new SquareEquation(a,b,c);
            list.Add(squareEquation);
        }
        Console.Write("\n\n");
        return list;
    }
}