//[] listeleri temsil eder.
namespace Listeler {
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "asdas", "asdasd" };
            string[] names1 = new string[3];
            names1[0] = "Serhan";
            names1[1] = "Özge";
            names1[2] = "Betül";
            


            List<string> names = new List<string>() { "sadasd", "asdasd" };


            var user1 = new User();
            var user2 = new User();
            var user3 = new User();


            user3.Name = "Serhan";

            Console.WriteLine(user3.Name);
            Console.ReadLine();
        }
    }
//Örneğe dönüştürme işleminde new kelimesini kullanıyoruz.Örneğe dönüştürme işlemine instance üretmek deniyor.

}
class User
{
    public string Name;
}





