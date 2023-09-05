// See https://aka.ms/new-console-template for more information

using S2_Ex2_TrafficLight;

TrafficLight tl = new();
new Car(tl, 1);
new Car(tl, 2);
new Car(tl, 3);
tl.RunTrafficLight();