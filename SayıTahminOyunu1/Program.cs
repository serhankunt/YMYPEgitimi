namespace SayıTahminOyunu1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new();//Rastgele sayı oluşturmak için nesne oluşturuldu
            int sayi = rastgele.Next(1, 10);//1 ile 10 arasında bir sayı belirlendi
            int deneme = 0;//Kaçıncı seferde bulunduğunu belirlemek için oluşturulan değişken
            while (true)
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");
                string tahminString = Console.ReadLine();//Kullanıcıdan sayı tahmini alındı
                deneme++;//Deneme değişkeni arttırıldı
                int tahmin = 0;
                if (!int.TryParse(tahminString, out tahmin))//Kullanıcıdan girilen değerin integer olup olmadığı kontrol edildi
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                    continue;//Girilen değer integer değil ise kullanıcıdan yeni tahmin almak için döngünün başına gönderildi
                }
                if (tahmin == sayi)
                {
                    Console.WriteLine($"Tebrikler.{deneme}. denemede buldunuz.");
                    break;//Doğru sayı bulunduysa döngü bitirildi.
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı doğru değil.Tekrar deneyiniz.");
                }
            }
        }
    }
}