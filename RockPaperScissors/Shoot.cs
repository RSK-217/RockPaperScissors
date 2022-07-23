using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors;

internal class Shoot
{
    static List<string> choiceString = new List<string>() { "", "Rock", "Paper", "Scissors" };

    public string PlayerChoice { get; set; }

    public string ComputerChoice { get; set; }
    
    public Shoot(int playerChoice) //Constructor
    {
        PlayerChoice = choiceString[playerChoice];
        Random random = new Random();
        int computerChoice = random.Next(1, 4);
        ComputerChoice = choiceString[computerChoice];
    }


    internal string MatchResults()
    {
        return $@"{PlayerChoice}
{ComputerChoice}";
    }

    internal string Result() //Method
    {
        if ((PlayerChoice == "Rock" && ComputerChoice == "Scissors") || (PlayerChoice == "Scissors" && ComputerChoice == "Paper") || (PlayerChoice == "Paper" && ComputerChoice == "Rock"))
        {
            Console.WriteLine($"user won with {PlayerChoice} and computer chose {ComputerChoice}");
            return "User";
        }
        else if ((PlayerChoice == ComputerChoice))
        {
            Console.WriteLine($"It's a draw. Both players chose {PlayerChoice}");
            return "";
        }
        Console.WriteLine($"computer won with {ComputerChoice} and user chose {PlayerChoice}");
        return "Computer";


    }
}



//ROCK
//    _______
//---'   ____)
//      (_____)
//      (_____)
//      (____)
//---.__(___)
//";
//    }


//PAPER
//     _______
//---'    ____)____
//           ______)
//          _______)
//         _______)
//---.__________)
//";
//    }


//SCISSORS
//    _______
//---'   ____)____
//          ______)
//       __________)
//      (____)
//---.__(___)
//";
//    }