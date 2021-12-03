List<string> input = new List<string>();
foreach (string line in File.ReadLines("input.txt"))
    input.Add(line);

string gamma = "";
string epsilon = "";
List<int> gammaRaw = new List<int>();
foreach (char meme in input[0])
    gammaRaw.Add(0);

foreach (string line in input)
{
    int count = 0;
    string[] lineSplit = line.Split();
    foreach (char c in lineSplit[count])
    {
        gammaRaw[count] = int.Parse(gammaRaw[count].ToString()) + int.Parse(c.ToString());
        count++;
    } 
}

foreach (int g in gammaRaw)
{
    if (g > 499)
    {
        gamma += 1;
        epsilon += 0;
    }
        
    else if (g < 500)
    {
        gamma += 0;
        epsilon += 1;
    }   
}

Console.Write(Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2));
    

