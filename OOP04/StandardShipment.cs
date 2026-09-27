using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 05
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, decimal extraFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee; }
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is currently in transit.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
         
        }
    }
    #endregion

}
