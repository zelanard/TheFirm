using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Employees
{
    internal class Employee
    {
        private protected string _cprNr;
        private protected string _firstname;
        private protected string _lastname;
        private protected string _phoneNumber;
        private protected string _emailAddress;
        private protected int _salary;
        private protected Position _position;

        public override string ToString()
        {
            return $"cpr nr: {_cprNr}, name {_firstname} {_lastname}, phone nr: {_phoneNumber}, email: {_emailAddress}, salary: {_salary}, position: {_position}";
        }
    }
    public enum Position
    {
        CEO,
        CFO,
        COO,
        Administration,
        HumanResources,
        OfficeWorker,
        LogisticsWorker,
        Technician,
        HRLeader,
        AdministrationLeader,
        Manager,
        Chief
    }
}
