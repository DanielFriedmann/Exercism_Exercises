public static class RnaTranscription
{

    /* Given a DNA strand, its transcribed RNA strand is formed by replacing each nucleotide with its complement:

        G -> C
        C -> G
        T -> A
        A -> U
    */

    public static string ToRna(string strand)
    {
        string result = "";

        foreach (char c in strand)
        {
            switch (c)
            {
                case 'G': result += "C"; break;
                case 'C': result += "G"; break;
                case 'T': result += "A"; break;
                case 'A': result += "U"; break;
                default: throw new ArgumentException("");
            }
        }
        return result;
    }
}