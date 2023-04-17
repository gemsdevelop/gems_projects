using Gemsdev_Task0.interfaces;

namespace Gemsdev_Task0.implementations;

public class FileWriter : IDataOutput
{
    private string _pathToFile = "";

    public FileWriter(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentException("Неверный путь к файлу назначения.");
        }
        if (!File.Exists(fileName)) {
            throw new FileNotFoundException("Файл назначения по данному пути не найден!");
        } 
        _pathToFile = fileName;
    }
    public void output(List<Answer> answers)
    {
        if (answers == null || answers.Count == 0)
        {
            throw new ArgumentException("Список ответов null или пуст.");
        }

        StreamWriter streamWriter = new StreamWriter(_pathToFile, false);
        foreach (Answer answer in answers)
        {
            streamWriter.WriteLine(answer.ToString());
            //streamWriter.WriteAsync("*\n");
        }
        streamWriter.Close();
    }
}