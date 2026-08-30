using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    #region Question 06
    internal interface ITrackable
    {
        public string GetTrackingStatus();
    }

    internal interface IInsurable
    {
        public decimal CalculateInsurance();
    }
    #endregion
}

