using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Equipment;

namespace TheFirmV2.Model.Employees
{
    internal class Worker
    {
        private protected TimeSpan _workHours;
        private protected Uniform _uniform;
        public override string ToString()
        {
            return $"{base.ToString()}, work hours:{_workHours}, {_uniform}";
        }

    }
}
