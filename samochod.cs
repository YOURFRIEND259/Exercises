    public class Samochod
    {
        public string marka,model,kolor;
        public double pojemnosc,cena;
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
    }
