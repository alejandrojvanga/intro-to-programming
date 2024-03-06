
namespace StringCalculator.Test;
public class Calculator
{
    private int addition;

    public int Add(string numbers)
    {
        /*
        var numberList = numbers.Split([',', '\n']);
        if (numberList.Length == 5)
        {
            return 15;
        }

        var num1 = int.Parse(numberList[0]);
        var num2 = int.Parse(numberList[1]);
        var num3 = int.Parse(numberList[2]);
        var addition = num1 + num2 + num3;

        return addition;*/

        if (numbers == "")
        {
            return 0;
        }
        else
        {
            return numbers.Split([',', '\n']).Select(int.Parse).Sum();
        }
    }
}
