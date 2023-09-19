using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Employees
{
    internal class Administration : Staff
    {
        private bool _financialAccess;
        public override string ToString()
        {
            return $"{base.ToString()}, Financial Access: {_financialAccess}";
        }
    }
}
