using WierdBrainCoffee.StorageApp.Data;
using WierdBrainCoffee.StorageApp.Entities;
using WierdBrainCoffee.StorageApp.Reposatory;

class Program
{
    static void Main(string[] args)
    {
        //var employeeRepository = new SqlRepository<Employee>(new StorageContextDbContext());
        //WriteAllConsole(employeeRepository);
        //AddEmployee(employeeRepository);
        //AddManger(employeeRepository);
        //GetEmployeeByID(employeeRepository);
        //var organisationRepository = new List<Organisation>();
        //AddOrganization(organisationRepository);
        var employeeRepository = new SqlRepository<Employee>(new StorageContextDbContext());
        AddEmployee(employeeRepository);
        AddManger(employeeRepository);
        GetEmployeeByID(employeeRepository);
        WriteAllConsole(employeeRepository);

        var organizationRepository = new ListRepository<Organisation>();
        AddOrganizations(organizationRepository);
        WriteAllConsole(organizationRepository);

        Console.ReadLine();


    }

    private static void AddManger(IWriteRepository<Manger> MangerRepository)
    {
        MangerRepository.Add(new Manger { FirstName = "Hulk" });
        MangerRepository.Add(new Manger { FirstName = "Iron Monger" });
        MangerRepository.Save();

    }

    private static void WriteAllConsole(IReadRepository<IEntity> repository)
    {
        var items = repository.GetAll();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    
    private static void GetEmployeeByID(IReadRepository<Employee> employeeRepository)
    {
        var employee = employeeRepository.GetID(2);
        Console.WriteLine($"Employee with ID 2 : {employee.FirstName}");
    }

    private static void AddEmployee(IRepository<Employee> ?employeeRepository)
    {
        
        employeeRepository.Add(new Employee { FirstName = "AMAN SINGH" });
        employeeRepository.Add(new Employee { FirstName = "KULDEEP SINGH" });
        employeeRepository.Add(new Employee { FirstName = "ANISH KUMAR" });
        employeeRepository.Save();
    }

    //private static void AddOrganization(IRepository<Organisation> orginationRepository) { 

    //    orginationRepository.Add(new Organisation { Name = "ABJIMA" });
    //    orginationRepository.Add(new Organisation { Name = "AITCS" });
    //    orginationRepository.Save();
    //}
    private static void AddOrganizations(IRepository<Organisation> organizationRepository)
    {
        organizationRepository.Add(new Organisation { Name = "Pluralsight" });
        organizationRepository.Add(new Organisation { Name = "Globomantics" });
        organizationRepository.Save();
    }
}
