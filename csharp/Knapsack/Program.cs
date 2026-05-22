public static class Knapsack
{
    public static int MaximumValue(int maximumWeight, (int weight, int value)[] items)
    {
        return Solve(0, maximumWeight, items);
    }

    private static int Solve(int index, int remainingWeight, (int weight, int value)[] items)
    {
        if (index == items.Length) return 0;

        int without = Solve(index + 1, remainingWeight, items);

        int with = 0;
        if (items[index].weight <= remainingWeight)
        {
            with = items[index].value + Solve(index + 1, remainingWeight - items[index].weight, items);
        }

        return Math.Max(with, without);
    }
}
