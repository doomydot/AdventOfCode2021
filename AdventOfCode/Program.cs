
int count = -1; int last = 0;
foreach (string line in System.IO.File.ReadLines("input1.txt"))
{
	if (int.Parse(line) > last) count++;
	last = int.Parse(line);
}
Console.Write(count);