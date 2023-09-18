internal class Programm
{
    static void Main()
    {
        string path_to_file = @"C:\Users\Yehor\Desktop\privitSvit.txt";

        string text = File.ReadAllText(path_to_file);
        Console.WriteLine(text);

        Console.WriteLine("How is your name: ");
            text += Console.ReadLine();

        File.WriteAllText(path_to_file, text);
    }
}