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
}
