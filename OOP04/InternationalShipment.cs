using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 05
    internal class InternationalShipment : Shipment, IInsurable, ITrackable
    {
        private string destinationCountry;
        private decimal customsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.destinationCountry = destinationCountry;
            this.customsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + customsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code        : {TrackingCode}");
            Console.WriteLine($"Destination Country  : {destinationCountry}");
            Console.WriteLine($"Estimated Cost       : {EstimatedCost} EGP");
            Console.WriteLine();
        }

  

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is currently in transit.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
    #endregion

}
