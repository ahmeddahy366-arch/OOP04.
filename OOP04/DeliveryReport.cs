using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 09
    internal class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine($"{shipment.GetType().Name.Replace("Shipment", " Shipment")} Insurance : {shipment.CalculateInsurance():F2} EGP");
            }
        }
    }
    #endregion
}

