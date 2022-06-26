public class Pracownik
{
    private string nazwisko;
    public double zarobki { set; get; }

    public Pracownik(string n, double x)
    {
        nazwisko = n;
        zarobki = x;
        numberOfemployees++;
    }
    public void wykaz_pracownikow()
    {
        Console.WriteLine("Nazwisko:{0} \nZarobki: {1:C}", nazwisko, zarobki + "\n");
    }
    public static void Sumuj(Pracownik[] tab)
    {
        double suma = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            suma += tab[i].zarobki;
        }
        Console.WriteLine("suma płac wynosi: " + suma + "\n");
    }
    public static int numberOfemployees;
    public static void ShowNumberOfEmploeeys()
    {
        Console.WriteLine(Pracownik.numberOfemployees + "\n");
    }
}