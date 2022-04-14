using Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
// Load the trucks in the file
Truck.AddFromFile("camions.txt");
// Display them
Truck.Display();
// Add a new truck
new Truck("Iveco", "Stralis", new DateTime(2006, 1, 1), 310, 36540);
// Display trucks satisfying a predicate
Console.WriteLine("Trucks whose selling price is under 30,000€");
Truck.Display(truck => truck.SellPrice < 30000);
// Remove a truck
Truck.RemoveAt(4);
// Save them to a new text file
Truck.SaveToFile("camions_AS_2.txt");