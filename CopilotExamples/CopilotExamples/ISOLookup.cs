namespace CopilotExamples;

public class ISOLookup
{
    public static readonly ISOCountry[] Countries = new[]
    {
        new ISOCountry { Code = "US", Country = "United States" },
        new ISOCountry { Code = "CA", Country = "Canada" },
        new ISOCountry { Code = "GB", Country = "United Kingdom" }
        // Add more countries as needed
    };
}

public class ISOCountry
{
    public string Code { get; set; }
    public string Country { get; set; }
}