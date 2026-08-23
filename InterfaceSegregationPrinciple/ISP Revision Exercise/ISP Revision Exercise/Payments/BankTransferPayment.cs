using ISP_Revision_Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Revision_Exercise.Payments
{
    public class BankTransferPayment : IPaymentMethod, IBankAccount
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by bank transfer.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refunded {amount} by bank transfer.");
        }

        public void SendReceipt()
        {
            Console.WriteLine("Receipt sent.");
        }
        public void GetBankAccount()
        {
            Console.WriteLine("Got Bank account");
        }
    }
}
