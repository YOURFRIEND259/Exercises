class Sorting
{
    public void PrintArray(int[] input)
    {
                foreach (var ar in input)
        {
            Console.WriteLine(ar.ToString());
        }
        Console.WriteLine();
    }
    public void BubbleSort()
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
                    (input[i], input[i + 1]) = (input[i + 1], input[i]);
                    moved = true;
                }
            }
        }
        while (moved);
        PrintArray(input);
    }
    public void InstertionSort()
    {
        Console.WriteLine("podaj liczby");
        var input = Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '), Convert.ToInt32);
        Console.WriteLine();
        for (int i = 0; i < input.Count(); i++)
        {
            var item = input[i];
            var index = i;

            while (index > 0 && input[index - 1] > item)
            {
                input[index] = input[index - 1];
                index--;
            }
            input[index] = item;
        }
        PrintArray(input);
    }
    public void MergeSort()
    {
        Console.WriteLine("podaj liczby");
        var input = Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '), Convert.ToInt32);
        Console.WriteLine();

        SortForMerge(input, 0, input.Length - 1);

        PrintArray(input);
    }
    public void Merge(int[] input, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
        {
            L[i] = input[l + i];
        }
        for (j = 0; j < n2; ++j)
        {
            R[j] = input[m + 1 + j];
        }

        i = 0;
        j = 0;

        int k = l;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                input[k] = L[i];
                i++;
            }
            else
            {
                input[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            input[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            input[k] = R[j];
            j++;
            k++;
        }
    }
    public void SortForMerge(int[] input, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;

            SortForMerge(input, l, m);
            SortForMerge(input, m + 1, r);
            Merge(input, l, m, r);
            
        }
    }

}