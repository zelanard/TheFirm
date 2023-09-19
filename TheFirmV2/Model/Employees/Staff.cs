using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Employees
{
    internal class Staff : Employee
    {
        private protected bool _personalDataAccess;
        public override string ToString()
        {
            return $"{base.ToString()}, personal data access:{_personalDataAccess}";
        }

    }
}
