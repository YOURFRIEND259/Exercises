interface IFight
{
    void Attacks()
    {
    }
}
interface IWork
{
    void Buildings()
    {
    }
}
class Workers : IWork
{
    public void Buildings()
    {
        Console.WriteLine("tower");
        Console.WriteLine("house");
    }
}
class Fighters : IFight
{
    public void Attacks()
    {
        Console.WriteLine("punch");
        Console.WriteLine("kick");
    }
}