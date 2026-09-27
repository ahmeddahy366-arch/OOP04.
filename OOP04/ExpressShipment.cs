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
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {express} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
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


