using System.Security;

namespace ConsoleAppAutobazar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarDealership carDealership = new CarDealership("AutoJarov", "Praha");

            Car car = new Car("XYZ", "Porsche", 1_500_000, true);
            Car car2 = new Car("ABC", "Porsche", 4_500_000, true);
            Car car3 = new Car("GJG", "Porsche", 3_500_000, true);
            Car car4 = new Car("M3", "BMW", 4_000_000, true);
            Car car5 = new Car("X5", "BMW", 1_500_000, true);

            carDealership.ListedCars.Add(car);
            carDealership.ListedCars.Add(car2);
            carDealership.ListedCars.Add(car3);
            carDealership.ListedCars.Add(car4);
            carDealership.ListedCars.Add(car5);


            /* GET TOP EXPENSIVE CARS*/

            List<Car> topExpensiveCars = carDealership.GetTopExpensiveCars(5);

            /* GET CARS BY BRAND */
            string brand = Console.ReadLine();

            List<Car> filteredCars = carDealership.GetCarsByBrand(brand);

            foreach (Car currentCar in filteredCars)
            {
                Console.WriteLine(currentCar.Price);
            }


            /* GET MOST EXPENSIVE CAR */
            Car mostExpensiveCar;
            mostExpensiveCar = carDealership.GetTheMostExpensiveCar();
            Console.WriteLine($"Nejdražší auto: {mostExpensiveCar.Model} {mostExpensiveCar.Brand} {mostExpensiveCar.Price} Kč");

            Customer customer = new Customer("Filip", "Turek", 5_000_000);
            customer.BuyCar(mostExpensiveCar);
        }
    }
}
