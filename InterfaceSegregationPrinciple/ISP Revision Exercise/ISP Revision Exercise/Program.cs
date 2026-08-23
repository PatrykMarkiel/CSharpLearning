using ISP_Revision_Exercise.Payments;

namespace ISP_Revision_Exercise;

internal class Program
{
    static void Main()
    {
        var creditCard = new CreditCardPayment();
        var cash = new CashPayment();
        var crypto = new CryptoPayment();
        var bankTransfer = new BankTransferPayment();

        creditCard.Pay(100);
        creditCard.SaveCard();

        cash.Pay(50);

        crypto.Pay(200);

        bankTransfer.Pay(500);
        bankTransfer.GetBankAccount();
    }
}