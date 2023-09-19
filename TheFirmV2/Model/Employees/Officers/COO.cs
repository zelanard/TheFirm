using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Employees.Leaders;

namespace TheFirmV2.Model.Employees
{
    internal class COO : Officer
    {
        private List<Cheif> _cheifs;
        public override string ToString()
        {
            return $"{base.ToString()}, {_cheifs}";
        }
    }
}
