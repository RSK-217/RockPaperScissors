using RockPaperScissors;

int playerWins = 0;
int computerWins = 0;

while (playerWins < 3 && computerWins < 3)
{
    Console.WriteLine($@"
 __________________________
| Player: {playerWins}  | Computer: {computerWins} |
 --------------------------
");

    Console.WriteLine(
        @"What would you like to throw?
1.Rock
2.Paper
3.Scissors");

    string choiceNum = Console.ReadKey().KeyChar.ToString();
    Console.WriteLine();
    int playerChoice = int.Parse(choiceNum);

    Shoot match = new Shoot(playerChoice);

    string winner = match.Result();

    if (winner == "User")
    {
        playerWins++;
    }
    else if (winner == "Computer")
    {
        computerWins++;
    }

    if (playerWins == 3)
    {
        Console.WriteLine("YOU WON THE GAME!");
    } else if (computerWins == 3)
    {
        Console.WriteLine("you lost the game :(");
    }

    Console.ReadLine();
    Console.Clear();
}

Console.ReadLine();