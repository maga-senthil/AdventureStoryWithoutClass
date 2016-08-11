using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventurestorygame
{
    class Program
    {
        static void Main(string[] args)
        {
            string troll;
            Console.WriteLine("You're walking through the forest, minding your own business, and you run into a troll! Do you FIGHT him, PAY him, or RUN?");
            troll = Console.ReadLine();
            switch (troll)
            {
                case "fight":
                    Console.WriteLine("how courageous!Are you strong(YES or NO) ?");
                    string strong = Console.ReadLine();
                    Console.WriteLine("Are you smart");
                    string smart = Console.ReadLine();
                    if (strong == "yes" || smart == "yes")
                    {
                        Console.WriteLine("You only need one of the two! You beat the troll--nice work!");

                    }
                    else
                    {
                        Console.WriteLine("You're not strong OR smart? Well, if you were smarter, you probably wouldn't have tried to fight a troll. You lose!");

                    }
                    break;
                case "pay":
                    Console.WriteLine("All right, we'll pay the troll. Do you have any money (YES or NO)?");
                    string money = Console.ReadLine();
                    Console.WriteLine("Is your money in Troll Dollars ? ");
                    string dollars = Console.ReadLine();
                    if (money == "yes" && dollars == "yes")
                    {
                        Console.WriteLine("Great! You pay the troll and continue on your merry way.");

                    }
                    else
                    {
                        Console.WriteLine("Dang! This troll only takes Troll Dollars. You get whomped!");

                    }
                    break;
                case "run":
                    Console.WriteLine("Let's book it! Are you fast (YES or NO)?");
                    string fast = Console.ReadLine();
                    Console.WriteLine("Did you get a head start?");
                    string headstart = Console.ReadLine();
                    if (fast == "yes" || headstart == "yes")
                    {
                        Console.WriteLine("You got away--barely! You live to stroll through the forest another day.");
                    }
                    else
                    {
                        Console.WriteLine("You're not fast and you didn't get a head start? You never had a chance! The troll eats you.");

                    }
                    break;
                default:
                    Console.WriteLine("I didn't understand your choice. Hit Run and try again, this time picking FIGHT, PAY, or RUN!");
                    break;

            }

            Console.ReadLine();
        }
    }
}
