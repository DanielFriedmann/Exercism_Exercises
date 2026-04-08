class WeighingMachine
{

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
    // TODO: define the 'Precision' property

    public int Precision { get; }

    // TODO: define the 'Weight' property
    private double weight;
    public double Weight
    {
        get => weight;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException();

            weight = value;
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5.0;

    // TODO: define the 'DisplayWeight' property

    public string DisplayWeight
    {
        get
        {
            double result = Weight - TareAdjustment;
            return result.ToString($"F{Precision}") + " kg";
        }
    }
}
