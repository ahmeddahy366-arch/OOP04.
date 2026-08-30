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
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine(shipment.CalculateInsurance());
        }
    }
    #endregion
}

