public class Matrix
{
    public int[][] Grid;

    public Matrix(string input)
    {
        Grid = input.Split('\n')
                    .Select(zeile => zeile.Split(' ').Select(int.Parse).ToArray())                    
                    .ToArray();
    }

    public int[] Row(int row)
    {        
        if(row > Grid.Length || row <= 0) throw new ArgumentException("");

        return Grid[row - 1];
    }

    public int[] Column(int col)
    {
        if(col > Grid[0].Length || col <= 0) throw new ArgumentException("");

        return Grid.Select(zeile => zeile[col - 1])
                   .ToArray();
    }
}