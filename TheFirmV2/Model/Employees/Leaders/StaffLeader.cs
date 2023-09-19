using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Equipment;

namespace TheFirmV2.Model.Employees.Leaders
{
    internal class StaffLeader : Leader
    {
        private protected WorkCar _workCar;
        public override string ToString()
        {
            return $"{base.ToString()}, {_workCar}";
        }
    }
}
