using System.Diagnostics.Metrics;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
       string[] proteins = new string[strand.Length / 3];
       List<string> rna1 = new List<string>();
       int counter = 0;
       
        for(int i = 0; i < strand.Length; i += 3)
        {
            rna1.Add(strand.Substring(i, 3));
        }

        foreach(string s in rna1)
        {
            if(s == "AUG")
            {
                proteins[counter++] = "Methionine";
            }
            else if(s == "UUU" || s == "UUC")
            {
                proteins[counter++] = "Phenylalanine";
            }
            else if(s == "UUA" || s == "UUG")
            {
                proteins[counter++] = "Leucine";
            }
            else if(s == "UCU" || s == "UCC" || s == "UCA" || s == "UCG")
            {
                proteins[counter++] = "Serine";
            }
            else if(s == "UAU" || s == "UAC")
            {
                proteins[counter++] = "Tyrosine";
            }
            else if(s == "UGU" || s == "UGC")
            {
                proteins[counter++] = "Cysteine";
            }
            else if(s == "UGG")
            {
                proteins[counter++] = "Tryptophan";
            }
            else if(s == "UAA"|| s == "UAG" || s == "UGA")
            {
                break;
            }            
            
        }

        Array.Resize(ref proteins, counter);
        return proteins;

    }

    public static void Main(string[] args)
    {
        string[] test = Proteins("AUG");
        Console.WriteLine();
        foreach(string t in test)
        {
            Console.WriteLine(t);
        }
    }
}