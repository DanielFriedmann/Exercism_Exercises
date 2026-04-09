public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException("Strands must be same Length");

        int distance = 0;
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i]) distance++;
        }
        return distance;

        /* LINQ methode:

        return firstStrand
            .Zip(secondStrand, (a,b) => a != b)
            .Count(x => x);
        */

    }
}