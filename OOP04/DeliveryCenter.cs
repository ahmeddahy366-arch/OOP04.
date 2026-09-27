using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 07
    internal class DeliveryCenter
    {
        private Shipment[] Shipments = new Shipment[20];

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string TrackingCode)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null && Shipments[i].TrackingCode == TrackingCode)
                {
                    Shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null)
                {
                    Shipments[i].PrintShipment();
                }
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in Shipments)
            {
                if (t != null)
                    Console.WriteLine(t.GetTrackingStatus());
            }
        }

        public void PrintCalculateInsurance()
        {
            foreach (var s in Shipments)
            {
                if (s is IInsurable insurable)
                {
                    string name = s.GetType().Name;
                    if (name == "StandardShipment") name = "Standard Shipment";
                    else if (name == "ExpressShipment") name = "Express Shipment";
                    else if (name == "InternationalShipment") name = "International Shipment";

                    Console.WriteLine($"{name} Insurance : {insurable.CalculateInsurance():F2} EGP");
                    Console.WriteLine();
                }
            }
        }
    #endregion

    }
}
