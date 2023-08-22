using System;
using System.Collections.Generic;

namespace Patrones_Creacionales
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    
    

    class Program
    {
        //descomentar esta parte y comentar las demás para probar el patrón Builder

        //static void Main(string[] args)
        //{
        //    var carBuilder = new CarBuilder();
        //    var carManufacturer = new CarManufacturer(carBuilder);

        //    Console.WriteLine("Building a standard car:");
        //    carManufacturer.BuildStandardCar();
        //    Console.WriteLine(carBuilder.GetCar().ListParts());
        //}

        //descomentar esta parte y comentar las demás para probar el patrón Mediator

        //static void Main(string[] args)
        //{
        //    // The client code.
        //    Pilot pilot1 = new Pilot();
        //    Pilot pilot2 = new Pilot();
        //    IAirplaneMediator mediator = new AirplaneMediator(pilot1, pilot2);

        //    pilot1.SetMediator(mediator);
        //    pilot2.SetMediator(mediator);

        //    Console.WriteLine("Flight in progress...");

        //    // Simulating events
        //    Console.WriteLine("\nEmergency situation detected:");
        //    pilot1.InitiateEmergencyProtocol();

        //    Console.WriteLine("\nCourse correction required:");
        //    pilot2.AdjustCourse();
        //}

        //descomentar esta parte y comentar las demás para probar el patrón Chain of responsability

        //static void Main(string[] args)
        //{
        //    // Constructing the expense approval chain.
        //    var managerHandler = new ManagerExpenseHandler();
        //    var directorHandler = new DirectorExpenseHandler();
        //    var ceoHandler = new CEOExpenseHandler();

        //    managerHandler.SetNext(directorHandler).SetNext(ceoHandler);

        //    // Simulating expense requests.
        //    var expenses = new List<Expense>
        //    {
        //        new Expense { Purpose = "Office Supplies", Amount = 300 },
        //        new Expense { Purpose = "Business Travel", Amount = 1500 },
        //        new Expense { Purpose = "Conference Sponsorship", Amount = 6000 }
        //    };

        //    foreach (var expense in expenses)
        //    {
        //        Console.WriteLine($"Requesting approval for ${expense.Amount} - {expense.Purpose}");
        //        if (!managerHandler.ApproveExpense(expense))
        //        {
        //            Console.WriteLine($"Expense of ${expense.Amount} for {expense.Purpose} was not approved.");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //descomentar esta parte y comentar las demás para probar el patrón Strategy

        //static void Main(string[] args)
        //{
        //    var context = new PaymentProcessorContext(new CreditCardPaymentProcessor());

        //    Console.WriteLine("Processing a payment of $100 with credit card:");
        //    context.ProcessPayment(100);

        //    Console.WriteLine();

        //    Console.WriteLine("Changing payment strategy to PayPal:");
        //    context.SetPaymentProcessor(new PayPalPaymentProcessor());
        //    context.ProcessPayment(75);
        //}

        //descomentar esta parte y comentar las demás para probar el patrón Template Method

        public static void Main(string[] args)
        {
            Console.WriteLine("Processing online order:");
            OrderProcessor onlineOrderProcessor = new OnlineOrderProcessor();
            onlineOrderProcessor.ProcessOrder();

            Console.WriteLine("\nProcessing in-store order:");
            OrderProcessor inStoreOrderProcessor = new InStoreOrderProcessor();
            inStoreOrderProcessor.ProcessOrder();
        }
    }
}
