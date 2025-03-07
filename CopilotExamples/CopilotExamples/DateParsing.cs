using System.Text.RegularExpressions;

namespace CopilotExamples;


public class DateParsing
{

    /// <summary>
    /// Finds all dates in a string and returns them in an array.
    /// Supported formats: MM/DD/YY, MM/DD/YYYY, M/D/YY, M/D/YYYY
    /// and equivalent formats with hyphens.
    /// </summary>
    /// <param name="input">String to search for dates</param>
    /// <returns>Array of found date strings</returns>
    public static string[] FindDates(string input)
    {
        // This pattern matches dates in various formats:
        // - MM/DD/YY or MM/DD/YYYY (with leading zeros)
        // - M/D/YY or M/D/YYYY (without leading zeros)
        // - Same formats but with hyphens instead of slashes
        var pattern = @"(\d{1,2})[/-](\d{1,2})[/-](\d{2}|\d{4})";
        
        // Find all matches
        var matches = Regex.Matches(input, pattern);
        
        // Extract matched values into an array
        var dates = new string[matches.Count];
        
        for (var i = 0; i < matches.Count; i++)
        {
            dates[i] = matches[i].Value;
        }
        
        return dates;
    }
}