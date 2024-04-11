public class GenericRepository<T>
{
    private Dictionary<string, T> _repositories;

    public GenericRepository()
    {
        _repositories = new Dictionary<string, T>();
    }

    public List<T> All
    {
        get { return _repositories.Values.ToList(); }
    }

    public int Count { get { return _repositories.Count; } }

    public void Insert(string key, T Item)
    {
        if (!_repositories.ContainsKey(key)) 
        {
        _repositories.Add(key, Item);
        }
    }

    public void Delete(string key)
    {
        _repositories.Remove(key);
    }

    public void PrintAll()
    {
        foreach (var item in All) 
        {
            Console.WriteLine(item);
        }
    }

}

