namespace ConsoleAppAutobazar
{
    public class Customer
    {
        public Customer(string firstName, string lastName, decimal money)
        {
            FirstName = firstName;
            LastName = lastName;
            Money = money;

            OwnedCars = new List<Car>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Money { get; set; }
        public List<Car> OwnedCars { get; set; }

        public void BuyCar(Car car)
        {
            if (Money >= car.Price && car.IsAvailable == true)
            {
                OwnedCars.Add(car);

                car.IsAvailable = false;

                Money = Money - car.Price;
                Money -= car.Price;
            }
            else
            {
                Console.WriteLine("Nemáš dostatek peněz bro");
            }
        }

        public decimal GetAveragePriceOfOwnedCars()
        {
            /*
            decimal total = 0;
            foreach (Car car in OwnedCars)
            {
                total += car.Price;
            }
            decimal average = total / OwnedCars.Count;
            */

            decimal averagePrice = OwnedCars.Average(car => car.Price);
            return averagePrice;
        }
    }
}
