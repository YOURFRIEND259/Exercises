public class Dzielenie
{
    public int pierwsza;
    public double druga;
    public Dzielenie(int p, double d)
    {
        pierwsza=p;

        druga=d;
    }
        public static void Dziel(int pierwsza, double druga)
        {
            Console.WriteLine(pierwsza/druga+"\n");
        }
}