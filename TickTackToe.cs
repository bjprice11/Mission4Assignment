namespace Mission4Assignment;

public class TickTackToe
{
    //create an array of 9 positions with a space to display the board dynamically
    private string[] board = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
    
    //update the array depending on what the player chose
    public bool UpdateBoard(int position, int player)
    {
        if (player == 1)
                board[position] = "X";
        else
        {
            board[position] = "O";
        }
        
        //call the print board and check winner methods
        PrintBoard(board);
        return CheckWinner(board);
    }

    //print the board based off array position
    public void PrintBoard(string[] board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    //check if the current player won
    public bool CheckWinner(string[] board)
    {
        //set winner to false until a winner is declared
        bool winner = false;
        
        //hroizontal winning positions
        if ((board[0] != " " && board[0] == board[1] && board[1] == board[2]) ||
            (board[3] != " " && board[3] == board[4] && board[4] == board[5]) ||
            (board[6] != " " && board[6] == board[7] && board[7] == board[8]))
        {
            winner = true;
        };

        // vertical winning positions
        if ((board[0] != " " && board[0] == board[3] && board[3] == board[6]) ||
            (board[1] != " " && board[1] == board[4] && board[4] == board[7]) ||
            (board[2] != " " && board[2] == board[5] && board[5] == board[8]))
        {
            winner = true;
        }

        // diagonal winner positions
        if ((board[0] != " " && board[0] == board[4] && board[4] == board[8]) ||
            (board[2] != " " && board[2] == board[4] && board[4] == board[6]))
        {
            winner = true;
        }
        //return bool
        return winner;
    }
}