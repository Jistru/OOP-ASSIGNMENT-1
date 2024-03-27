using System;
//Coded by: Diaz, Jestro R.
//From: BSCPE 1-1

namespace OOPASSIGNMENT1NIJES

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            String User = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            String Pass = Console.ReadLine();
            if (User == "Admin" && Pass == "Admin1234!") {
                Console.WriteLine("Login Successfully!");
            }
            else
            {
                Console.WriteLine("\nIncorrect Username or Password");
                Console.WriteLine("\tError 1/3");

                Console.WriteLine("Enter Username:");
                User = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                Pass = Console.ReadLine();

                if (User == "Admin" && Pass == "Admin1234!")
                { 
                    Console.WriteLine("Login Successfully");
                }
                else
                {
                    Console.WriteLine("\nIncorrect Username or Password");
                    Console.WriteLine("\tError 2/3");

                    Console.WriteLine("Enter Username:");
                    User = Console.ReadLine();

                    Console.WriteLine("Enter Password:");
                    Pass = Console.ReadLine();

                    if (User == "Admin" && Pass == "Admin1234!")
                    {
                        Console.WriteLine("Login Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect Username or Password");
                        Console.WriteLine("\tError 3/3");

                        Console.WriteLine("Enter Username:");
                        User = Console.ReadLine();

                        Console.WriteLine("Enter Password:");
                        Pass = Console.ReadLine();

                        if (User == "Admin" && Pass == "Admin1234!")
                        {
                            Console.WriteLine("Login Successfully!");
                        }
                        else 
                        {
                            Console.WriteLine("Username or Password didn't match, please try again later. ");
                        }
                    }
                }
            }
        }
    }
}