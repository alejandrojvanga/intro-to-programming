
using Bank;

namespace Banking.UnitTests.Account;
public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        // WTCYWYH - "Write The Code You Wish You Had"

        // given - brand new account
        var account = new BankAccount();

        // when - i get a balance
        decimal openingBalance = account.GetBalance();

        Assert.Equal(5000M, openingBalance);
    }
}
