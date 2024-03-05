using Bank;

namespace Banking.UnitTests.Accounts;
public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(432.2)]
    public void MakingADespositIncreasesBalance(decimal amountToDeposit)
    {
        // given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        // when
        // WTCYWYH
        account.Deposit(amountToDeposit);

        // then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}