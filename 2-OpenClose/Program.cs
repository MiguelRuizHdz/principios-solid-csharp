using OpenClose;

/**
 ************************************ Demo - Escenario ********************************************
 * Tenemos un proyecto que tiene una clase EmployeeFullTime para empleados a tiempo completo      *
 * y EmployeePartTime para medio tiempo y necesitamos agregar EmployeeContractor para empleados   *
 * externos cumpliendo con el principio Abierto/Cerrado.                                          *
 **************************************************************************************************
 */

ShowSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Juan García", 150),
});


void ShowSalaryMonthly(List<Employee> employees) 
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C1} ");
    }

}