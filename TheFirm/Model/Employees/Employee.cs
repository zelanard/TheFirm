namespace TheFirm.Model.Employees
{
    /// <summary>
    /// <c>Employee</c> models an employee
    /// </summary>
    internal class Employee
    {
        /** Attributes
         * We want the attributes to be inheritable.
         * We declare them as private protected to prevent inheritence outside of the assembly.
         */
        private protected string firstName;
        private protected string lastName;
        private protected string cprNr;

        /** Constructors
         */
        public Employee()
        {
            FirstName = "";
            LastName = "";
            CprNr = "";
        }
        public Employee(string firstName, string lastName, string cprNr)
        {
            FirstName = firstName;
            LastName = lastName;
            CprNr = cprNr;
        }

        /** Properties
         * We want the properties to be inheritable and accessible.
         */

        /// <summary>
        /// get/set the employee's first name.
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }

            protected set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// get/set the employee's last name.
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }

            protected set
            {
                lastName = value;
            }
        }

        /// <summary>
        /// get/set the employee's social security number.
        /// </summary>
        public string CprNr
        {
            get
            {
                return cprNr;
            }

            protected set
            {
                cprNr = value;
            }
        }

        //Methods
        public override string ToString()
        {
            return $"cpr nummer: {CprNr}, Navn: {FirstName} {LastName}";
        }
    }
}