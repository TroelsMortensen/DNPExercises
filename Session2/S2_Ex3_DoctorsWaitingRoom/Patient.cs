namespace S2_Ex3_DoctorsWaitingRoom;

public class Patient
{
    private int numberInQueue;
    private readonly WaitingRoom waitingRoom;

    public Patient(WaitingRoom wr)
    {
        waitingRoom = wr;
        numberInQueue = wr.DrawNumber();
        wr.NumberChange += ReactToNumber;
    }

    private void ReactToNumber(int ticketNumber)
    {
        
    }
}