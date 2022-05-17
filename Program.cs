﻿using System;
namespace Trening
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod sam1= new Samochod("BWM","jakis model",11.1,2200.00,"zieony");
            Pracownik[] tab=new Pracownik[3];
            tab[0]=new Pracownik("Kowalski",2200);
            tab[1]=new Pracownik("Kowal",1200);
            tab[2]=new Pracownik("Koski",3200);
            foreach(Pracownik p in tab)
            {
                p.wykaz_pracownikow();
            }
            Console.WriteLine(Sumuj(tab));
            tab[1].wykaz_pracownikow();
            sam1.jakisamochod_p();
            Console.WriteLine("give string to revese: ");
            string? sting=Console.ReadLine();
            Console.WriteLine(Dziel(2,2.5));
            Console.WriteLine("podaj pesel: ");
            string? pesel = Console.ReadLine();
            Console.WriteLine(Pesel(pesel));
            Console.WriteLine(NWD(2,3));
            Reverse(sting);
            Console.ReadKey();
        }
        public static double Sumuj(Pracownik[] tab)
        {
            double suma=0;
            for(int i=0; i < tab.Length;i++)
            {
                suma+=tab[i].zarobki;
            }
            return suma;
        }
        static void Reverse(string str)
        {
            char[] charArray=str.ToCharArray();
            for(int i=0, j=str.Length-1; i<j; i++, j--)
            {
                charArray[i]=str[j];
                charArray[j]=str[i];
            }
            string reverse=new string (charArray);
            Console.WriteLine(reverse);
            
        }
        static double Dziel(int x, double y)
        {
            return (y/x);
        }
        static string Pesel(string pesel)
        {
            int wynik = 0;
            int iloczyn=1;//mnoznik danej cyfry
            string n = "N";
            string d = "D";
            string x= "zla wartosc ";
            for(int i=0;i<pesel.Length;i++)
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
                    if (wynik%10==0) return d;
                    else return n;
                }
            else return x;
        }
        static int NWD(int a, int b)
        {
            if(b==0) return a;
            else return NWD(b, a%b);
        }
    } 
}