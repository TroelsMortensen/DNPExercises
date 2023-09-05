using System.Text.Json;

namespace S2_Ex4_CarAndPredicates;

public class Car
{
    public string Color { get; set; }
    public int HorsePowers { get; set; }
    public int FuelEconomy { get; set; }
    public bool IsManualShift { get; set; }
    public int NumberOfDoors { get; set; }

    public override string ToString()
    {
        // this is a sneaky way to easily create a string representation of this object.
        return JsonSerializer.Serialize(this);
    }
}