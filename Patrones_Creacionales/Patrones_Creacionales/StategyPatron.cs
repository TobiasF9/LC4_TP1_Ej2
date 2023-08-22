using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPaymentProcessor : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} with credit card...");
        }
    }

    public class PayPalPaymentProcessor : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} with PayPal...");
        }
    }

    public class PaymentProcessorContext
    {
        private IPaymentStrategy _paymentProcessor;

        public PaymentProcessorContext(IPaymentStrategy paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void SetPaymentProcessor(IPaymentStrategy paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void ProcessPayment(double amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
