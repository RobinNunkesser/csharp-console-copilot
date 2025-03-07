namespace CopilotExamples.Tests;



[TestClass]
public class GreatestCommonDivisorFromUnitTestTests
{
    [TestMethod]
    public void GCD_WithPositiveIntegers_ReturnsCorrectResult()
    {
        // Arrange
        var first = 48;
        var second = 18;
        var expected = 6;
        
        // Act
        var result = GreatestCommonDivisorFromUnitTest.Calculate(first, second);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void GCD_WithCoprimeNumbers_ReturnsOne()
    {
        // Arrange
        var first = 25;
        var second = 36;
        var expected = 1;
        
        // Act
        var result = GreatestCommonDivisorFromUnitTest.Calculate(first, second);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void GCD_WithSameNumbers_ReturnsTheNumber()
    {
        // Arrange
        var number = 42;
        var expected = 42;
        
        // Act
        var result = GreatestCommonDivisorFromUnitTest.Calculate(number, number);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GCD_WithNegativeNumber_ThrowsArgumentException()
    {
        // Act
        GreatestCommonDivisorFromUnitTest.Calculate(-5, 10);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void GCD_WithZero_ThrowsArgumentException()
    {
        // Act
        GreatestCommonDivisorFromUnitTest.Calculate(0, 10);
    }
    
    [TestMethod]
    public void GCD_WithOneAsInput_ReturnsOne()
    {
        // Arrange
        var first = 1;
        var second = 5;
        var expected = 1;
        
        // Act
        var result = GreatestCommonDivisorFromUnitTest.Calculate(first, second);
        
        // Assert
        Assert.AreEqual(expected, result);
    }
}