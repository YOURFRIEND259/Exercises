using System;
using System.Threading;
namespace Trening
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod opel=new Samochod ("opel","jakis inny model",33.3,4500.00,"czerwony");
            Samochod sam1= new Samochod("BWM","jakis model",11.1,2200.00,"zieony");
            Rower bmx=new Rower("BMX","x241",0,300,"czarny");

            Pracownik[] tab=new Pracownik[3];
            tab[0]=new Pracownik("Kowalski",2200);
            tab[1]=new Pracownik("Kowal",1200);
            tab[2]=new Pracownik("Koski",3200);

            foreach(Pracownik p in tab)
            {
                p.wykaz_pracownikow();
            }

            Watki.CountDown();
            Meni.Menu();

            sam1.Jezdzi();
            bmx.jaki_pojazd();
            bmx.Jezdzi();

            Pracownik.Sumuj(tab);
            tab[1].wykaz_pracownikow();

            sam1.jaki_pojazd();
            opel.jaki_pojazd();

            Obliczenia.Dziel(2,2.5);
            Obliczenia.Pesel();
            Obliczenia.NWD(86,12);
            Obliczenia.Prime(12);
            Obliczenia.Reverse();
            Console.ReadKey();
        }
    } 
}