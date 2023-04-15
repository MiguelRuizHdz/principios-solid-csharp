using Liskov;
/**
 ************************************ Demo - Escenario **********************************************
 * En un aplicación tenemos 2 tipos de empleados, contactor y full-time, solo un empleado full-time *
 * tiene derecho a horas extras. El valor de la hora es 50 para full-time y de 40 para contractor.  *
 * Ajustar el código para cumplir con los principios SOLID.                                         *
 ****************************************************************************************************
 */
CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160, 10),
    new EmployeeContractor("Manuel Lopera", 180, 0)
});

void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalary((item is EmployeeFullTime));
        Console.WriteLine($"The {item.Fullname}'s salary is {salary}");
        
    }
}