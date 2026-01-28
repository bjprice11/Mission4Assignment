namespace Mission4Assignment;

public class TickTackToe
{
    private string[] board = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
    
    public bool UpdateBoard(int position, int player)
    {
        if (player == 1)
                board[position] = "X";
        else
        {
            board[position] = "O";
        }
        
        PrintBoard(board);
        return CheckWinner(board);
    }

    public void PrintBoard(string[] board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");

        CheckWinner(board);
    }

    public bool CheckWinner(string[] board)
    {
        bool winner = false;
        
        if ((board[0] != " " && board[0] == board[1] && board[1] == board[2]) ||
            (board[3] != " " && board[3] == board[4] && board[4] == board[5]) ||
            (board[6] != " " && board[6] == board[7] && board[7] == board[8]))
        {
            winner = true;
        };

        // Columns
        if ((board[0] != " " && board[0] == board[3] && board[3] == board[6]) ||
            (board[1] != " " && board[1] == board[4] && board[4] == board[7]) ||
            (board[2] != " " && board[2] == board[5] && board[5] == board[8]))
        {
            winner = true;
        }

        // Diagonals
        if ((board[0] != " " && board[0] == board[4] && board[4] == board[8]) ||
            (board[2] != " " && board[2] == board[4] && board[4] == board[6]))
        {
            winner = true;
        }

        else
        {
            winner = false;
        }

        return winner;
    }
}