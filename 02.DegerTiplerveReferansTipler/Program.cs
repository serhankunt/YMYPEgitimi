using System.Reflection.Metadata;

namespace DegerTiplerveReferansTipler
{
    class program
    {
        static void main(string[] args)
        {
           
            User user = new();
            User user2 = user;
            user2.Name = "ahmet";

            Console.WriteLine(user.Name);

            Console.ReadLine();

        }
    }
}

class User
{
    public string Name = "Tamer";
}


