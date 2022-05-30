public class Psl
{
    public static void Pesel()
    {
        int wynik = 0;
        int iloczyn=1;//mnoznik danej cyfry
        string n = "N";
        string d = "D";
        Console.WriteLine("podaj pesel: ");
        var pesel = Console.ReadLine();
        if (!(int.TryParse(pesel, out int value)))
        {
        for(int i=0;i<pesel?.Length;i++)
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
            if(wynik>0)
            {
                if (wynik%10==0) Console.WriteLine(d+"\n");
                else Console.WriteLine(n+"\n");
            }
        }
        else
        {
            Console.WriteLine("zla wartosc\n");
        }
    }
}