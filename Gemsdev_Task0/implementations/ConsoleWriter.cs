using Gemsdev_Task0.interfaces;

namespace Gemsdev_Task0.implementations;

public class ConsoleWriter : IDataOutput
{
    public void output(List<Answer> answers)
    {
        if (answers == null || answers.Count == 0)
        {
            throw new ArgumentException("Список ответов null или пуст.");
        }

        Console.WriteLine();
        foreach (Answer answer in answers)
        {
            Console.WriteLine(answer.ToString());
        }
        Console.WriteLine();
    }
}