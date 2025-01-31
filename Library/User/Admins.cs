using Library.Service;

namespace Library.User;

public class Admins
{
          List<string> admins = new List<string>() { "Mendy", "Baer" };
        List<string> passwords = new List<string>() { "1111" };

        public void LoginAsAdmin()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            if (admins.Contains(name) && passwords.Contains(password))
            {
                Console.WriteLine("You are already logged in!");
                bool l = false;
                while (!l)
                {
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Main Menu");
                    Console.WriteLine("3. All users");
                    Console.WriteLine("4. All Books");
                    Console.WriteLine("0. Exit ");
                    Console.WriteLine("Choose an option:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {

                        case 1:
                            Service.Library lib = new Service.Library();
                            lib.addBook();
                            break;
                        case 2:
                            return;
                        case 3:

                            UserService user = new UserService();
                            user.AllUsers();
                            break;


                        case 4:
                            Service.Library lib1 = new Service.Library();
                            lib1.AllBooks();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter a valid option");
                            break;
                    }
                }



            }
            else
            {
                Console.WriteLine("Error");
            }
        }
}