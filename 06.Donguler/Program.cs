internal class Program
{
    private static void Main(string[] args)
    {
        
        List<string> names = new ();
        names.Add("serhan");
        names.Add("özge");
        names.Add("betül");
        names.Add("nurhan");
        names.Add("necla");
        names.Add("mustafa");


        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }
        int x = 0;
        while(names.Count > 0)
        {
            Console.WriteLine("Çalışıyor.");
            x++;
            if (x == 5) { break; }
        }
        for(int y=0; y < names.Count; y++)
        {
            if(y==4) { break; }
            if(y==2) { continue; }
            Console.WriteLine(names[y]);
        }
        

    }
}