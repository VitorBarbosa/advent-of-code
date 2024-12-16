static bool isSafeReport(int[] numbers)
{
    bool isIncreasing = numbers[0] < numbers[1];
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if ((isIncreasing && numbers[i] >= numbers[i + 1])
        || (!isIncreasing && numbers[i] <= numbers[i + 1]))
        {
            return false;
        }
        var difference = Math.Abs(numbers[i] - numbers[i + 1]);
        switch (difference)
        {
            case var _ when difference is 0 or > 3:
                return false;
            case var _ when difference is >= 1 and <= 3:

                break;
        }
    }
    return true;
}

long safeReports = 0;

var lines = File.ReadLines("../../../day2/input_day2");
foreach (var line in lines)
{
    var numbers = line.Split(" ").Select(int.Parse).ToArray();
    if (isSafeReport(numbers))
        safeReports++;
}

Console.WriteLine($"Result: {safeReports}");