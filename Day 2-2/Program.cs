int aim = 0;
int horizontal = 0;
double depth = 0;

foreach (string line in File.ReadLines("input2.txt"))
{
	string[] split = line.Split(' ');
	if (split[0] == "forward")
	{
		horizontal += int.Parse(split[1]);
		depth += double.Parse(split[1]) * Convert.ToDouble(aim);
	}
	if (split[0] == "up") aim -= int.Parse(split[1]);
	if (split[0] == "down") aim += int.Parse(split[1]);

}
Console.WriteLine(horizontal * depth);