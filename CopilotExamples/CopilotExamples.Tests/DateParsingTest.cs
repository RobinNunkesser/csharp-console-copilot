using CopilotExamples;
using JetBrains.Annotations;

namespace CopilotExamples.Tests;

[TestClass]
[TestSubject(typeof(DateParsing))]
public class DateParsingTest
{
    
    [TestMethod]
    public void FindDates_WithFormattedDates_ReturnsAllDates()
    {
        // Arrange
        string input = "Dates: 05/02/24, 05/02/2024, 5/2/24, 5/2/2024, 05-02-24, 05-02-2024, 5-2-24, 5-2-2024";
        string[] expected = { "05/02/24", "05/02/2024", "5/2/24", "5/2/2024", "05-02-24", "05-02-2024", "5-2-24", "5-2-2024" };
        
        // Act
        string[] result = DateParsing.FindDates(input);
        
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void FindDates_WithIndividualDateFormats_ReturnsCorrectFormat()
    {
        // Test each format individually
        Assert.AreEqual(new[] { "05/02/24" }, DateParsing.FindDates("Date: 05/02/24"));
        Assert.AreEqual(new[] { "05/02/2024" }, DateParsing.FindDates("Date: 05/02/2024"));
        Assert.AreEqual(new[] { "5/2/24" }, DateParsing.FindDates("Date: 5/2/24"));
        Assert.AreEqual(new[] { "5/2/2024" }, DateParsing.FindDates("Date: 5/2/2024"));
        Assert.AreEqual(new[] { "05-02-24" }, DateParsing.FindDates("Date: 05-02-24"));
        Assert.AreEqual(new[] { "05-02-2024" }, DateParsing.FindDates("Date: 05-02-2024"));
        Assert.AreEqual(new[] { "5-2-24" }, DateParsing.FindDates("Date: 5-2-24"));
        Assert.AreEqual(new[] { "5-2-2024" }, DateParsing.FindDates("Date: 5-2-2024"));
    }
    
    [TestMethod]
    public void FindDates_WithMixedContent_ReturnsOnlyDates()
    {
        // Arrange
        string input = "Today is 05/02/2024 and tomorrow will be 05/03/2024. Next week: 05-10-24";
        string[] expected = { "05/02/2024", "05/03/2024", "05-10-24" };
        
        // Act
        string[] result = DateParsing.FindDates(input);
        
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void FindDates_WithNoDateContent_ReturnsEmptyArray()
    {
        // Arrange
        string input = "This string contains no dates at all.";
        
        // Act
        string[] result = DateParsing.FindDates(input);
        
        // Assert
        Assert.AreEqual(0, result.Length);
    }



}