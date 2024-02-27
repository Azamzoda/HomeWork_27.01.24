List<string> remove = new List<string>(){"Hello", "world","hi", "how are ypo?"};
System.Console.WriteLine();
foreach (var item in remove)
{
    System.Console.WriteLine(item);
}
    System.Console.WriteLine("_________________________");
remove.Remove("Hello");
remove.RemoveAt(2);
System.Console.WriteLine();
foreach (var item in remove)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("_______________________");