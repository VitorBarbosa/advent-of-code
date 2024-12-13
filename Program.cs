var left = new List<int>();
var right = new List<int>();
long distance = 0;

var lines = File.ReadLines("../../../input");
foreach (var line in lines) {
    var numbers = line.Split(" ");
    left.Add(int.Parse(numbers[0]));
    right.Add(int.Parse(numbers[3]));
}
left.Sort();
right.Sort();
for (int i = 0; i < left.Count; i++)
{
    distance += Math.Abs(left[i] - right[i]);
}
Console.WriteLine(distance);