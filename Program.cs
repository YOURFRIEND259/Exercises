using System;

class Test
{
	static void Main()
	{
        Console.WriteLine(Dziel(1,2.5));
        string? pesel = Console.ReadLine();
        Console.WriteLine(Pesel(pesel));
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
            {if (wynik%10==0) return d;
            else return n;
            }
        else return x;
    }
}