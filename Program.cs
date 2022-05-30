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

            Sumuj(tab);
            tab[1].wykaz_pracownikow();

            sam1.jaki_pojazd();
            opel.jaki_pojazd();

            Dzielenie.Dziel(2,2.5);
            Pesel();
            Najwd.NWD(2,3);
            Prime(12);
            Reverse();
            Console.ReadKey();
        }


        static void Prime(int liczba)
        {
            if(liczba<=0)
            {
                Console.WriteLine("podano zla wartosc\n");
            }
            if (liczba==1)Console.WriteLine(1+"\n");
            if (liczba==2)Console.WriteLine(2+"\n");
            for(int i=3;i<liczba;i+=2)
            {
                if(liczba%i==0) Console.WriteLine("it's not prime a number"+"\n");
            
                else if((liczba%i!=0)&&(i>=liczba)) Console.WriteLine("it is prime a number"+"\n");
            }
        }

        static void Sumuj(Pracownik[] tab)
        {
            double suma=0;
            for(int i=0; i < tab.Length;i++)
            {
                suma+=tab[i].zarobki;
            }
            Console.WriteLine("suma płac wynosi: "+suma+"\n");
        }

        static void Reverse()
        {
            Console.WriteLine("give string to revese: ");
            var sting=Console.ReadLine();
            char[] charArray=sting!.ToCharArray();
            for(int i=0, j=sting.Length-1; i<j; i++, j--)
            {
                charArray[i]=sting[j];
                charArray[j]=sting[i];
            }
            string reverse=new string (charArray);
            Console.WriteLine(reverse+"\n");
            
        }

        static void Pesel()
        {

            int wynik = 0;
            int iloczyn=1;//mnoznik danej cyfry
            string n = "N";
            string d = "D";
            Console.WriteLine("podaj pesel: ");
            var pesel = Console.ReadLine();
            if (!(int.TryParse(pesel, out int value)))
            {
            for(int i=0;i<pesel?.Length;i++)
                {
                    string cyfra=pesel.Substring(i,1);
                    int npesel = Int32.Parse(cyfra);

                    if ((iloczyn>9)||(i==10))
                    {
                        iloczyn=1;
                    }
                    if (iloczyn==5)
                    {
                        iloczyn=iloczyn+2;
                    }
                    wynik+=npesel*iloczyn;
                    iloczyn=iloczyn+2;
                }
                if(wynik>0)
                {
                    if (wynik%10==0) Console.WriteLine(d+"\n");
                    else Console.WriteLine(n+"\n");
                }
            }
            else
            {
                Console.WriteLine("zla wartosc\n");
            }

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