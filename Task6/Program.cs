List<bool> values = new List<bool>{ true, true, true };
var allTrue=values.All(e => e == true);
Console.WriteLine("Are all the values in the list true? " + allTrue);