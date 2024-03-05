using Bank;

namespace Banking.UnitTests.Accounts;

public class MakingWithdrawls

{

    [Theory]

    [InlineData(100)]

    [InlineData(2.25)]

    public void MakingAWithdrawalDecreasesTheBalance(decimal amountToWithdraw)

    {

        var account = new BankAccount();

        var openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());

    }
}