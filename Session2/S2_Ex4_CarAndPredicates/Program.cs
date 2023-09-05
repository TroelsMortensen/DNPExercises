// See https://aka.ms/new-console-template for more information

using S2_Ex4_CarAndPredicates;

Console.WriteLine("Hello, World!");
List<Car> cars = GenerateCars();

Console.WriteLine("--- Finding blue cars ---");
List<Car> blueCars = FindByColor(cars, "blue");
PrintListOfCars(blueCars);

Console.WriteLine("--- Finding red or green cars ---");
PrintListOfCars(FindByEitherColor(cars, "red", "green"));

void PrintListOfCars(List<Car> list)
{
    foreach (Car car in list)
    {
        Console.WriteLine(car);
    }
}


// methods:

List<Car> GenerateCars()
{
    List<Car> generatedCars = new();
    string[] colors = new[] { "red", "blue", "green", "yellow", "black" };
    Random random = new Random(0); // hardcoded seed should give the same cars each time we run the program
    for (int i = 0; i < 20; i++)
    {
        string color = colors[random.Next(colors.Length)];
        int horsepowers = random.Next(80, 400);
        int fuelEconomy = random.Next(10, 30);
        bool isManual = random.Next(1) == 0;
        int doors = random.Next(3, 6);
        generatedCars.Add(
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

    return generatedCars;
}

List<Car> FindByColor(List<Car> cars, string color)
{
    IEnumerable<Car> result = cars.Where(car => car.Color.Equals(color));
    List<Car> list = result.ToList();
    return list;
}

List<Car> FindByEitherColor(List<Car> cars, string firstColor, string secondColor)
{
    return cars
        .Where(car => car.Color.Equals(firstColor) || car.Color.Equals(secondColor))
        .ToList();
}