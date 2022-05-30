class Watki
{
    public static void watki()
    {       Thread mainThread=Thread.CurrentThread;
            mainThread.Name="main thread";

            Thread thread1=new Thread(CountDown);
            Thread thread2=new Thread(CountUp);
            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name+" is complete!!!");}
        public static void CountDown()
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine(":"+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("count down is complete!!!\n");
            Console.ReadKey();
        }
        static void CountUp()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(":"+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("count up is complete!!!\n");
            Console.ReadKey();
        }
}