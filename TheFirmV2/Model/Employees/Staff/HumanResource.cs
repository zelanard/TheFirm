using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Employees
{
    internal class HumanResource : Staff
    {
        private bool _extendedPersonalDataAccess;
        public override string ToString()
        {
            return $"{base.ToString()}, extended perosnal data access: {_extendedPersonalDataAccess}";
        }

    }
}
