using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Employees.Leaders;

namespace TheFirmV2.Model.Employees
{
    internal class CEO : Officer
    {
        private List<StaffLeader> _staffLeaders;
        private CFO _cfo;
        private COO _coo;
        public override string ToString()
        {
            return $"{base.ToString()}, {_cfo}, {_coo}, {_staffLeaders}";
        }

    }
}
