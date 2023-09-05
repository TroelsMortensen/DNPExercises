// See https://aka.ms/new-console-template for more information

using S2_Ex4_CarAndPredicates;

Console.WriteLine("Hello, World!");
List<Car> cars = GenerateCars();



// methods:

List<Car> GenerateCars()
{
    List<Car> cars = new();
    string[] colors = new[] { "red", "blue", "green", "yellow", "black" };
    Random random = new Random(0); // hardcoded seed should give the same cars each time we run the program
    for (int i = 0; i < 10; i++)
    {
        string color = colors[random.Next(colors.Length)];
        int horsepowers = random.Next(80, 400);
        int fuelEconomy = random.Next(10, 30);
        bool isManual = random.Next(1) == 0;
        int doors = random.Next(3, 6);
        cars.Add(
            new Car
            {
                FuelEconomy = fuelEconomy,
                IsManualShift = isManual,
                Color = color,
                HorsePowers = horsepowers,
                NumberOfDoors = doors
            }
        );
    }
    
    return cars;
}

