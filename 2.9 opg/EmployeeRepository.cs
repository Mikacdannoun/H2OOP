
public class EmployeeRepository : GenericRepository<Employee>
{
    public EmployeeRepository()
    {

    }

    public void Insert(string name, Employee anEmployee)
    {
        Insert(name, anEmployee);
    }

    public void Delete(string name)
    {
        Delete(name);
    }
}