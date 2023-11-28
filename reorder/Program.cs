class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int[] input = Array.ConvertAll(s.Split(','), int.Parse);

        int cnt = ReorderInput(input);
        
        Console.WriteLine(cnt);
    }

    static int ReorderInput(int[] seq)
    {
        int n = seq.Length;
        int cnt = 0;
        for (int i = 0, j = n - 1; i < j;)
        {
            if (seq[i] == 1 && seq[j] == 0)
            {
                seq[i] = 0;
                seq[j] = 1;
                cnt++;
            }
            if (seq[i] == 0) i++;
            if (seq[j] == 1) j--;
        }
        return cnt;
    }
    
}