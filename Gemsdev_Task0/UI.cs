using Gemsdev_Task0.implementations;

namespace Gemsdev_Task0;

public class UI
{
    public static void PrintHeader()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("||    MY PROGRAM from Sloboda    ||");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();
        Console.WriteLine("[1]  Ввод и вывод данных консолью;");
        Console.WriteLine("[2]  Ввод и вывод данных файлами;");
        Console.WriteLine("[3]  Выход из программы;");
    }

    public static void Menu()
    {
        int menuLineNumber = -1, exit = 3;
        //consoleInputAndOutput = 1, fileInputAndOutput = 2, 
        Console.Clear();
        do
        {
            int error = 0;
            do
            {
                PrintHeader();
                Console.Write("\nВыберите номер из меню:\n>>> ");
                try
                {
                    menuLineNumber = Convert.ToInt16(Console.ReadLine());
                    error = 0;
                }
                catch (Exception e)
                {
                    error = 1;
                    Console.Clear();
                    Console.WriteLine("Произошла ошибка ввода:  "+e.Message);
                }
            } while (error == 1);

            Handler handler;
            switch (menuLineNumber)
            {
                case 1:
                    handler = new Handler(new ConsoleReader(), new ConsoleWriter());
                    try
                    {
                        Console.Clear();
                        handler.Handle();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка:  " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка ввода:  "+ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка ввода:  "+ex.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("\nВведите путь к файлу источнику:\n>>> ");
                    string sourcePath = "";
                    string destPath = "";
                    try
                    {
                        sourcePath = Console.ReadLine();
                        Console.Write("\nВведите путь к файлу назначения:\n>>> ");
                        destPath = Console.ReadLine();
                        handler = new Handler(new FileReader(sourcePath), new FileWriter(destPath));
                        handler.Handle();
                    }
                    catch (FormatException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка ввода:  " + ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка ввода:  " + ex.Message);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка:  " + ex.Message);
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Произошла ошибка ввода:  "+e.Message);
                    }
                    break;
                default:
                    Console.Clear();
                    break;
            }
        } while (menuLineNumber != exit);
    }
}