namespace S2_Ex2_TrafficLight;

public class Pedestrian
{
    private int id;

    public Pedestrian(int id, TrafficLight tl)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }

    private void ReactToLight(string color)
    {
        string result = $"Pedestrian {id} ";
        switch (color)
        {
            case "GREEN":
                result += " waits to cross";
                break;
            case "YELLOW":
                result += " stretches and gets ready";
                break;
            case "RED":
                result += " powerwalks across";
                break;
        }

        Console.WriteLine(result);
    }
}