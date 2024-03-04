namespace TodosApi.ContractTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Given
        int a = 1, b = 2, answer;

        // When
        answer = a + b;

        // Then
        Assert.Equal(3, answer);

    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]
    public void canAddIntegers(int a, int b, int expected)
    {
        int answer = a + b;
        Assert.Equal(expected, answer);
    }
}