List<string> input = new List<string>();
foreach (string line in File.ReadLines("input.txt"))
    input.Add(line);

string generator = "";
string scrubber = "";
List<int> inputTotal = new List<int>();
foreach (char meme in input[0])
    inputTotal.Add(0);

foreach (string line in input)
{
    int count = 0;
    string[] lineSplit = line.Split();
    foreach (char c in lineSplit[count])
    {
        inputTotal[count] = int.Parse(inputTotal[count].ToString()) + int.Parse(c.ToString());
        count++;
    }
}

foreach (int g in inputTotal)
{
    if (g > 499)
    {
        generator += 1;
        scrubber += 0;
    }

    else if (g < 500)
    {
        generator += 0;
        scrubber += 1;
    }
}

List<string> generatorList = new List<string>();
List<string> scrubberList = new List<string>();
string scrubberRating = "";
string generatorRating = "";

for (int y = 0; y < input.Count; y++)
{
    for (int i = 0; i < input[y].Length; i++)
    {
        if (input[y][i] == generator[i])
            

        generatorList[y] = "NaN";
    }
}

// else if (line[i] == scrubber[i]) continue;

//Console.Write(Convert.ToInt32(generator, 2) * Convert.ToInt32(scrubber, 2));
foreach (string generatorr in generatorList)
{
    if (generatorr != "NaN")
        Console.WriteLine(generatorr);
}



