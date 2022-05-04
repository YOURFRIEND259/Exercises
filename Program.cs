using System;

public class Test
{
	public static void Main()
	{
		string? pesel = Console.ReadLine();
        int wynik = 0;
        int iloczyn=1;//mnoznik danej cyfry

        for(int i=0;i<11;i++)
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
            {if (wynik%10==0)
                {
                    Console.WriteLine("D");
                }
            else
            {
                Console.WriteLine("N");
            }}
	}
}