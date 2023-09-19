using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Equipment;

namespace TheFirmV2.Model.Employees
{
    internal class Leader : Employee
    {
        private protected WorkPhone _workPhone;
        private protected Uniform _uniform;

        public override string ToString()
        {
            return $"{base.ToString()}, {_workPhone}, {_uniform}";
        }
    }
}