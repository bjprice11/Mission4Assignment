
using Mission4Assignment;

TickTackToe tt = new TickTackToe();

//Begins the program with a welcome and sets the initial variables
Console.WriteLine("Welcome to the TickTacToe Game");
List<int> userChoices = new List<int>();
bool winner = false;
int playerOne = 1;
int playerTwo = 2;

//Does this loop while the winner is false
do
{
    //Validation for repeated numbers 
    bool validMove = false;
    int playerOneChoice = -1;
    while (!validMove)
    {
        //Allows the user to pick their position
        Console.WriteLine("Player One: Which position would you like to play? 1-9");
        //turns it to an int
        playerOneChoice = (Convert.ToInt32(Console.ReadLine()) - 1);
        // if the position is already taken it resets you
        if (userChoices.Contains(playerOneChoice))
        {
            Console.WriteLine("That position is already taken, Choose again!");
        }
        else
        {
            //adds that guess to the list of guesses
            userChoices.Add(playerOneChoice);
            validMove = true;
        }
    }
    
    //Passes the players choice and the player to the method, getting a boolean back
    if (tt.UpdateBoard(playerOneChoice, playerOne))
    {
        Console.WriteLine("Player One Wins!");
        winner = true;
        break; // Break the main game loop
    }
    
    //resets the valid move to make sure they are picking correct places
    validMove = false;
    int playerTwoChoice = -1;
    while (!validMove)
    {
        //Allows the user to pick their position
        Console.WriteLine("Player Two: Which position would you like to play? 1-9");
        //turns it to an int
        playerTwoChoice = (Convert.ToInt32(Console.ReadLine()) - 1);
        // if the position is already taken it resets you
        if (userChoices.Contains(playerTwoChoice))
        {
            Console.WriteLine("That position is already taken, Choose again!");
        }
        else
        {
            //adds that guess to the list of guesses
            userChoices.Add(playerTwoChoice);
            validMove = true;
        }
    }
    //Passes the players choice and the player to the method, getting a boolean back
    if (tt.UpdateBoard(playerTwoChoice, playerTwo))
    {
        Console.WriteLine("Player Two Wins!");
        winner = true;
        break; // Break the main game loop
    }
    

}while (!winner);
//Thanks the player for playing
Console.WriteLine("Thanks for playing!");
