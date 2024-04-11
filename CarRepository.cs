public class CarRepository : GenericRepository<Car>
{
    public CarRepository()
    {

    }

    public void Insert(string licensePlate, Car aCar)
    {
        Insert(licensePlate, aCar);
    }

    public void Delete(string licensePlate)
    {
        Delete(licensePlate);
    }
}