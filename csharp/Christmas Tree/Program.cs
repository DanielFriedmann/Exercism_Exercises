using System.Runtime.Serialization.Formatters;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Das ist ein Baum Höhe 4:");
        ChristmasTree.printTree(4, 1);
        Console.WriteLine("Das sind zwei Bäume Höhe 5:");
        ChristmasTree.printTree(5, 2);
        Console.WriteLine("Das sind drei Bäume Höhe 10:");
        ChristmasTree.printTree(10, 3);
    }
}

public static class ChristmasTree
{

    public static void printTree(int height, int trees)
    {
        int maxStars = height * 2 - 1;
        int initialStars = 1;
        int initialVoid = height - 1;

        while (initialStars <= maxStars)
        {
            for (int i = 0; i < trees; i++)
            {
                printVoid(initialVoid);
                printStars(initialStars);
                printVoid(initialVoid);
            }
            initialStars += 2;
            initialVoid -= 1;
            Console.WriteLine();
        }

        for (int j = 0; j < 2; j++)
        {
            for (int i = 0; i < trees; i++)
            {
                printVoid(height - 2);
                printStars(3);
                printVoid(height - 2);
            }
            Console.WriteLine();
        }
    }

    public static void printStars(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write("*");
        }
    }

    public static void printVoid(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write(" ");
        }
    }
}