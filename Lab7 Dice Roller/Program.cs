//Welcome to the Grand Circus Casino!
//How many sides should each die have?  {6}

//Roll 1:
//You rolled a 2 and a 5 (7 total)
//Win!

//Roll again? (y/n): { y}
//Roll 2:
//You rolled a 6 and a 6 (12 total)
//Boxcars
//Craps!

//Roll again? (y/n): { y}
//Roll 2:
//You rolled a 3 and a 5 (8 total)

//Roll again? (y/n): { n}
//Thanks for playing!!

Console.WriteLine("Welcome to the Dice Roller.");
Console.WriteLine("This tool rolls two dice at a time.");
Console.WriteLine();
Console.Write("How many sides should each die have? Choose a number: ");

//Validate input - only ints
int userChoice = 0;
while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > int.MaxValue)
{
    Console.WriteLine("That input was not valid. Please try again.");
}

//Main method
static int GetRandom(int userChoice)
{
    Random r = new Random();
    return r.Next(1, userChoice + 1);
}

int turnCounter = 1;
bool playing = true;
while (playing)
{
    int dice1 = GetRandom(userChoice);
    int dice2 = GetRandom(userChoice);
    int diceTotal = dice1 + dice2;
    
    Console.WriteLine();
    Console.WriteLine("ROLL " + turnCounter++ + ":");
    Console.WriteLine($"You rolled a {dice1} and a {dice2} ({diceTotal} total).");
    Console.Write(ReturnCoolRolls(userChoice, dice1, dice2));
    Console.Write(ReturnCoolTotals(userChoice, diceTotal));
    Console.WriteLine(ReturnDnDRolls(userChoice, dice1, dice2));

    while (true)
    {
        Console.WriteLine("  ");
        Console.WriteLine("Roll again? y/n");
        string userContinue = Console.ReadLine().ToLower();
        if (userContinue == "y")
        {
            playing = true;
            break;
        }
        else if (userContinue == "n")
        {
            playing = false;
            break;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. Please answer y/n.");
        }
    }
    
}
Console.WriteLine();
Console.WriteLine("Thank you for using our tool. Goodbye.");

//Method for exciting outcomes

static string ReturnCoolRolls (int userChoice, int dice1, int dice2)
{
    if (userChoice != 6)
    {
        return "";
    }
    else if (dice1 == 1 && dice2 == 1)
    {
        return "Snake eyes! ";
    }
    else if (dice1 == 1 && dice2 == 2)
    {
        return "Ace Deuce! ";
    }
    else if (dice1 == 2 && dice2 == 1)
    {
        return "Ace Deuce! ";
    }
    else if (dice1 == 6 && dice2 == 6)
    {
        return "Box cars! ";
    }
    else
    {
        return "";
    }
   
}

static string ReturnCoolTotals(int userChoice, int diceTotal)
{
    if (userChoice != 6)
    {
        return "";
    }
    else if (diceTotal == 7 || diceTotal == 11)
    {
        return "Win! ";
    }
    else if (diceTotal == 2 || diceTotal == 3 || diceTotal == 12)
    {
        return "Craps! ";
    }
    else
    {
        return "";
    }
}

static string ReturnDnDRolls(int userChoice, int dice1, int dice2)
{
    if (userChoice != 20)
    {
        return "";
    }
    else if (dice1 == 20 && dice2 == 20)
    {
        return "Critical hit! ";
    }
    else if (dice1 == 1 && dice2 == 1)
    {
        return "Critical fail! ";
    }
    else
    {
        return "";
    }

}