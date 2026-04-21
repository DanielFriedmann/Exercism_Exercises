public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        return white.Column == black.Column 
        || white.Row == black.Row
        || Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column);        

    }

    public static Queen Create(int row, int column)
    {
        if(row < 0 || row > 7 || column  < 0 || column > 7) 
            throw new ArgumentOutOfRangeException("Queen ist not on chessboard");
        return new Queen(row, column);
    }
}