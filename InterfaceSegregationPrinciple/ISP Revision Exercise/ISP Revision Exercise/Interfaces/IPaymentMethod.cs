using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Revision_Exercise.Interfaces
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
        void Refund(decimal amount);
        void SendReceipt();
    }
}
