using TheFirm.Model.Employees;
using TheFirm.Model;
using TheFirm.View;

namespace TheFirm.Control
{
    public static class Ctrl
    {
        public static void Start()
        {
            string firstname, lastname;
            firstname = Generator.FirstName();
            lastname = Generator.LastName();
            Employee employee = new Employee(
                firstname,
                lastname,
                Generator.SocialSecurityNumber()
                );

            firstname = Generator.FirstName();
            lastname = Generator.LastName();
            Manager manager = new Manager(
                firstname,
                lastname,
                Generator.SocialSecurityNumber(),
                Generator.PhoneNumber()
                );

            firstname = Generator.FirstName();
            lastname = Generator.LastName();
            ProjectManager projectManager = new ProjectManager(
                firstname,
                lastname,
                Generator.SocialSecurityNumber(),
                Generator.PhoneNumber(),
                Generator.Email(firstname, lastname)
                );

            ConsoleWriter.Print(employee.ToString());
            ConsoleWriter.Print(manager.ToString());
            ConsoleWriter.Print(projectManager.ToString());
            ConsoleWriter.Wait();
        }
    }
}
