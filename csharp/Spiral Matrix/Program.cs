public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int counter = 1;

        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = counter++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = counter++;
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = counter++;
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = counter++;
                }
                left++;
            }
        }

        return matrix;
    }
}