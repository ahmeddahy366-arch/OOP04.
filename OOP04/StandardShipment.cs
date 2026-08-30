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

        public override decimal EstimatedCost => DeliveryFee + 10;

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
            base.PrintShipment();
            Console.WriteLine($"[Standard Shipment] Code: {TrackingCode}, Description: {Description}, Cost: {EstimatedCost}");
        }
    }
    #endregion

}
