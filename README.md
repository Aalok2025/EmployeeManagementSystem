
Add, Update, Delete, View Employees
Search Employees by ID or Name
Logging System using Delegates & Events
Database Connectivity using ADO.NET
Use Generics for a Reusable Repository Pattern

Review feedback concepts - Logging, configuration, exception handling, 
SQL script backup files , Multi layered application architecture, Broader data set,
Search, Validations, extension functions, Broader data set, Search,

Step-by-Step Implementation
 Step 1: Database Setup
Create a SQL Server Employee Table:
CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT,
    Department NVARCHAR(50),
    Salary DECIMAL(10,2)
);

 Step 2: Create a Generic Repository Class
Generic Repository Interface
public interface IRepository<T>
{
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    List<T> GetAll();
    T GetById(int id);
}

Implement Repository using ADO.NET
public class Repository<T> : IRepository<T> where T : class, new()
{
    private readonly string connectionString = ""your_connection_string"";

    public void Add(T entity) { /* Use ADO.NET to Insert into DB */ }
    public void Update(T entity) { /* Use ADO.NET to Update */ }
    public void Delete(int id) { /* Use ADO.NET to Delete */ }
    public List<T> GetAll() { /* Use ADO.NET to Read all */ return new List<T>(); }
    public T GetById(int id) { /* Use ADO.NET to get by ID */ return new T(); }
}

Step 3: Employee Model
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

Step 4: Use Delegates for Logging
 Define a Delegate
public delegate void LogHandler(string message);

Implement a Logger
public class Logger
{
    public static void WriteLog(string message) => Console.WriteLine($""[LOG] {message}"");
}

Add Logging to Repository
Modify Repository<T>:
public event LogHandler LogEvent;

public void Add(T entity)
{
    // Database insert logic here
    LogEvent?.Invoke($""Added new {typeof(T).Name}: {entity}"");
}

Step 5: Implement Business Logic in EmployeeService
public class EmployeeService
{
    private IRepository<Employee> _repository;
    public event LogHandler LogEvent;

    public EmployeeService(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public void AddEmployee(Employee emp)
    {
        _repository.Add(emp);
        LogEvent?.Invoke($""Employee {emp.Name} added successfully!"");
    }
}

 Step 6: Console Application (Main)
class Program
{
    static void Main()
    {
        IRepository<Employee> employeeRepo = new Repository<Employee>();
        EmployeeService service = new EmployeeService(employeeRepo);

        // Attach logger to event
        service.LogEvent += Logger.WriteLog;

        // Add Employee
        Employee emp = new Employee { Name = ""John Doe"", Age = 30, Department = ""IT"", Salary = 60000 };
        service.AddEmployee(emp);

        // Retrieve All Employees
        List<Employee> employees = employeeRepo.GetAll();
        foreach (var e in employees)
            Console.WriteLine($""{e.Id}: {e.Name}, {e.Age}, {e.Department}, {e.Salary}"");
    }
}

"