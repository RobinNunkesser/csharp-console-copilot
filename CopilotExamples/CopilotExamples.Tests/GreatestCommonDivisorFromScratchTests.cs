namespace CopilotExamples.Tests;

[TestClass]
public class GreatestCommonDivisorFromScratchTests
{
    [TestMethod]
    public void GreatestCommonDivisor_WithPositiveIntegers_ReturnsCorrectResult()
    {
        // Arrange
        var first = 48;
        var second = 18;
        var expected = 6;
        
        // Act
        var result = GreatestCommonDivisorFromScratch.MathUtilities.GreatestCommonDivisor(first, second);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void GreatestCommonDivisor_WithCoprimeNumbers_ReturnsOne()
    {
        // Arrange
        var first = 25;
        var second = 36;
        var expected = 1;
        
        // Act
        var result = GreatestCommonDivisorFromScratch.MathUtilities.GreatestCommonDivisor(first, second);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void GreatestCommonDivisor_WithSameNumbers_ReturnsTheNumber()
    {
        // Arrange
        var number = 42;
        var expected = 42;
        
        // Act
        var result = GreatestCommonDivisorFromScratch.MathUtilities.GreatestCommonDivisor(number, number);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GreatestCommonDivisor_WithNegativeNumber_ThrowsArgumentException()
    {
        // Act
        GreatestCommonDivisorFromScratch.MathUtilities.GreatestCommonDivisor(-5, 10);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GreatestCommonDivisor_WithZero_ThrowsArgumentException()
    {
        // Act
        GreatestCommonDivisorFromScratch.MathUtilities.GreatestCommonDivisor(0, 10);
    }
    
    [TestMethod]
    public void GreatestCommonDivisor_WithOneAsInput_ReturnsOne()
    {
        // Arrange
        var first = 1;
        var second = 5;
        var expected = 1;
        
        // Act
        var result = GreatestCommonDivisorFromScratch.MathUtilities.GreatestCommonDivisor(first, second);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}