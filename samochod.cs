abstract class Pojazdy
{
        public string marka{ get; set; } = null!;
        public string model{ get; set; } = null!;
        public string kolor{ get; set; } = null!;
        public double pojemnosc,cena;
    public virtual void Jezdzi()
    {
        
    }
    public virtual void jaki_pojazd()
    {
        
    }
}
class Samochod : Pojazdy
    {
        public Samochod(string m, string m2, double p, double c, string k)
        {
            marka=m;
            model=m2;
            pojemnosc=p;
            cena=c;
            kolor=k;
        }
        public override void jaki_pojazd()
        {
            Console.WriteLine("Dane samochodu: \nMarka:{0} \ncena:{1:C} \nkolor:{2}",marka,cena,kolor);
        }
        public override void Jezdzi()
        {
            Console.WriteLine("ten samochod jezdzi");
        }
    }
class Rower : Pojazdy
    {
        public Rower(string m, string m2, double p, double c, string k)
        {
            marka=m;
            model=m2;
            pojemnosc=p;
            cena=c;
            kolor=k;
        }
        public override void jaki_pojazd()
        {
            Console.WriteLine("Dane roweru: \nMarka:{0} \ncena:{1:C} \nkolor:{2}",marka,cena,kolor);
        }
        public override void Jezdzi()
        {
            Console.WriteLine("ten samochod jezdzi");
        }
    }class Lodz : Pojazdy
    {
        public Lodz(string m, string m2, double p, double c, string k)
        {
            marka=m;
            model=m2;
            pojemnosc=p;
            cena=c;
            kolor=k;
        }
        public override void jaki_pojazd()
        {
            Console.WriteLine("Dane Lodzi: \nMarka:{0} \ncena:{1:C} \nkolor:{2}",marka,cena,kolor);
        }
        public override void Jezdzi()
        {
            Console.WriteLine("ten samochod jezdzi");
        }
    }