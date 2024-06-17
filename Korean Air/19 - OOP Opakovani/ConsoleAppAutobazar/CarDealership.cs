namespace ConsoleAppAutobazar
{
    public class CarDealership
    {
        public CarDealership(string name, string city)
        {
            Name = name;
            City = city;

            ListedCars = new List<Car>();
        }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Car> ListedCars { get; set; }


        public List<Car> GetCarsByBrand(string brand)
        {
            return ListedCars.Where(x => x.Brand == brand).ToList();
        }

        public List<Car> GetTopExpensiveCars(int count)
        {
            return ListedCars
                .OrderByDescending(car => car.Price)
                .Take(count)
                .ToList();
        }

        public Car GetTheMostExpensiveCar()
        {
            Car mostExpensiveCar = ListedCars.MaxBy(x => x.Price);
            return mostExpensiveCar;
        }
    }
}
