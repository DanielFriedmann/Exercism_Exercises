using Microsoft.VisualBasic;
using System.Linq;
public static class DialingCodes
{

    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string> { };
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
        {
            { 1, "United States of America"},
            { 55, "Brazil"},
            { 91, "India"}
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> buch = GetEmptyDictionary();
        buch.Add(countryCode, countryName);
        return buch;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode)) return existingDictionary[countryCode];
        else return "";
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }
        else return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }
        else return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        /* string longestCountry = "";

        foreach(KeyValuePair<int,string> p in existingDictionary)
        {
            if(p.Value.Length > longestCountry.Length)
            {
                longestCountry = p.Value;
            }
        }
        
        return longestCountry; */

        string longestCountry = "";

        foreach (string country in existingDictionary.Values)
        {
            if (country.Length > longestCountry.Length)
            {
                longestCountry = country;
            }
        }

        return longestCountry;

        /*
        return existingDictionary.Values
                .OrderByDescending(s => s.Length)
                .FirstOrDefault();

                return existingDictionary.Values
                    .MaxBy(s => s.Length);
        */
    }
}