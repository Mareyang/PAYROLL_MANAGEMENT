using System.Security.Cryptography.X509Certificates;

namespace payrollsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------PAYROLL MANAGEMENT SYSTEM---------------");

            string[] employeeId = new string[3];
            string[] employeeName = new string[3];

            employeeId[0] = "A00";
            employeeId[1] = "B11";
            employeeId[2] = "C22";

            employeeName[0] = "Employee A";
            employeeName[1] = "Employee B";
            employeeName[2] = "Employee C";

            int[] employeeDays = new int[3];
            int[] employeeOT = new int[3];

            employeeDays[0] = 12;
            employeeDays[1] = 10;
            employeeDays[2] = 8;

            employeeOT[0] = 2;
            employeeOT[1] = 3;
            employeeOT[2] = 5;

            double sss = 0.045, philp = 0.025, pagibig = 0.02, c = 0, d = 0, e = 0, f = 0;
            double perday = 600, b = 0;
            double Othr = 92, a = 0;





            Console.Write("Enter Employee ID: ");
            string id = Console.ReadLine();

            if (id == employeeId[0])
            {
                Console.WriteLine("Employee Name: " + employeeName[0]); Console.WriteLine("Position: Crew");
                a = employeeDays[0] * perday;
                Console.Write("Days Worked: " + employeeDays[0]); Console.Write("          ");  Console.WriteLine("Basic Pay: " + a);
                b = employeeOT[0] * Othr;
                Console.Write("Overtime (hrs): " + employeeOT[0]); Console.Write("        "); Console.WriteLine("Overtime: " + b);
                c = a + b;
                Console.Write("TOTAL EARNINGS: " + c );
                Console.WriteLine("        ");
                Console.WriteLine("---------------DEDUCTIONS---------------");
                d = c * sss;
                Console.WriteLine("SSS: " + d);
                e = c * philp;
                Console.WriteLine("PhilHealth: " + e);
                f = c * pagibig;
                Console.WriteLine("Pag-Ibig: " + f);
                Console.WriteLine("Total Deduction: " + (d+e+f));

                Console.WriteLine("---------------NET PAY---------------");
                Console.WriteLine("SALARY: " + (c - (d+e+f)));

            }

            else if (id == employeeId[1])
            {
                Console.WriteLine("Employee Name: " + employeeName[1]); Console.WriteLine("Position: Crew");
                a = employeeDays[1] * perday;
                Console.Write("Days Worked: " + employeeDays[1]); Console.Write("          "); Console.WriteLine("Basic Pay: " + a);
                b = employeeOT[1] * Othr;
                Console.Write("Overtime (hrs): " + employeeOT[1]); Console.Write("        "); Console.WriteLine("Overtime: " + b);
                c = a + b;
                Console.Write("TOTAL EARNINGS: " + c);
                Console.WriteLine("        ");
                Console.WriteLine("---------------DEDUCTIONS---------------");
                d = c * sss;
                Console.WriteLine("SSS: " + d);
                e = c * philp;
                Console.WriteLine("PhilHealth: " + e);
                f = c * pagibig;
                Console.WriteLine("Pag-Ibig: " + f);
                Console.WriteLine("Total Deduction: " + (d + e + f));

                Console.WriteLine("---------------NET PAY---------------");
                Console.WriteLine("SALARY: " + (c - (d + e + f)));
            }

            else if (id == employeeId[2])
            {
                Console.WriteLine("Employee Name: " + employeeName[2]); Console.WriteLine("Position: Crew");
                a = employeeDays[2] * perday;
                Console.Write("Days Worked: " + employeeDays[2]); Console.Write("          "); Console.WriteLine("Basic Pay: " + a);
                b = employeeOT[2] * Othr;
                Console.Write("Overtime (hrs): " + employeeOT[2]); Console.Write("        "); Console.WriteLine("Overtime: " + b);
                c = a + b;
                Console.Write("TOTAL EARNINGS: " + c);
                Console.WriteLine("        ");
                Console.WriteLine("---------------DEDUCTIONS---------------");
                d = c * sss;
                Console.WriteLine("SSS: " + d);
                e = c * philp;
                Console.WriteLine("PhilHealth: " + e);
                f = c * pagibig;
                Console.WriteLine("Pag-Ibig: " + f);
                Console.WriteLine("Total Deduction: " + (d + e + f));

                Console.WriteLine("---------------NET PAY---------------");
                Console.WriteLine("SALARY: " + (c - (d + e + f)));

            }

            else 
            {
                Console.WriteLine("Invalid Input!!");
            }













            /* string employeeName;
            Console.Write("Enter employee name: ");
            employeeName = Console.ReadLine();

           string position;
            Console.Write("Enter employee position: ");
            position = Console.ReadLine(); 

            int daysWorked;
            Console.Write("Enter number of days worked: ");
            daysWorked = int.Parse(Console.ReadLine());

          /* int hoursWorked;
            Console.Write("Enter number of hours worked: ");
            hoursWorked = int.Parse(Console.ReadLine()); 


            int perday = 600;
            int salary = daysWorked * perday;

            Console.WriteLine(" ");

            Console.WriteLine("--------------------PAYSLIP--------------------");
            Console.Write("EMPLOYEE: ");
            Console.Write(employeeName);
            
            Console.WriteLine(" ");

            Console.Write("TOTAL SALARY: ");
            Console.Write((int)salary); */




        }
    }
}
