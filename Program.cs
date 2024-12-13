var left = new List<int>();
var right = new Dictionary<int, int>();
long similarity = 0;

var lines = File.ReadLines("../../../input");
foreach (var line in lines)
{
    var numbers = line.Split(" ");
    left.Add(int.Parse(numbers[0]));
    if (!right.TryAdd(int.Parse(numbers[3]), 1))
    {
        right[int.Parse(numbers[3])]++;
    }
}
for (int i = 0; i < left.Count; i++)
{
    var currentNumber = left[i];
    if (right.TryGetValue(currentNumber, out int count))
    {
        similarity += currentNumber * count;
    }
}
Console.WriteLine(similarity);