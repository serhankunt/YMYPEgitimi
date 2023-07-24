namespace _11.ArabalarConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();
            Console.WriteLine("Araba Yapay Zekasına Hoş Geldiniz.");
            Console.WriteLine("Size nasıl yardımcı olabilirim?");
            Console.WriteLine("İşlem Listesi:");
            Console.WriteLine("1-Araç Listesi");
            Console.WriteLine("2-Araç Sayısı");
            Console.WriteLine("3-Araç Ekle");
            Console.WriteLine("4-Listeyi Göster");
            Console.WriteLine("");
            while (true)
            {
                string cevap = Console.ReadLine();
                if (cevap.ToLower() == "Çıkış".ToLower())
                {
                    Console.WriteLine("Ziyaretiniz için teşekkürler.Tekrar görüşmek üzere");
                }

                else if (cevap.ToLower() == "Araç Sayısı".ToLower())
                {
                    Console.WriteLine($"Toplam araç sayısı:{cars.Count()}");
                }
                else if (cevap.ToLower() == "Araç Ekle".ToLower())
                {
                    Console.WriteLine("Markayı yazın");
                    string marka = Console.ReadLine();

                tekrar:;
                    Console.WriteLine("Modeli yazın");
                    string modelString = Console.ReadLine();
                    int model = 0;
                    if (!int.TryParse(modelString, out model) == false )
                    {
                        Console.WriteLine("Model bir sayı olmalıdır");
                        goto tekrar;
                    }
                tekrar1:;
                    Console.WriteLine("Motor gücünü yazın");
                    string motorGucuString = Console.ReadLine();
                    int motorGucu = 0;
                    if (!int.TryParse(motorGucuString, out motorGucu)==false)
                    {
                        Console.WriteLine("Motor gücü bir sayı olmalıdır.");

                        goto tekrar1;
                    }

                    Car car  = new Car();
                    car.Marka = marka;
                    car.Model = model;
                    car.MotorGucu = motorGucu;

                    cars.Add(car);

                }
                else if (cevap.ToLower() == "Listeyi göster".ToLower())
                {

                }
                else
                {
                    Console.WriteLine("Sadece listedeki işlemler yapılabilir.");
                }

            }

        }
    }
    public class Car
    {
        public string Marka;
        public string Model;
        public int MotorGucu;

    }
}