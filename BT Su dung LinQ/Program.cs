using BT_Su_dung_LinQ;

public class Program
{
    static void Main(string[] args)
    {
        // Danh sách xe Car
        List<Car> cars = new List<Car>()
        {
            new Car() { Name = "Toyota Camry",Description="nice", Price = 200000, Year = 2020, Manufacturer = "Toyota" },
            new Car() { Name = "Honda Civic",Description="nice", Price = 150000, Year = 2021, Manufacturer = "Honda" },
            new Car() { Name = "Ford Focus", Description = "nice", Price = 180000, Year = 2022, Manufacturer = "Ford" },
            new Car() { Name = "Mazda CX-5", Description = "nice", Price = 220000, Year = 2023, Manufacturer = "Mazda" },
        };

        Console.WriteLine("---- Xe Car co gia tu 100.000 den 250.000 ----");
        var filteredCars = cars.Where(c => c.Price >= 100000 && c.Price <= 250000);
        foreach (var car in filteredCars)
        {
            car.DisplayInfo();
        }

        Console.WriteLine("---- Xe Car sa xuat sau năm 1990 ----");
        filteredCars = cars.Where(c => c.Year > 1990);
        foreach (var car in filteredCars)
        {
            car.DisplayInfo();
        }

        Console.WriteLine("---- Nhom xe Car theo hang san xuat ----");
        var carGroups = cars.GroupBy(c => c.Manufacturer);
        foreach (var group in carGroups)
        {
            Console.WriteLine("Hang san xuat: {0}", group.Key);
            Console.WriteLine("Tong gia tri: {0}", group.Sum(c => c.Price));
        }

        // Danh sách xe Truck
        List<Truck> trucks = new List<Truck>()
        {
            new Truck() { Name = "Ford F-150", Description="nice" ,Price = 300000, Year = 2023, Company = "Ford" },
            new Truck() { Name = "Chevrolet Silverado", Description = "nice", Price = 280000, Year = 2022, Company = "General Motors" },
            new Truck() { Name = "RAM 1500",Description="nice", Price = 320000, Year = 2024, Company = "Stellantis" },
            new Truck() { Name = "Toyota Tundra", Description = "nice", Price = 290000, Year = 2022, Company = "Toyota" },
        };

        Console.WriteLine("---- Danh sach xe Truck moi nhat ----");
        var latestTrucks = trucks.OrderByDescending(t => t.Year);
        foreach (var truck in latestTrucks)
        {
            truck.DisplayInfo();
        }

        Console.WriteLine("---- Ten cong ty chu quan cua xe Truck ----");
        foreach (var truck in trucks)
        {
            Console.WriteLine("Ten xe: {0}", truck.Name);
            Console.WriteLine("Cong ty chu quan: {0}", truck.Company);
        }
    }
}



