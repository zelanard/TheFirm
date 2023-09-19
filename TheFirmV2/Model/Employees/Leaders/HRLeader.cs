using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Employees.Leaders
{
    internal class HRLeader : StaffLeader
    {
        private List<Staff> _hrStaff;
        public override string ToString()
        {
            return $"{base.ToString()}, {_hrStaff}";
        }

    }
}
