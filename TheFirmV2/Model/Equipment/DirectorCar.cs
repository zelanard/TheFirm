using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Equipment
{
    internal class DirectorCar : WorkCar
    {
        private string _brand;
        public override string ToString()
        {
            return $"{base.ToString()}, Brand: {_brand}";
        }

    }
}
