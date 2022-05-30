public class Suma
{
    public static void Sumuj(Pracownik[] tab)
    {
        double suma=0;
        for(int i=0; i < tab.Length;i++)
        {
            suma+=tab[i].zarobki;
        }
        Console.WriteLine("suma płac wynosi: "+suma+"\n");
    }
}