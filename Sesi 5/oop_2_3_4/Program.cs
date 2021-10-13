using System;

namespace oop_2_3_4
{
    class Program
    {
        public double num1, num2;
        public string option;
        public void num(double Num1, double Num2)
        {
            num1 = Num1;
            num2 = Num2;
        }

        public virtual void calculation() //override is same method name but has different method.
        {
            if (option == "*")
            {
                Console.WriteLine("{0} * {1} = {2}", this.num1, this.num2, this.num1 * this.num2);
            }
            else if (option == "/")
            {
                Console.WriteLine("{0} / {1} = {2}", this.num1, this.num2, this.num1 / this.num2);
            }
            else if (option == "+")
            {
                Console.WriteLine("{0} + {1} = {2}", this.num1, this.num2, this.num1 + this.num2);
            }
            else if (option == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", this.num1, this.num2, this.num1 - this.num2);
            }
            else
            {
                Console.WriteLine("Invalid input. ");
            }
        }

    }

    class ChildProgram : Program //child
    {
        public override void calculation()//override is same method name but has different method.
        {
            if (option == "%")
            {
                Console.WriteLine("{0} % {1} = {2}", this.num1, this.num2, this.num1 % this.num2);
            }
            else
            {
                Console.WriteLine("Your choice is in the previous option. ");
            }
        }

        static void Main(string[] args)
        {
            int choice;
            string again;
            do
            {
                Console.WriteLine($"Please choose a menu from down below [1-5]: ");
                Console.WriteLine("============================================");
                Console.WriteLine("1. Jet Plane");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Number");
                Console.WriteLine("4. About Developer");
                Console.WriteLine("5. Exit");
                Console.WriteLine("============================================");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        {
                            Plane plane = new Plane();
                            Jet jet = new Jet();

                            Console.WriteLine("What is the plane name?: ");
                            plane.plane_kind = Console.ReadLine();
                            Console.WriteLine("Where is the plane at now?: ");
                            plane.height = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            plane.fly();
                            plane.hasTakenOff();

                            Console.WriteLine("What is the jet name?: ");
                            jet.plane_kind = Console.ReadLine();
                            Console.WriteLine("What is the color of the jet?: ");
                            jet.color = Console.ReadLine();
                            Console.WriteLine("Where is the jet at now?: ");
                            jet.height = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            jet.flying();
                            break;
                        }
                    case 2:
                        {
                            Overloading ovrld = new Overloading();

                            Console.WriteLine("What is your name?: ");
                            ovrld.name = Console.ReadLine();
                            Console.WriteLine("What is your phone number?: ");
                            ovrld.mobilenum = double.Parse(Console.ReadLine());

                            ovrld.print(ovrld.name);
                            ovrld.print(ovrld.mobilenum);
                            break;
                        }
                    case 3:
                        {
                            Program number = new Program();
                            Console.WriteLine("Input the first number: ");
                            number.num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input the second number: ");
                            number.num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("This is an example of overriding: ");
                            Console.WriteLine("Choose an option [+, -, *, /]: ");
                            number.option = Console.ReadLine();
                            number.calculation();
                            Program newNumber = new ChildProgram(); //overriding
                            Console.WriteLine("Input the first number: ");
                            newNumber.num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input the second number: ");
                            newNumber.num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("This is an example of overriding: ");
                            Console.WriteLine("Choose another option [%]: ");
                            newNumber.option = Console.ReadLine();
                            newNumber.calculation();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Hi, my name is Etasa Karenisa.");
                            Console.WriteLine($"I'm {DateTime.Now.Year - 2000} years old now.");
                            Console.WriteLine("I live in Sidoarjo.");
                            Console.WriteLine("I have always been using Dart, now I'm learning C#. I personally think C# is one of the most entertaining and interesting programming language that I've ever learned.");
                            break;
                        }
                    case 5:
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
