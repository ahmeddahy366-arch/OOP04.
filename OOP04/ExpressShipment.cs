using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 05
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {

        private decimal express;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, decimal express, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.express = express;
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + express;
            }
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Tracking Code: {TrackingCode}, Cost: {EstimatedCost}");
            Console.WriteLine($"Extra Fee: {express}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is currently in transit.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}
    #endregion


