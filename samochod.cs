abstract class Pojazdy
{
        public string marka{ get; set; } = null!;
        public string model{ get; set; } = null!;
        public string kolor{ get; set; } = null!;
        public double pojemnosc,cena;
    public virtual void Jezdzi()
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
        public void jakisamochod_p()
        {
            Console.WriteLine("Marka:{0} \ncena:{1:C} \nkolor:{2}",marka,cena,kolor);
        }
        public override void Jezdzi()
        {
            Console.WriteLine("ten samochod jezdzi");
        }
    }
