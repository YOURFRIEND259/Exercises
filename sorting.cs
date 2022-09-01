class Sorting
{
    public void bubbleSort()
    {
        bool moved = false;

        Console.WriteLine("podaj liczby" + "\n");
        var input = Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '), Convert.ToInt32);
        Console.WriteLine();

        do
        {
            moved = false;
            for (int i = 0; i < input.Count() - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    var x = input[i + 1];
                    (input[i],input[i + 1])=(input[i + 1],input[i]);
                    moved = true;
                }
            }
        }
        while (moved);
        foreach (var ar in input)
        {
            Console.WriteLine(ar.ToString());
        }
        Console.WriteLine();
    }
    public void InstertionSort()
    {
        Console.WriteLine("podaj liczby");
        var input = Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '), Convert.ToInt32);
        Console.WriteLine();
        for(int i =0; i<input.Count();i++ )
        {
            var item = input[i];
            var index = i;

            while(index>0 && input[index-1]>item)
            {
                input[index]=input[index-1];
                index--;
            }
            input[index]=item;
        }


        foreach (var ar in input)
        {
            Console.WriteLine(ar.ToString());
        }
        Console.WriteLine();
    }
}