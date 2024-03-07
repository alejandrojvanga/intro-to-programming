namespace StringCalculator.Test;
public class Calculator(ILogger logger, IWebService service)
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        var answer = numbers.Split(',').Select(int.Parse).Sum();
        try
        {
            logger.Write(answer.ToString());
        }
        catch (LoggerException)
        {
            service.NotifyLoggingError($"Logger Failure {answer}");
        }
        return answer;
    }
}

public interface IWebService
{
    void NotifyLoggingError(string message);
}
public interface ILogger
{
    void Write(string message);
}

public class LoggerException : ApplicationException { }