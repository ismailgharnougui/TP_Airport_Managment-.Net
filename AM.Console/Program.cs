// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Service;

Console.WriteLine("Hello, World!");

////constructeur par défaut
//Plane plane = new Plane();
//plane.Capacity = 300;
//plane.ManufactureDate = DateTime.Now;
//plane.PlaneType = PlaneType.Boing;
////Constructeur paramétré
//Plane plane2 = new Plane(PlaneType.Boing,new DateTime(2018,2,12),200);

////initialiseur d'objet 
//Plane plane3 = new Plane
//{
//    Capacity = 100,
//    ManufactureDate = DateTime.Now,
//    PlaneType = PlaneType.Boing,
//    PlaneId = 2
//};
/*
Passenger p1 = new Passenger
{
    FullName.FirstName = "Test",
    LastName = "Test",
    EmailAddress = "test"
};
Staff s1 = new Staff
{ FirstName = "Test" };
Traveller t1 = new Traveller
{
    FirstName = "Test"
};
p1.PassengerType();
t1.PassengerType();
s1.PassengerType();
Console.WriteLine(p1.checkProfile("Test", "Test"));

*/
/*public static Staff captain = new Staff { FullName = new() { FirstName = "captain", LastName = "captain" } };

Flightmethod sf = new Flightmethod();
sf.Flights = TestData.listFlights;
Console.WriteLine("**** GetFlightDate*****");
foreach (var f in sf.GetFlightDate("Paris"))
{  Console.WriteLine(f); }

Console.WriteLine("****ShowFlightDetails***");
sf.ShowFlightDetails(TestData.BoingPlane);

Console.WriteLine("****DestinationGroupedFlights***");
sf.DestinationGroupedFlights();

Console.WriteLine("***SeniorTravellers**");
foreach (var item in sf.SeniorTravellers(TestData.flight1))

{
    Console.WriteLine( item);

}

*/



