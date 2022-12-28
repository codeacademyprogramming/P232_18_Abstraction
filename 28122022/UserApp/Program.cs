using System;

namespace UserApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SocialMedia media = new SocialMedia("Facebook");
            string opt;
            do
            {

                Console.WriteLine("1. User elave et");
                Console.WriteLine("2. Userlara bax");
                Console.WriteLine("3. Userlar uzerinde axtaris et");
                Console.WriteLine("0. Menudan cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        media.UserRegister();
                        break;
                    case "2":
                        media.ShowUsers();
                        break;
                    case "3":
                        string search = Console.ReadLine();
                        var users = media.SearchUsers(search);

                        for (int i = 0; i < users.Length; i++)
                        {
                            Console.WriteLine(users[i].GetInfo());
                        }
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;
                    default:
                        Console.WriteLine("Secimiz yanlisdir tekrar secin!");
                        break;
                }


            } while (opt!="0");
        }

    }
}
