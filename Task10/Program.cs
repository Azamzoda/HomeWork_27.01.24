List<int> randomNumbers = new List<int>();
Random random = new Random();
for (int i = 1; i < 20; i++)
{
    randomNumbers.Add(random.Next(1,20));
}
foreach (var item in randomNumbers)
{
    System.Console.Write(" " + item);
}