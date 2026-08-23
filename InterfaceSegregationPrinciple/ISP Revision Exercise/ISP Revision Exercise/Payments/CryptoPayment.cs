using ISP_Revision_Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Revision_Exercise.Payments
{
    public class CryptoPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using crypto.");
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine($"Refunded {amount} using crypto.");
        }

        public void SendReceipt()
        {
            Console.WriteLine("Receipt sent.");
        }
    }
}
