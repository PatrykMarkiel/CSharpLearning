using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Revision_Exercise.Payments
{
    using ISP_Revision_Exercise.Interfaces;

    public class CreditCardPayment : IPaymentMethod, ISaveCard
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by credit card.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refunded {amount} to credit card.");
        }

        public void SaveCard()
        {
            Console.WriteLine("Card saved.");
        }

        public void SendReceipt()
        {
            Console.WriteLine("Receipt sent.");
        }
    }
}
