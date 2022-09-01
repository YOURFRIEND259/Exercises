class Sorting
{
    public void bubbleSort()
    {
        bool moved=false;
        Console.WriteLine("podaj liczby");
        var input=Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
        Console.WriteLine();
        do
        {
            moved=false;
            for(int i =0; i<input.Count()-1;i++)
            {
                if(input[i]>input[i+1])
                {
                    var x=input[i+1];
                    input[i+1]=input[i];
                    input[i]=x;
                    moved=true;
                }
            }
        }
        while (moved);
        foreach(var ar in input)
        {
            Console.WriteLine(ar.ToString());
        }
        Console.WriteLine();
    }
    public void InstertionSort()
    {

    }
}