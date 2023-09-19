using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Equipment;

namespace TheFirmV2.Model.Employees.Workers
{
    internal class LogisticsWorker
    {
        private WorkPhone _workPhone;
        public override string ToString()
        {
            return $"{base.ToString()}, {_workPhone}";
        }

    }
}
