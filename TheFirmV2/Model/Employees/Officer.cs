using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Equipment;

namespace TheFirmV2.Model.Employees
{
    internal class Officer : Leader
    {
        private protected DirectorCar _directorCar;
        public override string ToString()
        {
            return $"{base.ToString()}, {_directorCar}";
        }

    }
}
