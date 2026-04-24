public enum StopwatchState
{
    Ready,
    Running,
    Stopped
}

public class SplitSecondStopwatch(TimeProvider time)
{
    private StopwatchState state = StopwatchState.Ready;

    private DateTime startTime;
    private DateTime lapStartTime;

    private TimeSpan elapsed = TimeSpan.Zero;
    private TimeSpan currentLapElapsed = TimeSpan.Zero;

    private readonly List<TimeSpan> laps = new();

    public StopwatchState State => state;

    public TimeSpan CurrentLap
    {
        get
        {
            if (state == StopwatchState.Running)
            {
                return currentLapElapsed + (time.GetUtcNow().DateTime - lapStartTime);
            }

            return currentLapElapsed;
        }
    }

    public TimeSpan Total
    {
        get
        {
            if (state == StopwatchState.Running)
            {
                return elapsed + (time.GetUtcNow().DateTime - startTime);
            }

            return elapsed;
        }
    }

    public IReadOnlyCollection<TimeSpan> PreviousLaps => laps;

    public void Start()
    {
        if (state != StopwatchState.Stopped && state != StopwatchState.Ready) throw new InvalidOperationException("");

        
        var now = time.GetUtcNow().DateTime;

        if (state == StopwatchState.Ready)
        {
            elapsed = TimeSpan.Zero;
            currentLapElapsed = TimeSpan.Zero;
            laps.Clear();
        }

        startTime = now;
        lapStartTime = now;
        state = StopwatchState.Running;


    }

    public void Stop()
    {
        if (state != StopwatchState.Running) throw new InvalidOperationException("");


        var now = time.GetUtcNow().DateTime;

        elapsed += now - startTime;
        currentLapElapsed += now - lapStartTime;

        state = StopwatchState.Stopped;
    }

    public void Reset()
    {
        if (state != StopwatchState.Stopped) throw new InvalidOperationException("");


        elapsed = TimeSpan.Zero;
        currentLapElapsed = TimeSpan.Zero;
        laps.Clear();

        state = StopwatchState.Ready;
    }

    public void Lap()
    {
        if (state != StopwatchState.Running) throw new InvalidOperationException("");


        var now = time.GetUtcNow().DateTime;

        laps.Add(currentLapElapsed + (now - lapStartTime));

        lapStartTime = now;
        currentLapElapsed = TimeSpan.Zero;
    }
}