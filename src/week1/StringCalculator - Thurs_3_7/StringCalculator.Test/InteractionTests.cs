namespace StringCalculator.Test;
public class InteractionTests
{
    [Fact]
    public void ResultIsLogged()
    {
        var mockedLogger = Substitute.For<ILogger>();
        var calculator = new Calculator(mockedLogger, Substitute.For<IWebService>());

        calculator.Add("1,2");

        mockedLogger.Received().Write("3");
    }

    [Fact]

    public void WhenLoggerCrashesYouCallWebService()
    {
        var stubbedLogger = Substitute.For<ILogger>();
        stubbedLogger.When(x => x.Write("10")).Throw<LoggerException>();

        var calculator = new Calculator(stubbedLogger, Substitute.For<IWebService>());
        calculator.Add("10");

    }
}
