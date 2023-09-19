using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Equipment
{
    internal class WorkCar
    {
        protected string _registration;
        protected int _insuranceNumber;
        public override string ToString()
        {
            return $"registration: {_registration}, inurance: {_insuranceNumber}";
        }

    }
}
