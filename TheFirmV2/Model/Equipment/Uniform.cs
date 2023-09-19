using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Equipment
{
    internal class Uniform
    {
        private UniformType _type;
        public override string ToString()
        {
            return $"{_type}";
        }
    }
    public enum UniformType
    {
        TechnicianClothes,
        OfficeSuit,
        LeaderSuit,
        DirectorSuit
    }
}
