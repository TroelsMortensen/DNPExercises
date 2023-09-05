namespace S2_Ex2_TrafficLight;

public class TrafficLight
{
    public Action<string> OnLightChange { get; set; }
    private string[] colors = { "GREEN", "YELLOW", "RED" };

    public void RunTrafficLight()
    {
        for (int i = 0; i < 12; i++)
        {
            int idx = i % colors.Length;
            string currentColor = colors[idx];
            Console.WriteLine("Light is " + currentColor);
            OnLightChange?.Invoke(currentColor);
            Thread.Sleep(1000);
        }
    }
}