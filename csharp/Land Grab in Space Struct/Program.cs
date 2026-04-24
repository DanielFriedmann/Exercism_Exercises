public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Plot(Coord topLeft, Coord topRight, Coord bottomLeft, Coord bottomRight)
    {
        TopLeft = topLeft;
        TopRight = topRight;
        BottomLeft = bottomLeft;
        BottomRight = bottomRight;
    }

    public Coord TopLeft { get; }
    public Coord TopRight { get; }
    public Coord BottomLeft { get; }
    public Coord BottomRight { get; }
}


public class ClaimsHandler
{
    public List<Plot> claims = new List<Plot>();
    public void StakeClaim(Plot plot)
    {
        if (!IsClaimStaked(plot)) claims.Add(plot);
        else throw new Exception("");
    }

    public bool IsClaimStaked(Plot plot) => claims.Contains(plot);

    public bool IsLastClaim(Plot plot) => claims.Count > 0 && claims[^1].Equals(plot);

    public Plot GetClaimWithLongestSide()
    {
        if (claims.Count == 0)
            throw new InvalidOperationException();

        Plot bestPlot = claims[0];
        double bestLength = LongestSide(bestPlot);

        foreach (var plot in claims)
        {
            double length = LongestSide(plot);

            if (length > bestLength)
            {
                bestLength = length;
                bestPlot = plot;
            }
        }

        return bestPlot;
    }

    private static double Distance(Coord a, Coord b)
    {
        int dx = a.X - b.X;
        int dy = a.Y - b.Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    private static double LongestSide(Plot plot)
    {
        return Math.Max(
            Math.Max(Distance(plot.TopLeft, plot.TopRight),
                     Distance(plot.TopRight, plot.BottomRight)),
            Math.Max(Distance(plot.BottomRight, plot.BottomLeft),
                     Distance(plot.BottomLeft, plot.TopLeft))
        );
    }
}
