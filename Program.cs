using System;
using System.Threading;
namespace Trening
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread=Thread.CurrentThread;
            mainThread.Name="main thread";

            Thread thread1=new Thread(CountDown);
            Thread thread2=new Thread(CountUp);
//            thread1.Start();
//            thread2.Start();

//            Console.WriteLine(mainThread.Name+" is complete!!!");
            
            Meni.Menu();
            
            Samochod opel=new Samochod ("opel","jakis inny model",33.3,4500.00,"czerwony");
            Samochod sam1= new Samochod("BWM","jakis model",11.1,2200.00,"zieony");
            
            Rower bmx=new Rower("BMX","x241",0,300,"czarny");

            sam1.Jezdzi();
            bmx.jaki_pojazd();
            bmx.Jezdzi();

            Pracownik[] tab=new Pracownik[3];
            tab[0]=new Pracownik("Kowalski",2200);
            tab[1]=new Pracownik("Kowal",1200);
            tab[2]=new Pracownik("Koski",3200);

            foreach(Pracownik p in tab)
            {
                p.wykaz_pracownikow();
            }

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
        static void CountDown()
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine(":"+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("count down is complete!!!");
            Console.ReadKey();
        }
        static void CountUp()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(":"+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("count up is complete!!!");
            Console.ReadKey();
        }
    } 
}