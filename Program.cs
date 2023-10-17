namespace DiceRoller
{
    internal class Program
    {
        static void Main(string[]args)
        {
            string playAgain = "Yes";

            while (playAgain.ToLower() == "Yes")
            {
                int userInputInt;

                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine("enter the number of sides for a pair of dice");
                string userInputString = Console.ReadLine();

                bool validInput = int.TryParse(userInputString, out userInputInt);

                Console.WriteLine("Roll The Dice!");

                Random randomObj = new Random();

                int roll1 = randomObj.Next(1, 7);
                int roll2 = randomObj.Next(1, 7);


                while (!validInput || userInputInt < 1 || userInputInt > 6)
                {
                    Console.WriteLine("Please enter a valid number between 1 and 6");
                    userInputString = Console.ReadLine();
                    validInput = int.TryParse(userInputString, out userInputInt);
                }



                switch (roll1 + roll2)
                {
                    case 2:
                        Console.WriteLine("Snake Eyes: You rolled Two 1s");
                        Console.WriteLine("You rolled a crap of 2!");
                        break;
                    case 3:
                        Console.WriteLine("Ace Deuce: You rolled a 1 and 2");
                        Console.WriteLine("You rolled a crap of 3!");
                        break;
                    case 12:
                        Console.WriteLine("Box Cars: You rolled Two 6s");
                        Console.WriteLine("You rolled a crap of 12!");
                        break;
                    case 7:
                    case 11:
                        Console.WriteLine("Win: You rolled a total of 7 or 11");
                        break;
                    default:
                        Console.WriteLine("Sory No Match");
                        break;
                }

                Console.WriteLine("Do you want to roll the dice again? Yes/No");
                playAgain = Console.ReadLine();
            }
        }
    }
}
