public class Singleton
{
    private static Singleton instance = new Singleton();
    private Singleton() { }
    public static Singleton Instance
    {
        get { return instance; }
    }
    public void Opis()
    {
        Console.WriteLine("Ten 'program' ma na celu udoskonalanie moich umiejetnosci korzystania z C# \n");
    }
}