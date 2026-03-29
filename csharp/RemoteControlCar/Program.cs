class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven;
    private int batteryStatus;

    public RemoteControlCar(int speed, int batteryDrain, int distanceDriven = 0, int batteryStatus = 100)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distanceDriven = distanceDriven;
        this.batteryStatus = batteryStatus;
    }

    public bool BatteryDrained()
    {
        if (batteryStatus - batteryDrain >= 0) return false;
        else return true;
    }

    public int DistanceDriven() => distanceDriven;   

    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            batteryStatus -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained() && car.DistanceDriven() < distance)
        {
            car.Drive();
            if(car.DistanceDriven() >= distance) return true;
        }

        return false;
    }

}
