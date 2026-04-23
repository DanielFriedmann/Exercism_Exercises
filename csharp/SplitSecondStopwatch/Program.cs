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
    private readonly List<TimeSpan> laps = new();

    public StopwatchState State => state;

    public TimeSpan CurrentLap
    {
        get
        {
            if (state == StopwatchState.Running)
            {
                return time.GetUtcNow().DateTime - lapStartTime;
            }

            return TimeSpan.Zero;
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
        var now = time.GetUtcNow().DateTime;

        if (state == StopwatchState.Ready)
        {
            startTime = now;
            lapStartTime = now;
            elapsed = TimeSpan.Zero;
            state = StopwatchState.Running;
        }
        else if (state == StopwatchState.Stopped)
        {
            startTime = now;
            lapStartTime = now;
            state = StopwatchState.Running;
        }

        else throw new InvalidOperationException("");
    }

    public void Stop()
    {
        if (state == StopwatchState.Running)
        {
            var now = time.GetUtcNow().DateTime;
            elapsed += now - startTime;
            state = StopwatchState.Stopped;
        }

        else throw new InvalidOperationException("");
    }

    public void Reset()
    {
        if (state == StopwatchState.Stopped)
        {
            elapsed = TimeSpan.Zero;
            laps.Clear();
            state = StopwatchState.Ready;
        }

        else throw new InvalidOperationException("");
    }

    public void Lap()
    {
        if (state == StopwatchState.Running)
        {
            var now = time.GetUtcNow().DateTime;
            laps.Add(now - lapStartTime);
            lapStartTime = now;
        }

        else throw new InvalidOperationException("");
    }
}