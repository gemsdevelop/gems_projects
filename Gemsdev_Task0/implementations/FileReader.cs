using Gemsdev_Task0.interfaces;

namespace Gemsdev_Task0.implementations;

public class FileReader : IDataInput
{
    private string _pathToFile = "";

    public FileReader(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentException("Неверный путь к файлу источнику.");
        }
        if (!File.Exists(fileName) || new FileInfo(fileName).Length == 0) {
            throw new FileNotFoundException("Файл источник по данному пути не найден или пуст!");
        } 
        _pathToFile = fileName;
    }
    
    public List<SquareEquation> input()
    {
        int equationsCount = 0;
        List<SquareEquation> list = new List<SquareEquation>();
        StreamReader streamReader = new StreamReader(_pathToFile);
        string line = streamReader.ReadLine();
        do
        {
            Console.WriteLine("**\n");
            char[] separators = { ' ', '\r', '\n' };
            string[] coefficients = line.Split(separators , StringSplitOptions.RemoveEmptyEntries);
            if (coefficients.Length != 3)
            {
                throw new FormatException("Содержимое строки файла источника не подходит для обработки.");
            }
            list.Add(new SquareEquation(Convert.ToDouble(coefficients[0]), Convert.ToDouble(coefficients[1]), Convert.ToDouble(coefficients[2])));
            line = streamReader.ReadLine();
        } while (line != null);

        streamReader.Close();
        return list;
    }
}