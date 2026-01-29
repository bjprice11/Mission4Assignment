namespace Mission4Assignment;

public class TickTackToe
{
    //create an array of 9 positions with a space to display the board dynamically
    private string[] board = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
    
    //update the array depending on what the player chose
    public int UpdateBoard(int position, int player)
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
    // if there is a winner, 1
    //if there is a tie, 2
    //if you should continue playing 3
    public int CheckWinner(string[] board)
    {
        //set winner to false until a winner is declared
        int winner = 3;

        if (!board.Contains(" "))
        {
            //hroizontal winning positions
            if ((board[0] != " " && board[0] == board[1] && board[1] == board[2]) ||
                (board[3] != " " && board[3] == board[4] && board[4] == board[5]) ||
                (board[6] != " " && board[6] == board[7] && board[7] == board[8]))
            {
                winner = 1;
            }
            // vertical winning positions
            else if ((board[0] != " " && board[0] == board[3] && board[3] == board[6]) ||
                     (board[1] != " " && board[1] == board[4] && board[4] == board[7]) ||
                     (board[2] != " " && board[2] == board[5] && board[5] == board[8]))
            {
                winner = 1;
            } 
            // diagonal winner positions
            else if ((board[0] != " " && board[0] == board[4] && board[4] == board[8]) ||
                     (board[2] != " " && board[2] == board[4] && board[4] == board[6]))
            {
                winner = 1;
            }
            
            else
            {
                winner = 2;
            }
        }
        
        //return the int
        return winner;
    }
}