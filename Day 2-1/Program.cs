int horizontal = 0;
int depth = 0;
List<string> input = new List<string>();
foreach (string line in File.ReadLines("input2.txt"))
	input.Add(line);
foreach (var i in input.Select((value, i) => new { i, value }))
{
	if (i.value.Split(' ')[0] == "forward")
		horizontal += int.Parse(i.value.Split(' ')[1]);
	else if (i.value.Split(' ')[0] == "up")
		depth -= int.Parse(i.value.Split(' ')[1]);
	else if (i.value.Split(' ')[0] == "down")
		depth += int.Parse(i.value.Split(' ')[1]);
}
Console.WriteLine(horizontal * depth);