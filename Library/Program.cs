using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Service;
using Library.User;
using Library.Book;

namespace Library
{


      
    class Program
    {
        public static void Main(string[] args)
        {
            UserService userService = new UserService();
            Admins admin = new Admins();

            bool e = false;
            Console.WriteLine("Welcome to the Library! ");
            while (!e)
            {
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Login as admin");
                Console.WriteLine("0. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        e = true;
                        break;
                    case 1:
                        userService.RegisterUser();
                        break;
                    case 2:
                        userService.LoginUser();
                        break;
                    case 3:
                        admin.LoginAsAdmin();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;


                }
            }
        }
    }
}