using System;

public class Pracownik
{
    public string nazwisko;
    public double zarobki{set;private get;}

    public Pracownik(string n, double x)
    {
        nazwisko=n;
        zarobki=x;
    }
    public void wykaz_pracownikow()
    {
        Console.WriteLine("Nazwisko:{0} Zarobki: {1}",nazwisko,zarobki);
    }
}
class Program
{
	static void Main()
	{
        Pracownik p1=new Pracownik("Kowalski",2150);
        p1.wykaz_pracownikow();
        Console.WriteLine(Dziel(1,2.5));
        string? pesel = Console.ReadLine();
        Console.WriteLine(Pesel(pesel));
        Console.WriteLine(NWD(2,3));
        Console.ReadKey();
	}
    static double Dziel(int x, double y)
    {
        return (y/x);
    }
    static string Pesel(string pesel)
    {
        int wynik = 0;
        int iloczyn=1;//mnoznik danej cyfry
        string n = "N";
        string d = "D";
        string x= "zla wartosc ";
        for(int i=0;i<pesel.Length;i++)
            {
                string cyfra=pesel.Substring(i,1);
                int npesel = Int32.Parse(cyfra);

                if ((iloczyn>9)||(i==10))
                {
                    iloczyn=1;
                }
                if (iloczyn==5)
                {
                    iloczyn=iloczyn+2;
                }
                wynik+=npesel*iloczyn;
                iloczyn=iloczyn+2;
            }
//            return wynik;
        if(wynik>0)
            {
                if (wynik%10==0) return d;
                else return n;
            }
        else return x;
    }
    static int NWD(int a, int b)
    {
        if(b==0) return a;
        else return NWD(b, a%b);
    }
}