using System;

namespace Sesi_3
{
    public class Logika5
    {
        public static void Main(string[] args)
        {
            string name, choice, cho;
            int month;
            Console.WriteLine("=====Welcome to Program=====");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Welcome, {name}!");
            do
            {
                Console.WriteLine("Do you want to input a number of month in a year or default month now ? [Input/Now]:  ");
                cho = Console.ReadLine();
                if (cho == "Now")
                {
                    month = DateTime.Now.Month;
                    switch (month)
                    {
                        case 1:
                            {
                                Console.WriteLine("It's January. ");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("It's February. ");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("It's March. ");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("It's April. ");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("It's May. ");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("It's June. ");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("It's July. ");
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("It's August. ");
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("It's September. ");
                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine("It's October. ");
                                break;
                            }
                        case 11:
                            {
                                Console.WriteLine("It's November. ");
                                break;
                            }
                        case 12:
                            {
                                Console.WriteLine("It's Desember. ");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("It's an invalid number. ");
                                break;
                            }
                    }

                }
                else if (cho == "Input")
                {
                    Console.WriteLine("Please enter a number of month in a year [1-12]: ");
                    month = int.Parse(Console.ReadLine());
                    switch (month)
                    {
                        case 1:
                            {
                                Console.WriteLine("It's January. ");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("It's February. ");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("It's March. ");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("It's April. ");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("It's May. ");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("It's June. ");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("It's July. ");
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("It's August. ");
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("It's September. ");
                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine("It's October. ");
                                break;
                            }
                        case 11:
                            {
                                Console.WriteLine("It's November. ");
                                break;
                            }
                        case 12:
                            {
                                Console.WriteLine("It's Desember. ");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("It's an invalid number. ");
                                break;
                            }
                    }

                }
                Console.WriteLine("Do you want to reload the program? [Y/N]: ");
                choice = Console.ReadLine();
                Console.WriteLine();
            } while (choice == "Y");

        }
    }
}