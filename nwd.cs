public class Najwd
{   
    public int a;
    public int b;

    public Najwd(int c, int d)
    {
        c=a;
        d=b;
    }
    public static void NWD(int c,int d)
        {
            
            if(d==0) 
            {
                Console.WriteLine(c+"\n");
            }
            else  NWD(d, c%d);
            
        }}