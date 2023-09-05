namespace S2_Ex3_DoctorsWaitingRoom;

public class WaitingRoom
{
    public Action<int> NumberChange { get; set; }

    private int currentNumber;
    private int ticketCount;

    public void RunWaitingRoom()
    {
        while (currentNumber < ticketCount)
        {
            Thread.Sleep(1000);
            currentNumber++;
            Console.WriteLine($"Ding! It is now patient number {currentNumber}'s turn.");
            NumberChange?.Invoke(currentNumber);
        }
    }

    public int DrawNumber()
    {
        ticketCount++;
        return ticketCount;
    }
}