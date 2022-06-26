public class Meni
{
    public static void Menu()
    {
        List<String> menu = new List<String>();
        menu.Add("carbonara");
        menu.Add("pizza hawajska");
        menu.Add("ratatuj");
        menu.Add("beef wellington");
        menu.Add("pomidorowa");
        menu.Add("nalesniki");
        foreach (string item in menu)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}