using System;
using System.Collections.Generic;
using FactoryPattern.FactoryEngine;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PaymentProcessor();

            var invoicesList = new List<Invoice>();
            invoicesList.Add(new Invoice() { Id = 1, IdPaymentMethod = 1, Value = 12000M });
            invoicesList.Add(new Invoice() { Id = 2, IdPaymentMethod = 2, Value = 22000M });
            invoicesList.Add(new Invoice() { Id = 3, IdPaymentMethod = 3, Value = 52000M });

            foreach (var item in invoicesList)
            {
                processor.PreparePayment(item);
            }

        }
    }
}
