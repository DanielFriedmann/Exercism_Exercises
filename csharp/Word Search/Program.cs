public class WordSearch
{
    private char[][] board;
    public WordSearch(string grid)
    {
        string[] rows = grid.Split("\n");

        board = rows
                        .Select(row => row.ToCharArray())
                        .ToArray();
    }

    public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
    {
        var result = new Dictionary<string, ((int, int), (int, int))?>();

        foreach (string word in wordsToSearchFor)
        {
            ((int, int), (int, int))? found;

            found = SearchDown(word)
                 ?? SearchUp(word)
                 ?? SearchRight(word)
                 ?? SearchLeft(word)
                 ?? SearchDiagonal(word, 1, 1)
                 ?? SearchDiagonal(word, 1, -1)
                 ?? SearchDiagonal(word, -1, 1)
                 ?? SearchDiagonal(word, -1, -1);

            result[word] = found;
        }

        return result;


    }

    private ((int, int), (int, int))? SearchDown(string word)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] != word[0]) continue;

                if (row + word.Length > board.Length) continue;

                bool matches = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (board[row + i][col] != word[i])
                    {
                        matches = false;
                        break;
                    }
                }

                if (matches)
                {
                    return (
                        (col + 1, row + 1),
                        (col + 1, row + word.Length)
                            );
                }
            }
        }

        return null;
    }

    private ((int, int), (int, int))? SearchUp(string word)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] != word[0]) continue;

                if (row - word.Length + 1 < 0) continue;

                bool matches = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (board[row - i][col] != word[i])
                    {
                        matches = false;
                        break;
                    }
                }

                if (matches)
                {
                    return (
                        (col + 1, row + 1),
                        (col + 1, row - word.Length + 2)
                            );
                }
            }
        }

        return null;
    }

    private ((int, int), (int, int))? SearchRight(string word)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] != word[0]) continue;

                if (col + word.Length > board[row].Length) continue;

                bool matches = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (board[row][col + i] != word[i])
                    {
                        matches = false;
                        break;
                    }
                }

                if (matches)
                {
                    return (
                             (col + 1, row + 1),
                             (col + word.Length, row + 1)
                            );
                }
            }
        }

        return null;
    }

    private ((int, int), (int, int))? SearchLeft(string word)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] != word[0]) continue;

                if (col - word.Length + 1 < 0) continue;

                bool matches = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (board[row][col - i] != word[i])
                    {
                        matches = false;
                        break;
                    }
                }

                if (matches)
                {
                    return (
                            (col + 1, row + 1),
                            (col - word.Length + 2, row + 1)
                            );
                }
            }
        }

        return null;
    }

    private ((int, int), (int, int))? SearchDiagonal(string word, int rowStep, int colStep)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[row].Length; col++)
            {
                if (board[row][col] != word[0]) continue;

                int endRow = row + rowStep * (word.Length - 1);
                int endCol = col + colStep * (word.Length - 1);

                // Boundary check
                if (endRow < 0 || endRow >= board.Length ||
                    endCol < 0 || endCol >= board[row].Length)
                {
                    continue;
                }

                bool matches = true;

                for (int i = 1; i < word.Length; i++)
                {
                    int newRow = row + i * rowStep;
                    int newCol = col + i * colStep;

                    if (board[newRow][newCol] != word[i])
                    {
                        matches = false;
                        break;
                    }
                }

                if (matches)
                {
                    return (
                            (col + 1, row + 1),
                            (endCol + 1, endRow + 1)
                            );
                }
            }
        }

        return null;
    }
}