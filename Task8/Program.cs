List<string> find = new List<string>(){"Salmon", "Muhammad","Alijon","GilDarTabaqNuqraXurosonBegim","Sunatullo","Bob"};
var  f = find.Find(e => e.Length == 3);
System.Console.WriteLine(f);
foreach (var item in find.FindAll(e => e.Length > 8))
{
    System.Console.Write("  " + item);
}