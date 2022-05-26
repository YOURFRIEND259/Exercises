    public class Pracownik
    {
        public string nazwisko;
        public double zarobki{set; get;}

        public Pracownik(string n, double x)
        {
            nazwisko=n;
            zarobki=x;
        }
        public void wykaz_pracownikow()
        {
            Console.WriteLine("Nazwisko:{0} \nZarobki: {1:C}",nazwisko,zarobki+"\n");
        }
    }