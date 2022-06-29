public class BetterFibb
{
    public static long[] mymemo = null!;
    public static long nNum = 0;

    public static long FibbonaciButBetter(long n, bool memo = true)
    {
        if (memo)
        {
            if (mymemo[n] != 0)
            {
                return mymemo[n];
            }
        }
        nNum++;
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        mymemo[n] = FibbonaciButBetter(n - 1, memo) + FibbonaciButBetter(n - 2, memo);
        return mymemo[n];

    }
}