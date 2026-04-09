// TODO implement the IRemoteControlCar interface

public interface IRemoteControlCar
{
    public int DistanceTravelled { get; set; }

    void Drive() { }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int CompareTo(ProductionRemoteControlCar other)
    {
        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }
    private int distanceTravelled;
    public int DistanceTravelled
    {
        get => distanceTravelled;
        private set => distanceTravelled = value;
    }

    int IRemoteControlCar.DistanceTravelled
    {
        get => distanceTravelled;
        set => distanceTravelled = value;
    }

    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    private int distanceTravelled;
    public int DistanceTravelled
    {
        get => distanceTravelled;
        private set => distanceTravelled = value;
    }

    int IRemoteControlCar.DistanceTravelled
    {
        get => distanceTravelled;
        set => distanceTravelled = value;
    }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var rankedCars = new List<ProductionRemoteControlCar> { prc1, prc2 };
        rankedCars.Sort();
        return rankedCars;
    }
}
