internal class ComputerRepository : GenericRepository<Computer>
{
    public ComputerRepository()
    {

    }

    public void Insert(string SerialNo, Computer aComputer)
    {
        Insert(SerialNo, aComputer);
    }

    public void Delete(string  SerialNo)
    {
        Delete(SerialNo);
    }
}
