//https://osherove.com/tdd-kata-1

namespace StringCalculator.Test;
public class Part1Tests
{
    [Fact]
    public void EmptyStringResturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void OnlyOneNumberReturnsNumber()
    {
        var calculator = new Calculator();
        var result = calculator.Add("1");
        Assert.Equal(1, result);
    }

    [Fact]
    public void MoreThanOnNumberReturn()
    {
        var calculator = new Calculator();
        var result = calculator.Add("1,2");
        Assert.Equal(3, result);
    }

    [Fact]
    public void UnknownAmount()
    {
        var calculator = new Calculator();
        var result = calculator.Add("1,2,3,4,5");
        Assert.Equal(15, result);
    }

    [Fact]
    public void NextLineAmount()
    {
        var calculator = new Calculator();
        var result = calculator.Add("1\n5,3");
        Assert.Equal(9, result);
    }

}
