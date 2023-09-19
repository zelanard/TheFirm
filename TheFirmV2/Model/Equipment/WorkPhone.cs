using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Equipment
{
    internal class WorkPhone
    {
        private string _type;
        public override string ToString()
        {
            return $"Phone: {_type}";
        }

    }
}
