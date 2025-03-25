using OnlineOrdering;
using OnlineOrdering.Enums;
using OnlineOrdering.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var _random = new Random();
        
        var customers = new List<ICustomer>
        {
            new Customer("Intel", new Address("2200 Mission College Blvd", "Santa Clara", "California", Country.UnitedStates )),
            new Customer("AMD", new Address("2485 Augustine Dr", "Santa Clara", "California", Country.UnitedStates )),
            new Customer("NVIDIA", new Address("2788 San Tomas Expressway", "Santa Clara", "California", Country.UnitedStates )),
            new Customer("Lenovo", new Address("Building 2, No.10 Courtyard Xibeiwang East Road", "Beijing", "Haidian District", Country.China )),
            new Customer("Samsung", new Address("129 Samsung-ro", "Gyeonggi", "Suwon", Country.SouthKorea ))
        };

        var products = new List<IProduct>();

        for (var index = 0; index < 20; index++)
        {
            var cost = _random.Next(100, 1500) + new decimal(_random.NextDouble());

            products.Add(new Product( $"PC-{_random.Next(1000, 100000):000000}",$"Processor PR_D-{_random.Next(200, 1000):000#-50}", cost, _random.Next(1,11)));
        }

        var orders = customers.Select(customer => new Order(customer)).Cast<IOrder>().ToList();

        foreach (var order in orders)
        {
            for (var index = 0; index < _random.Next(5, 11); index++)
            {
                while (true)
                {
                    var product = products[_random.Next(0, 19)];
                    
                    if (order.Items.Contains(product))
                        continue;
                    
                    order.AddItem(product);
                    break;
                }
            }
        }

        Console.Clear();

        foreach (var order in orders)
        {
            Console.WriteLine(order.ShippingLabel);
            Console.WriteLine(order.PackingLabel);
            Console.WriteLine(order.Invoice);
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order.TotalCost:#,##0.00}" );
            Console.WriteLine();
        }
    }
}