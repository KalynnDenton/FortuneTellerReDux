using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1reduxforpush
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstName = string.Empty; //I used string.Empty to make sure the varible was ready to accept a value.
            string userLastName = string.Empty;
            string userAge = string.Empty;
            int userAgeInt = 0;
            string birthMonth;
            int birthMonthInt = 0;
            string royGbiv = string.Empty;
            string siblingNumber = string.Empty;
            int siblingNumberInt = 0;
            string modeofTransport = string.Empty;
            string moneyInBank = string.Empty;
            string retireYears = string.Empty;
            string retireLocation = string.Empty;
            string userQuit = string.Empty; //This is a variable for quitting the programs

            string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            //Here I decided to declare my variables first. Including the array I'll be using to list the RoyGBiv colors! :3

            // Now I'll set the actual values in each of the variables. Also I'll begin interacting with the user!
            //I set up the code for quitting the program as a do while loop. So if a input varible is ever equal to quit. The loop breaks. 
            //I know this isn't best practice. But I'm still learning >w<;

            do
            {
                Console.WriteLine("Hello!! This is the Fortune teller! I can tell your fortune with a \"surprising\" amount of accuracy!\nTo start! May I have your first name?");
                userFirstName = Console.ReadLine().ToLower();
                if (userFirstName == "quit")//Did they say quit? 
                {
                    userQuit = userFirstName;
                    break; // If they did, break the loop and head to the end of the program.
                }

                Console.WriteLine("Thank you! Last name please?");
                userLastName = Console.ReadLine();
                if (userLastName == "quit") //Same as above.
                {
                    userQuit = userLastName;
                    break;
                }


                Console.WriteLine("Thank you! Now I'd like to ask you a series of questions! I promise these questions have nothing to do with your fortune!!\nBelieve me!* \nHow old are you, " + userFirstName + "?");

                userAge = Console.ReadLine().ToLower();

                if (userAge == "quit")
                {
                    userQuit = userAge;
                    break;
                }
                userAgeInt = int.Parse(userAge); // In order to get the result. It must be an int. So I took userAge and parsed it to make userAgeInt. I did this for a few variables below.

                Console.WriteLine("And the month you were born? Please write this as a two digit number!!");
                birthMonth = Console.ReadLine().ToLower();

                if (birthMonth == "quit")
                {
                    userQuit = birthMonth;
                    break;
                }

                birthMonthInt = int.Parse(birthMonth); //Same as above

                Console.WriteLine("Now, may I have your favorite ROYGBIV color?\n If you don't know what or who ROYGBIV is, please enter \"Help\"");
                royGbiv = Console.ReadLine().ToLower();
                if (royGbiv == "quit")
                {
                    userQuit = royGbiv;
                    break;
                }

                while (royGbiv == "help")
                {

                    foreach (string color in colors) // This list the colors in the array I created above. 
                    {
                        Console.WriteLine(color);
                    }

                    Console.WriteLine("Now that you know what RoyGBiv is, Please tell me your favorite color?");
                    royGbiv = Console.ReadLine().ToLower();//Then asks the question again to get the color needed.
                }

                Console.WriteLine("Thank you! Now, how many siblings do you have?");
                siblingNumber = Console.ReadLine().ToLower();
                if (siblingNumber == "quit")
                {
                    userQuit = siblingNumber;
                    break;
                }
                siblingNumberInt = int.Parse(siblingNumber);

                Console.WriteLine("Thank you!! Now I'll read your fortune!!!");
                Console.WriteLine("Please press enter for your fortune!");
                Console.ReadKey();
                Console.Clear();//To keep the Console clean. Mainly for aestheic purposes.

                //Now I'll start the calculations needed for the final output!

                if (userAgeInt % 3 == 0) // For odd number
                {
                    retireYears = "20 years";
                }
                else if (userAgeInt % 2 == 0) // For even number
                {
                    retireYears = "5 years";
                }
                else
                {
                    Console.WriteLine("Not sure if you're good at following directions...");
                    retireYears = " will never retire ";
                } //Not sure how someone would get this result. But it's there as a fall back. I'd rather use a default.

                if (siblingNumberInt < 0) //Less than 0. How would that even work?
                {
                    Console.WriteLine("You probably shouldn't lie to the fortune teller... ");
                    retireLocation = " behind Joe's chicken shack.";// Dannnngggg... 
                }
                else if (siblingNumberInt == 0) //If you have 0 siblings. Only child status!!
                {
                    retireLocation = " Paris, France ";
                }
                else if (siblingNumberInt == 1)// 1 sibling
                {
                    retireLocation = "Cleveland, Ohio, USA";
                }
                else if (siblingNumberInt == 2) // 2 Siblings
                {
                    retireLocation = "Tokyo, Japan";
                }
                else if (siblingNumberInt >= 3) // More than 3 siblings! Just like me!
                {
                    retireLocation = "Honolulu, Hawaii";
                }

                switch (royGbiv) //I love switch statements too much. 
                {
                    case "red":
                        modeofTransport = "a red car";
                        break;
                    case "orange":
                        modeofTransport = "a orange train";
                        break;
                    case "yellow":
                        modeofTransport = " a yellow private jet";
                        break;
                    case "green":
                        modeofTransport = "a little green wagon";
                        break;
                    case "blue":
                        modeofTransport = "a pair of blue skates ";
                        break;
                    case "indigo":
                        modeofTransport = "an indigo colored bicycle";
                        break;
                    case "violet":
                        modeofTransport = "a violet colored chocobo";
                        break;
                }
                if (birthMonthInt >= 1 && birthMonthInt <= 4) //If birthMonthInt is more or equal to 1 and less than or equal to 4
                {
                    moneyInBank = "$10,0000.00";
                }
                else if (birthMonthInt >= 5 && birthMonthInt <= 8) //If more than or equal to 5 and less than or equal to 8
                {
                    moneyInBank = "$20,000.00";
                }
                else if (birthMonthInt >= 9 && birthMonthInt <= 12) //In between 9 and 12.
                {
                    moneyInBank = "$3,000.00";
                }
                else //If anything else.
                {
                    moneyInBank = "$0.00"; //Danngggggg
                }

                //Output!

                Console.WriteLine(userFirstName + " " + userLastName + ": \nwill retire in " + retireYears + " with " + moneyInBank + ", a vacation home in " + retireLocation + " \nand getting around with " + modeofTransport);
                Console.WriteLine("Thank you for playing!!");
                Console.WriteLine("Press enter to exit the application");


            } while (userQuit != "quit"); //If userQuit is not equal to "quit" then the loop continues with no break.

            if (userQuit == "quit") //If it is. This ends the program.
            {
                Console.WriteLine("Aww! Nobody likes a quitter!!! ");
                Console.ReadKey();
            }

        }
    }
}
