namespace TheFirm.Model.Employees
{
    /// <summary>
    /// <c>ProejctManager</c> models a ProjectManger Manager.
    /// </summary>
    internal class ProjectManager : Manager
    {
        /** Attributes
         * We want the attributes to be inheritable.
         * We declare them as private protected to prevent inheritence outside of the assembly.
         */
        private protected string eMailAddress;

        public ProjectManager(string firstName, string lastName, string cprNr, string pNumber, string mail) : base(firstName, lastName, cprNr, pNumber)
        {
            eMailAddress = mail;
        }

        /** Properties
         * We want the properties to be inheritable and accessible.
         */
        /// <summary>
        /// get/set the project managers e-mail address
        /// </summary>
        public string EMailAddress
        {
            get
            {
                return eMailAddress;
            }

            protected set
            {
                eMailAddress = value;
            }
        }

        //Methods
        public override string ToString()
        {
            return $"{base.ToString()}, E-mail:{EMailAddress}";
        }
    }
}
