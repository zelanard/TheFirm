using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Employees
{
    internal class Manager : Leader
    {
        private List<Worker> _workerTeam;
        public override string ToString()
        {
            return $"{base.ToString()}, {_workerTeam}";
        }

    }
}
