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
            base.PrintShipment();
            Console.WriteLine($"Tracking Code: {TrackingCode}, Cost: {EstimatedCost}");
            Console.WriteLine($"Destination Country: {destinationCountry}");
            Console.WriteLine($"Customs Fee: {customsFee}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Generating Customs Report...");
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
