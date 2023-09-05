// See https://aka.ms/new-console-template for more information

using S2_Ex3_DoctorsWaitingRoom;

Console.WriteLine("Doctor's waiting room example!");

WaitingRoom wr = new WaitingRoom();
Patient p1 = new(wr);
Patient p2 = new(wr);
Patient p3 = new(wr);
Patient p4 = new(wr);
Patient p5 = new(wr);

wr.RunWaitingRoom();