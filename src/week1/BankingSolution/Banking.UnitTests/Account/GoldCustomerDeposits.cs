
using Bank;

namespace Banking.UnitTests.Account;
public class GoldCustomerDeposits
{
    [Theory]
    [InlineData(100, 110)]
    [InlineData(42.23, 46.453)]
    public void MakingADespositIncreasesBalance(decimal amountToDeposit, decimal expected)
    {
        // given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        // when
        // WTCYWYH
        account.Deposit(amountToDeposit);

        // then
        Assert.Equal(openingBalance + expected, account.GetBalance());
    }
}
