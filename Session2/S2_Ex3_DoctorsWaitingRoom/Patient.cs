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
        Console.WriteLine($"Patient with number {numberInQueue} looks up..");
        if (ticketNumber == numberInQueue)
        {
            Console.WriteLine($"Patient with number {numberInQueue} gets up and walks to the doctor's office");
            waitingRoom.NumberChange -= ReactToNumber;
        }
        else
        {
            Console.WriteLine($"Patient with number {numberInQueue} goes back to play with their phone");
        }
    }
}