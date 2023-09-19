namespace TheFirm.Model.Employees
{
    /// <summary>
    /// <c>Manager</c> models a Manager Employee.
    /// </summary>
    internal class Manager : Employee
    {
        /** Attributes
         * We want the attributes to be inheritable.
         * We declare them as private protected to prevent inheritence outside of the assembly.
         */
        private protected string phoneNumber;

        public Manager(string firstName, string lastName, string cprNr, string pNumber) : base(firstName, lastName, cprNr)
        {
            PhoneNumber = pNumber;
        }

        /** Properties
         * We want the properties to be inheritable and accessible.
         */
        /// <summary>
        /// get/set the managers phone number.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            protected set
            {
                phoneNumber = value;
            }
        }

        //Methods
        public override string ToString()
        {
            return $"{base.ToString()}, tlf.nr:{PhoneNumber}";
        }
    }
}
