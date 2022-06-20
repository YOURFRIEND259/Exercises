
public class Obliczenia : Getting_Data
{
    private int pierwsza { get; set; }
    private double druga { get; set; }
    private int a { get; set; }
    private int b { get; set; }

    private Obliczenia(int p, double dr, int c, int d)
    {
        pierwsza = p;
        druga = dr;
        c = a;
        d = b;
        d = b;
    }

    public static void Reverse()
    {
        Console.WriteLine("give string to revese: \n");
        string? sting = Console.ReadLine();
        char[] charArray = sting!.ToCharArray();
        for (int i = 0, j = sting.Length - 1; i < j; i++, j--)
        {
            charArray[i] = sting[j];
            charArray[j] = sting[i];
        }
        string reverse = new string(charArray);
        Console.WriteLine(reverse + "\n");
    }

    public static void Dziel(int pierwsza, double druga)
    {
        Console.WriteLine(pierwsza / druga + "\n");
    }

    public static void Prime(int liczba)
    {
        if (liczba <= 0)
        {
            Console.WriteLine("podano zla wartosc\n");
        }
        if (liczba == 1)
            Console.WriteLine(1 + "\n");
        if (liczba == 2)
            Console.WriteLine(2 + "\n");
        for (int i = 3; i < liczba; i += 2)
        {
            if (liczba % i == 0)
                Console.WriteLine("it's not prime a number" + "\n");

            else if ((liczba % i != 0) && (i >= liczba))
                Console.WriteLine("it is prime a number" + "\n");
        }
    }
    public static void Pesel()
    {
        int wynik = 0;
        int iloczyn = 1;//mnoznik danej cyfry
        string n = "N";
        string d = "D";
        Console.WriteLine("podaj pesel: \n");
        var pesel = Console.ReadLine();
        if (!(int.TryParse(pesel, out int value)))
        {
            for (int i = 0; i < pesel?.Length; i++)
            {
                string cyfra = pesel.Substring(i, 1);
                int npesel = Int32.Parse(cyfra);
                if ((iloczyn > 9) || (i == 10))
                    iloczyn = 1;

                if (iloczyn == 5)
                    iloczyn = iloczyn + 2;
                wynik += npesel * iloczyn;
                iloczyn = iloczyn + 2;
            }
            if (wynik > 0)
            {
                if (wynik % 10 == 0)
                    Console.WriteLine(d + "\n");
                else
                    Console.WriteLine(n + "\n");
            }
        }
        else
        {
            Console.WriteLine("zla wartosc\n");
        }
    }
    public static void NWD(int c, int d)
    {
        if (d == 0) Console.WriteLine(c + "\n");
        else NWD(d, c % d);
    }
    public static void displaySomething<T>(T[] aray)
    {
        foreach(T item in aray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }


}
//tutaj beda wszystkie pobierania danych z klasy "Obliczenia" 

public class Getting_Data
{
    public static void pobieranie()
    {
        string? reverse_string = Console.ReadLine();
        int first_num_divide = Convert.ToInt32(Console.ReadLine());
        int second_num_divide = Convert.ToInt32(Console.ReadLine());
        int peseL = Convert.ToInt32(Console.ReadLine());
        int nwd_1 = Convert.ToInt32(Console.ReadLine());
        int nwd_2 = Convert.ToInt32(Console.ReadLine());
    }



}