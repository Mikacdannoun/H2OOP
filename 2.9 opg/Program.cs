
//CarRepository cars = new CarRepository();

//Car c1 = new Car("AB 12 345", 80000);
//Car c2 = new Car("CD 34 456", 65000);
//Car c3 = new Car("EF 56 567", 28000);

//cars.Insert(c1.LicensePlate, c1);
//cars.Insert(c2.LicensePlate, c2);
//cars.Insert(c3.LicensePlate, c3);


//EmployeeRepository employees = new EmployeeRepository();

//Employee e1 = new Employee("Allan", 1962);
//Employee e2 = new Employee("Bente", 1975);
//Employee e3 = new Employee("Carlo", 1973);

//employees.Insert(e1.Name, e1);
//employees.Insert(e2.Name, e2);
//employees.Insert(e3.Name, e3);


using System;

//Car Repository
GenericRepository<Car> carRepository = new GenericRepository<Car>();

Car c1 = new Car("AB 12 345", 80000);
Car c2 = new Car("CD 34 456", 65000);
Car c3 = new Car("EF 56 567", 28000);

carRepository.Insert(c1.LicensePlate, c1);
carRepository.Insert(c2.LicensePlate, c2);
carRepository.Insert(c3.LicensePlate, c3);

Console.WriteLine($"Number of cars in the repository: {carRepository.Count}");
carRepository.PrintAll();
Console.WriteLine();

//Computer Repository
GenericRepository<Computer> computerRepository = new GenericRepository<Computer>();

Computer co1 = new Computer("BsQUe5e93t", "Rip");
Computer co2 = new Computer("BsQ<FFe5et", "Rap");
Computer co3 = new Computer("BsdnQUe5et", "Rup");

computerRepository.Insert(co1.SerialNo, co1);
computerRepository.Insert(co2.SerialNo, co2);
computerRepository.Insert(co3.SerialNo, co3);

Console.WriteLine($"Number of computers in the repository: {computerRepository.Count}");
computerRepository.PrintAll();
Console.WriteLine();

//Employee Repository
GenericRepository<Employee> employeeRepository = new GenericRepository<Employee>();

Employee e1 = new Employee("Hans", 1981);
Employee e2 = new Employee("Margrethe", 1977);
Employee e3 = new Employee("Gerner", 1990);

employeeRepository.Insert(e1.Name, e1);
employeeRepository.Insert(e2.Name, e2);
employeeRepository.Insert(e3.Name, e3);

Console.WriteLine($"Number of employees in the repository: {employeeRepository.Count}");
employeeRepository.PrintAll();

Console.WriteLine();

//Phone Repository
GenericRepository<Phone> phoneRepository = new GenericRepository<Phone>();

Phone p1 = new Phone("Iphone", 3000);
Phone p2 = new Phone("Samsung", 200);
Phone p3 = new Phone("Huawei", 1500);

phoneRepository.Insert(p1.Brand, p1);
phoneRepository.Insert(p2.Brand, p2);
phoneRepository.Insert(p3.Brand, p3);

Console.WriteLine($"Number of phones in the repository: {phoneRepository.Count}");
phoneRepository.PrintAll();

Console.WriteLine();