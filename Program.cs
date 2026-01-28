
using Mission4Assignment;

TickTackToe tt = new TickTackToe();

Console.WriteLine("Welcome to the TickTacToe Game");
List<int> userChoices = new List<int>();
bool winner = false;
int playerOne = 1;
int playerTwo = 2;

do
{
    bool validMove = false;
    int playerOneChoice = -1;
    while (!validMove)
    {
        
        Console.WriteLine("Player One: Which position would you like to play? 1-9");
        playerOneChoice = (Convert.ToInt32(Console.ReadLine()) - 1);
        if (userChoices.Contains(playerOneChoice))
        {
            Console.WriteLine("That position is already taken, Choose again!");
        }
        else
        {
            userChoices.Add(playerOneChoice);
            validMove = true;
        }
    }
    if (tt.UpdateBoard(playerOneChoice, playerOne))
    {
        Console.WriteLine("Player One Wins!");
        winner = true;
        break; // Break the main game loop
    }
    
    validMove = false;
    int playerTwoChoice = -1;
    while (!validMove)
    {
        Console.WriteLine("Player Two: Which position would you like to play? 1-9");
        playerTwoChoice = (Convert.ToInt32(Console.ReadLine()) - 1);
        if (userChoices.Contains(playerTwoChoice))
        {
            Console.WriteLine("That position is already taken, Choose again!");
        }
        else
        {
            userChoices.Add(playerTwoChoice);
            validMove = true;
        }
    }
    if (tt.UpdateBoard(playerTwoChoice, playerTwo))
    {
        Console.WriteLine("Player Two Wins!");
        winner = true;
        break; // Break the main game loop
    }
    

}while (!winner);
Console.WriteLine("Thanks for playing!");
