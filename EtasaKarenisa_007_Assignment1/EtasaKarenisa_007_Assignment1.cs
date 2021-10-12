using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EtasaKarenisa_007_Assignment1
{
    public class EtasaKarenisa_007_Assignment1
    {
        public static void Main(string[] args)
        {
            string name, again;
            int choice;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
            do
            {
                Console.WriteLine("===== ASSIGNMENT 1 (PROGRAMMING LOGIC / SESI 4) =====");
                Console.WriteLine($"Welcome {name}, please choose a menu from down below [1-7]: ");
                Console.WriteLine("1. Alphabet Pyramid");
                Console.WriteLine("2. Numerical Pyramid");
                Console.WriteLine("3. Factorial");
                Console.WriteLine("4. Reversing Numbers");
                Console.WriteLine("5. Numerical to String");
                Console.WriteLine("6. Palindrome");
                Console.WriteLine("7. About Developer");
                Console.WriteLine("8. Exit");
                Console.WriteLine("============================================");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        {
                            int height, space, alpha;
                            char ch = 'A';
                            Console.WriteLine("Please enter the height of the pyramid [1, 2, ...]: ");
                            height = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            for (int i = 1; i <= height; i++)
                            {
                                for (space = 1; space <= height - i; space++)
                                {
                                    Console.Write(" ");
                                }
                                for (alpha = 1; alpha <= i; alpha++)
                                {
                                    Console.Write(ch++);

                                }
                                ch--;
                                for (alpha = 1; alpha < i; alpha++)
                                {
                                    Console.Write(--ch);
                                }
                                ch = 'A';
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            int height, space, num;
                            Console.WriteLine("Please enter the height of the pyramid [1, 2, ...]: ");
                            height = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            for (int i = 1; i <= height; i++)
                            {
                                for (space = 1; space <= height - i; space++)
                                {
                                    Console.Write(" ");
                                }
                                for (num = 1; num <= i; num++)
                                {
                                    Console.Write(num);
                                }
                                for (num = i - 1; num >= 1; num--)
                                {
                                    Console.Write(num);
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            int num, total = 1;
                            Console.WriteLine("Please enter a number [1, 2, ...]: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (num > 0)
                            {
                                for (int i = num; i > 0; i--)
                                {
                                    total *= i;
                                }
                                Console.Write(num + " = ");
                                for (int i = num; i > 0; i--)
                                {
                                    if (i != 1)
                                    {
                                        Console.Write(i + "*");
                                    }
                                    else if (i == 1)
                                    {
                                        Console.Write(i);
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine($"Factorial of {num} is {total}. ");
                            }
                            else
                            {
                                Console.Write("Not defined. ");
                            }
                            break;
                        }
                    case 4:
                        {
                            string num;
                            Console.WriteLine("Please enter any number [1, 2, ...]: ");
                            num = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Reversed numbers: ");
                            Regex reg = new Regex("^[a-zA-Z ]*$");
                            num = reg.Replace(num, string.Empty);
                            for (int i = num.Length - 1; i >= 0; i--)
                            {
                                Console.Write(num[i]);
                            }
                            break;
                        }
                    case 5:
                        {
                            string num;
                            Console.WriteLine("Please enter any number [1, 2, ...]: ");
                            num = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Spelled: ");
                            Regex reg = new Regex("^[a-zA-Z ]*$");
                            num = reg.Replace(num, string.Empty);
                            for (int i = 0; i < num.Length; i++)
                            {
                                if (num[i] == '0')
                                {
                                    Console.Write("Zero ");
                                }
                                else if (num[i] == '1')
                                {
                                    Console.Write("One ");
                                }
                                else if (num[i] == '2')
                                {
                                    Console.Write("Two ");
                                }
                                else if (num[i] == '3')
                                {
                                    Console.Write("Three ");
                                }
                                else if (num[i] == '4')
                                {
                                    Console.Write("Four ");
                                }
                                else if (num[i] == '5')
                                {
                                    Console.Write("Five ");
                                }
                                else if (num[i] == '6')
                                {
                                    Console.Write("Six ");
                                }
                                else if (num[i] == '7')
                                {
                                    Console.Write("Seven ");
                                }
                                else if (num[i] == '8')
                                {
                                    Console.Write("Eight ");
                                }
                                else if (num[i] == '9')
                                {
                                    Console.Write("Nine ");
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input. ");
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            string str, newStr = "";
                            Console.WriteLine("Please enter any character: ");
                            str = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Reversed character: ");
                            for (int i = str.Length - 1; i >= 0; i--)
                            {
                                Console.Write(str[i]);
                                newStr += str[i];
                            }
                            string check = str == newStr ? " is palindrome." : " is not palindrome.";
                            Console.WriteLine(check);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Name: Etasa Karenisa");
                            Console.WriteLine("Participant Number: FSDO001ONL007");
                            Console.WriteLine("Address: Sidoarjo");
                            Console.WriteLine($"Age: {DateTime.Now.Year - 2000}");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Thank You for Using This Program.");
                            Console.WriteLine("007 - Etasa Karenisa");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input. ");
                            break;
                        }

                }
                Console.WriteLine();
                Console.WriteLine("Do you want to reload the program? [Y/N]: ");
                again = Console.ReadLine().ToUpper();
            } while (again == "Y");
        }
    }
}

