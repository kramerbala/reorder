class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine(); //input beolvasasa
        int[] input = Array.ConvertAll(s.Split(','), int.Parse); // tagolo vesszonkent felbontas es int tombbe helyezes

        int cnt = ReorderInput(input); // fuggvenyhivas int tomb parameterrel visszateresi erteke a cserek szama
        
        Console.WriteLine(cnt); //cserek szamanak kiirasa a konzolra

        Console.ReadLine();
    }

    static int ReorderInput(int[] seq) // function parametere egy int tomb
    {
        int n = seq.Length; // a parameter tomb hossza (hany elem van benne)
        int cnt = 0; // cserek szama (kezdetben 0)
        for (int i = 0, j = n - 1; i < j;) // for loop ket iteratorral i = 0 (elolrol halad) j = n - 1 (hatulrol halad kezdeti erteke a tomb elemszama -1 mivel ha egy tomb 3 elemu akkor az indexek 0,1,2 igy itt a j = 3-1 )
        {
            if (seq[i] == 1 && seq[j] == 0) // ha a tomb i. eleme 1 es j. eleme 0 akkor cserelni kell
            {
                seq[i] = 0; // a tomb i. eleme 0 lesz 
                seq[j] = 1; // a tomb j. eleme 1 lesz 
                cnt++; // vegrehajtottunk egy cseret igy cnt++ (cnt = cnt+1 vagy cnt += 1)
            }
            if (seq[i] == 0) i++; // ha az i. elem 0 akkor i-t tovabb leptetjuk (i++) hiszen i 1-est keres a cserehez
            if (seq[j] == 1) j--; // ha az j. elem 1 akkor i-t tovabb leptetjuk (j-- mivel o hatulrol halad) hiszen j 0-est keres a cserehez
        }
        return cnt; // vegrehajtott cserek szamanak visszaadasa
    }
    
}
