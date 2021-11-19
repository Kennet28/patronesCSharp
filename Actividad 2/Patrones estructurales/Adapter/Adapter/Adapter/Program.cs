//Las clases, interfaces y objetos en el diagrama de clases anterior se pueden identificar
//de la siguiente manera:
//ITraget - Interfaz de destino
//Employee Adapter- Clase de adaptador
//HR System - Clase adaptada
//ThirdPartyBillingSystem - Cliente
//El patrón Adapter actúa como envoltorio entre dos objetos. Atrapa las llamadas a un objeto y 
//las transforma a un formato y una interfaz reconocible para el segundo objeto.

///// La clase 'Cliente'
public class ThirdPartyBillingSystem
{
    private ITarget employeeSource;

    public ThirdPartyBillingSystem(ITarget employeeSource)
    {
        this.employeeSource = employeeSource;
    }

    public void ShowEmployeeList()
    {
        List<string> employee = employeeSource.GetEmployeeList();
        // Para HACER: Implementar su lógica de negocios

        Console.WriteLine("######### Lista de Empleados ##########");
        foreach (var item in employee)
        {
            Console.Write(item);
        }

    }
}
//La interfaz 'ITarget'
public interface ITarget
{
    List<string> GetEmployeeList();
}

// clase adaptadora
public class HRSystem
{
    public string[][] GetEmployees()
    {
        string[][] employees = new string[4][];

        employees[0] = new string[] { "100", "Carlos hernandez", "Team Leader" };
        employees[1] = new string[] { "101", "pedro castro", "Developer" };
        employees[2] = new string[] { "102", "jorge uc", "Developer" };
        employees[3] = new string[] { "103", "miguel chi", "Tester" };

        return employees;
    }
}

// clase adaptadora
public class EmployeeAdapter : HRSystem, ITarget
{
    public List<string> GetEmployeeList()
    {
        List<string> employeeList = new List<string>();
        string[][] employees = GetEmployees();
        foreach (string[] employee in employees)
        {
            employeeList.Add(employee[0]);
            employeeList.Add(",");
            employeeList.Add(employee[1]);
            employeeList.Add(",");
            employeeList.Add(employee[2]);
            employeeList.Add("\n");
        }

        return employeeList;
    }
}



//Demostración de patrón de diseño de adaptador

class Program
{
    static void Main(string[] args)
    {
        ITarget Itarget = new EmployeeAdapter();
        ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
        client.ShowEmployeeList();

        Console.ReadKey();

    }
}