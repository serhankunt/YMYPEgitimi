class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Lütfen isminizi giriniz:");
        string name = Console.ReadLine();
        Console.WriteLine("Tahmin oyununa hoşgeldiniz " + name);
        Random rastgale = new();
        int sayi = rastgale.Next(1, 10);

        

        
        int tahmin = 0;
        int deneme = 0;
        Console.WriteLine("1 ile 10 arasında bir sayı tahmin ediniz:");



        while (sayi != tahmin)
        {
            Console.WriteLine("Lütfen 1 ile 10 arasında sayi tahmin edin");
            string tahminEdilenSayi = Console.ReadLine();

            

            if(int.TryParse(tahminEdilenSayi, out tahmin)==false)
            {
                Console.WriteLine("Sadece rakam girilebilir.");
                continue;
            }
            if (tahmin > 10)
            {
                Console.WriteLine("Sadece 1-10 arasında rakam girilebilir.");
            }

            if (sayi.ToString() == tahminEdilenSayi)
            {
                Console.WriteLine("Doğru tahmin ettiniz.");
                tahmin = sayi;
                continue;
            }
            
            Console.WriteLine("Sayıyı doğru tahmin edemediniz.");
            
        }

        

    }
}