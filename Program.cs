using System;
using System.Threading;
using NUnit.Framework;
namespace Trening
{
    class Program
    {
        public static void Main(string[] args)
        {
            Samochod opel = new Samochod("opel", "jakis inny model", 33.3, 4500.00, "czerwony");
            Samochod sam1 = new Samochod("BWM", "jakis model", 11.1, 2200.00, "zieony");
            Rower bmx = new Rower("BMX", "x241", 0, 300, "czarny");

            Pracownik[] tab = new Pracownik[3];
            tab[0] = new Pracownik("Kowalski", 2200);
            tab[1] = new Pracownik("Kowal", 1200);
            tab[2] = new Pracownik("Koski", 3200);

            int[] intaray = { 1, 2, 56 };
            string[] straray = { "asd", "dfg", "truit" };
            double[] daray = { 2.3, 1.2, 0.0 };
            int[] nummulti = { -5, 1, -2, -3, 4, 1 };

            Singleton singleton = Singleton.Instance;
            singleton.Opis();

            Sorting buble = new Sorting();
            Sorting insert = new Sorting();
            Sorting merge = new Sorting();

            buble.BubbleSort();
            insert.InstertionSort();
            merge.MergeSort();

            BetterFibb.mymemo = new long[36];
            Console.WriteLine("\n{0}", BetterFibb.FibbonaciButBetter(35, false));

            Pracownik.ShowNumberOfEmploeeys();
            Obliczenia BiggestSumOfThree = new Obliczenia();
            Obliczenia reverse = new Obliczenia();
            Obliczenia dziel = new Obliczenia();
            Obliczenia pesel = new Obliczenia();
            Obliczenia prime = new Obliczenia();
            Obliczenia nwd = new Obliczenia();
            Obliczenia disp = new Obliczenia();

            BaseTest test = new BaseTest();

            test.testmethod();

            VehicleBuilder builder;
            Shop shop = new Shop();

            builder = new BicycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            disp.displaySomething(intaray);
            disp.displaySomething(straray);
            disp.displaySomething(daray);

            //Getting_Data.pobieranie();

            Fighters fighters = new Fighters();
            Workers workers = new Workers();
            fighters.Attacks();
            workers.Buildings();

            BiggestSumOfThree.BiggestSumOf3(nummulti);

            Watki.CountDown();

            foreach (Pracownik p in tab)
            {
                p.wykaz_pracownikow();
            }

            Meni.Menu();

            sam1.Jezdzi();
            bmx.jaki_pojazd();
            bmx.Jezdzi();

            Pracownik.Sumuj(tab);
            tab[1].wykaz_pracownikow();

            sam1.jaki_pojazd();
            opel.jaki_pojazd();


            //stworzyc instancje do klasy oblicznia, ktore beda mialy ReadLine'a jako swoja zmienna
            dziel.Dziel(2, 2.5);
            pesel.Pesel();
            nwd.NWD(13569, 6546);
            prime.Prime(12);
            reverse.Reverse();
            Console.ReadKey();
        }
    }
    [TestFixture]
    class ProgramTest
    {
        // Obliczenia dzieli = new Obliczenia();
        [TestCase(4, 2.0, 2)]
        [TestCase(42, 2.0, 21)]
        [TestCase(10, 2.0, 5)]
        [Test]
        public void WynikDziel(int x, double y, int z)
        {
            double result = x / y;
            Assert.AreEqual(z, result);
        }
    }
}