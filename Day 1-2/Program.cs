List<int> input = new List<int>();
foreach (string line in File.ReadLines("input1.txt"))
	input.Add(int.Parse(line));

List<int> sums = new List<int>();
foreach (var i in input.Select((value, i) => new { i, value }))
{
	if (i.i < input.Count - 2)
	{
		int sum = 0;
		sum = input[i.i] + input[i.i + 1] + input[i.i + 2];
		sums.Add(sum);
	}
}
int incrementationCount = 0;
Console.WriteLine(sums.Count);

foreach (var i in sums.Select((value, i) => new { i, value }))
{
	if (i.i < sums.Count - 1)
	{
		if (sums[i.i] < sums[i.i + 1])
			incrementationCount++;
	}
}
Console.WriteLine(incrementationCount);
