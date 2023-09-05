namespace S2_Ex3_DoctorsWaitingRoom;

public class WaitingRoom
{
    public Action<int> NumberChange { get; set; }

    private int currentNumber;
    private int ticketCount;

    public void RunWaitingRoom()
    {
    }

    public int DrawNumber()
    {
        ticketCount++;
        return ticketCount;
    }
}