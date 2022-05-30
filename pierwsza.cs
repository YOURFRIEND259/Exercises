public class Pierwsza
{
    public static void Prime(int liczba)
    {
        if(liczba<=0)
        {
            Console.WriteLine("podano zla wartosc\n");
        }
        if (liczba==1)Console.WriteLine(1+"\n");
        if (liczba==2)Console.WriteLine(2+"\n");
        for(int i=3;i<liczba;i+=2)
        {
            if(liczba%i==0) Console.WriteLine("it's not prime a number"+"\n");
        
            else if((liczba%i!=0)&&(i>=liczba)) Console.WriteLine("it is prime a number"+"\n");
        }
    }
}