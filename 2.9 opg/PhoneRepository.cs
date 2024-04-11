internal class PhoneRepository : GenericRepository<Phone>
{
    public PhoneRepository()
    {

    }

    public void Insert(string brand, Employee aPhone)
    {
        Insert(brand, aPhone);
    }

    public void Delete(string name)
    {
        Delete(name);
    }
}