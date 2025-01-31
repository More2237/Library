using System;
using Library.Service;
using Library.User;



namespace Library.Service;





public class UserService
{
    public List<User.User> users = new List<User.User>();

        public void RegisterUser()
        {
            User.User newUser = new User.User();
            newUser.Id = Guid.NewGuid();
            Console.Write("Please enter user name: ");
            newUser.UserName = Console.ReadLine();
            if (string.IsNullOrEmpty(newUser.UserName))
            {
                Console.Write("The name is invalid: ");
                return;
            }
            else if (newUser.UserName.Length < 3)
            {
                Console.Write("Username must be at least 3 characters");
                return;
            }
            else
            {
                Console.Write("Please enter password: ");
                newUser.Password = Console.ReadLine();
                if (string.IsNullOrEmpty(newUser.Password))
                {
                    Console.Write("The password is invalid: ");
                    return;
                }
                else if (newUser.Password.Length < 6)
                {
                    Console.Write("Password must be at least 6 characters");
                    return;

                }
                else
                {
                    Console.Write("Please enter email: ");
                    newUser.Email = Console.ReadLine();
                    if (string.IsNullOrEmpty(newUser.Email))
                    {
                        Console.Write("The email is invalid: ");
                        return;
                    }
                    else if (newUser.Email.Length < 6)
                    {
                        Console.Write("Email must be at least 6 characters");
                        return;
                    }
                    else
                    {
                        Console.Write("Please enter phone number: ");
                        newUser.Phone = Console.ReadLine();
                        if (string.IsNullOrEmpty(newUser.Phone))
                        {
                            Console.WriteLine("The phone number is invalid: ");
                            return;

                        }
                        else if (newUser.Phone.Length < 9 && newUser.Phone.Length > 9)
                        {
                            Console.Write("Phone number must be at least 9 characters");
                            return;
                        }
                        else
                        {
                            users.Add(newUser);
                            Console.WriteLine("Registration done  ID " + newUser.Id + "\nMr " + newUser.UserName +
                                              " your e-mail is " + newUser.Email +
                                              "@gmail.com\nYou number phone is +992" + newUser.Phone + "\n");

                            bool h = false;
                            while (!h)
                            {
                                Console.Write("Choose an option:");
                                Console.WriteLine("1. Search Book");
                                Console.WriteLine("2. Main Menu");
                                Console.WriteLine("0. Exit ");
                                int a = Convert.ToInt32(Console.ReadLine());
                                switch (a)
                                {
                                    case 1:
                                        Library lib = new Library();
                                        break;
                                    case 2:
                                        return;
                                    case 0:
                                        Environment.Exit(0);
                                        break;
                                }

                            }


                        }
                    }
                }

            }

            if (users.Contains(newUser))
            {
                Console.WriteLine("User already exists");
            }
            else
            {
                users.Add(newUser);
            }

        }

        public void LoginUser()
        {
            Console.Write("Please enter user name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();

            foreach (var i in users)
            {
                if (i == users.FirstOrDefault(x => x.UserName == userName && x.Password == password))
                {
                    Console.WriteLine("User logged in");

                }
                else
                {
                    Console.WriteLine("User does not exist");
                    return;
                }
            }



        }

        public void AllUsers()
        {
            
            int m = 0;
            foreach (var i in users)
            {
                Console.WriteLine(m++ + " " + i.UserName);
            }


        }




    }




