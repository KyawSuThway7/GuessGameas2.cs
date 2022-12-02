using System;

namespace GuessGameas2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = 1;//Guess Game 
                bool plays = true;
                while (plays)
                {
                    Console.WriteLine("Guess game ( 0 to 20)Started!!!");
                    Random randomobj1 = new Random();
                    Console.Write("Guess my number : ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    int hiddenvalue0 = randomobj1.Next(20);                
                    while (input != hiddenvalue0)
                    {
                        if (input - hiddenvalue0 <= -5 && input - hiddenvalue0 >= -19)
                        {
                            Console.WriteLine("Your number is  too far to my number");
                            count++;
                            Console.Write("Guess my number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (input > 20)
                        {
                            Console.WriteLine("Read the game inf idiot :" +
                                "guess number between 0 and 20 ");
                            count++;
                            Console.Write("Guess my number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (input - hiddenvalue0 <= 5 && input - hiddenvalue0 > -5)
                        {
                            Console.WriteLine("No!! Your number is close to my number");
                            count++;
                            Console.Write("Guess my number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (input - hiddenvalue0 > 5 && input - hiddenvalue0 <= 19)
                        {
                            Console.WriteLine(" No!! Your number is too far to my number");
                            count++;
                            Console.Write("Guess my number : ");
                            input = Convert.ToInt32(Console.ReadLine());
                        }
                    }//second while
                    Console.WriteLine($"Wow!!! You got it right at \"{count}\"rd ");
                    count++;
                    Console.WriteLine("Wanna play again (y/n)");
                    string inputs = Console.ReadLine();
                    if (inputs == "y" || inputs == "n")
                    {

                        if (inputs == "y")
                        {
                            plays = true;
                            count = 1;
                        }
                        else if (inputs == "n")
                        {
                            plays = false;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Your input must be (y/n) ");
                    }
                }//while
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Error!!! Your input must be number");
            }
            catch (Exception e2)
            {
                Console.WriteLine("Error !!! Your input must be (y/n)");
            }

            Console.WriteLine();
            Console.WriteLine("Thank for using my app");
            Console.WriteLine();
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
    }
}
