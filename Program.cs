using PayrollManagement;
using PayrollManagementModels;

namespace payrollsystem
{
    internal class Program
    {
        static payrollservices payrollService = new payrollservices();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------ PAYROLL MANAGEMENT SYSTEM ------");

                Console.WriteLine("[1] ADMIN");
                Console.WriteLine("[2] EMPLOYEE");
                Console.WriteLine("[3] EXIT");
                Console.Write("Choose Option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AdminLogin();
                        break;
                    case "2":
                        EmployeePayslip();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid.");
                        break;
                }

          
            }

            static void AdminLogin()
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (payrollService.AdminLogin(username, password))
                {
                    AdminMenu();
                }
                else
                {
                    Console.WriteLine("Invalid login.");
                }
            }

            static void AdminMenu()
            {
                Console.WriteLine("\nADMIN MENU");
                Console.WriteLine("[1] Add Employee");
                Console.WriteLine("[2] View Employees");
                Console.WriteLine("[3] Search Employee");

                Console.Write("Choose: ");
                string option = Console.ReadLine();

                if (option == "1")
                    AddEmployee();

                else if (option == "2")
                    ViewEmployees();

                else if (option == "3")
                    SearchEmployee();
            }

            static void AddEmployee()
            {
                Employee emp = new Employee();

                Console.Write("Employee ID: ");
                emp.EmployeeId = Console.ReadLine();

                Console.Write("Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Position: ");
                emp.Position = Console.ReadLine();

                Console.Write("Days Worked: ");
                emp.DaysWorked = Convert.ToInt32(Console.ReadLine());

                Console.Write("Overtime Hours: ");
                emp.OvertimeHours = Convert.ToInt32(Console.ReadLine());

                emp.DailyRate = 600;
                emp.OvertimeRate = 92;

                payrollService.AddEmployee(emp);

                Console.WriteLine("Employee added successfully.");
            }

            static void ViewEmployees()
            {
                var employees = payrollService.GetEmployees();

                foreach (var emp in employees)
                {
                    Console.WriteLine($"{emp.EmployeeId} - {emp.Name}");
                }
            }

            static void SearchEmployee()
            {
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                var emp = payrollService.SearchEmployee(id);

                if (emp != null)
                {
                    Console.WriteLine($"{emp.EmployeeId} - {emp.Name}");

                    double earnings = payrollService.TotalEarnings(emp);
                    double deduction = payrollService.TotalDeduction(emp);
                    double net = payrollService.NetPay(emp);

                    Console.WriteLine("\n------ PAYSLIP ------");
                    Console.WriteLine("Name: " + emp.Name);
                    Console.WriteLine("Position: " + emp.Position);
                    Console.WriteLine("Total Earnings: " + earnings);
                    Console.WriteLine("Total Deduction: " + deduction);
                    Console.WriteLine("Net Pay: " + net);
                }

                else
                    Console.WriteLine("Employee not found.");
            }

            static void EmployeePayslip()
            {
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                var emp = payrollService.SearchEmployee(id);

                if (emp == null)
                {
                    Console.WriteLine("Employee not found.");
                    return;
                }

                double earnings = payrollService.TotalEarnings(emp);
                double deduction = payrollService.TotalDeduction(emp);
                double net = payrollService.NetPay(emp);

                Console.WriteLine("\n------ PAYSLIP ------");
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Position: " + emp.Position);
                Console.WriteLine("Total Earnings: " + earnings);
                Console.WriteLine("Total Deduction: " + deduction);
                Console.WriteLine("Net Pay: " + net);
            }
        }
    }
}