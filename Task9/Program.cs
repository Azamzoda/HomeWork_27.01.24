List<string> names = new List<string>(){"Salomon", "Muhammad"};
foreach (var item in names)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine();
System.Console.WriteLine("\n__________________________________________________");
names.Add("Mansur");
foreach (var item in names)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine();
System.Console.WriteLine("\n__________________________________________________");
names.AddRange(new List<string>() {"GilDarTabaqNuqraXurosonBegim", "Alishoh"});
foreach (var item in names)
{
     System.Console.Write(item+" ");
}
names.Insert(3,"Alijon");
foreach (var item in names)
{
    System.Console.Write(item+" ");
}

System.Console.WriteLine("\n__________________________________________________");
System.Console.WriteLine();

names.InsertRange(5, new List<string>() {"Mike","Jackson"});
foreach (var item in names)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine("\n__________________________________________________");
System.Console.WriteLine();