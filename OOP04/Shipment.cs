using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 04
    internal abstract class Shipment
    {
        public string TrackingCode;
        public string Description;
        public decimal Weight;
        public decimal DeliveryFee;
        public DeliveryAddress Destination;

        protected Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();
       }
    }
    #endregion

