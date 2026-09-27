namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //a) What is Abstraction in Object-Oriented Programming?
            //Abstraction in OOP is the concept of hiding complex internal
            //implementation details and exposing only the essential features of an object to the user.
            //b) Why is abstraction considered one of the four pillars of OOP?
            //// Abstraction reduces complexity by hiding unnecessary details, enhances maintainability,
            // increases code security, and allows developers to focus on high-level interactions 
            // rather than low-level implementation.
            #endregion
            #region Question 02
            //a) What is the difference between an Abstract Class and an Interface?
            //Abstract Class: Represents an "is-a" relationship with shared code, fields, and constructors, but supports only single inheritance.
            //Interface: Represents a "can-do" capability defining a strict contract without fields or constructors, supporting multiple inheritance.
            //b) When would you choose an Interface instead of an Abstract Class?
            //Multiple Inheritance: A class needs to adopt multiple behaviors,
            //as C# supports implementing multiple interfaces but inheriting from only one base class.
            //Defining Capabilities ("can-do")
            //No Shared State / Code: You only need to enforce a behavioral contract without sharing instance fields, state, or default code logic.
            //c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //Multiple Abstract Classes: No. C# does not support multiple class inheritance.
            //Multiple Interfaces: Yes. A single class can implement multiple interfaces at the same time.
            #endregion
            #region Main Execution
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Tahrir St", 10);
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 2.5m, 95.0m, 0m, addr1);

            DeliveryAddress addr2 = new DeliveryAddress("Alexandria", "Corniche", 5);
            ExpressShipment express = new ExpressShipment("SH002", "Phone", 1.0m, 70.0m, 30.0m, addr2);



            DeliveryAddress addr3 = new DeliveryAddress("Berlin", "Main St", 100);
            InternationalShipment international = new InternationalShipment("SH003", "Documents", 0.5m, 200.0m, "Germany", 60.0m, addr3);



            DeliveryCenter center = new DeliveryCenter();
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            center.PrintAllShipments();



            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            center.PrintTrackingStatuses();



            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            center.PrintCalculateInsurance();


            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism (ITrackable Array)");
            Console.WriteLine("==========================================");
            ITrackable[] trackableShipments = new ITrackable[] { standard, express, international };
            foreach (var item in trackableShipments)
            {
                DeliveryReport.PrintShipment(item);
            }
            Console.WriteLine();




            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism (IInsurable Array)");
            Console.WriteLine("==========================================");
            IInsurable[] insurableShipments = new IInsurable[] { standard, express, international };
            foreach (var item in insurableShipments)
            {
                DeliveryReport.PrintInsurance(item);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion

        }
    }
}
