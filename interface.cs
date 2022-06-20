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
        Console.WriteLine("towers");
    }
}
class Fighters : IFight
{
    public void Attacks()
    {
        Console.WriteLine("punch");
    }
}