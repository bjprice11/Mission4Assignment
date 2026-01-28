
using Mission4Assignment;

TickTackToe tt = new TickTackToe();

Console.WriteLine("Welcome to the TickTacToe Game");
List<int> userChoices = new List<int>();
bool winner = false;
string playerOne = "X";
string playerTwo = "O";

do
{
    int playerOneChoice = -1;
    Console.WriteLine("Player One: Which position would you like to play? 1-9");
    playerOneChoice = (Convert.ToInt32(Console.ReadLine())-1);
    if  (userChoices.Contains(playerOneChoice))
    {
        Console.WriteLine("That position is already taken, Choose again!");
    }
    else
    {
        userChoices.Add(playerOneChoice);
    }
    Console.WriteLine(tt.UpdateBoard(playerOneChoice, playerOne));

    if (tt.CheckWinner(playerOne))
    {
        Console.WriteLine("Player One Wins!");
        winner = true;
        break; // Break the main game loop
    }
    
    int playerTwoChoice = -1;
    Console.WriteLine("Player Two: Which position would you like to play? 1-9");
    playerTwoChoice = (Convert.ToInt32(Console.ReadLine())-1);
    
    if  (userChoices.Contains(playerTwoChoice))
    {
        Console.WriteLine("That position is already taken, Choose again!");
    }
    else
    {
        userChoices.Add(playerTwoChoice);
    }
    Console.WriteLine(tt.UpdateBoard(playerTwoChoice, playerTwo));
    
    if (tt.CheckWinner(playerTwo))
    {
        Console.WriteLine("Player Two Wins!");
        winner = true;
        break;
    };
    

}while (!winner);
Console.WriteLine("Thanks for playing!");
