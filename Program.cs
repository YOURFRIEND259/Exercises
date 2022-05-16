using System;

public class Samochod
{
    public string marka;
    public string model;
    public double pojemnosc;
    public double cena;
    public string kolor;

    public Samochod(string m, string m2, double p, double c, string k)
    {
        marka=m;
//        model=m2;
//        pojemnosc=p;
        cena=c;
        kolor=k;
    }
    public void jakisamochod_p()
    {
        Console.WriteLine("Marka:{0} cena:{1} kolor:{2}",marka,cena,kolor);
    }




}
public class Pracownik
{
    public string nazwisko;
    public double zarobki{set; get;}

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
        Samochod sam1= new Samochod("BWM","jakis model",11.1,2200.00,"zieony");
        Pracownik[] tab=new Pracownik[3];
        tab[0]=new Pracownik("Kowalski",2200);
        tab[1]=new Pracownik("Kowal",1200);
        tab[2]=new Pracownik("Koski",3200);
        foreach(Pracownik p in tab)
        {
            p.wykaz_pracownikow();
        }
        Console.WriteLine(Sumuj(tab));
        tab[1].wykaz_pracownikow();
        sam1.jakisamochod_p();
        Console.WriteLine(Dziel(1,2.5));
        string? pesel = Console.ReadLine();
        Console.WriteLine(Pesel(pesel));
        Console.WriteLine(NWD(2,3));
        Console.ReadKey();
	}
    public static double Sumuj(Pracownik[] tab)
    {
        double suma=0;
        for(int i=0; i < tab.Length;i++)
        {
            suma+=tab[i].zarobki;
        }
        return suma;
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