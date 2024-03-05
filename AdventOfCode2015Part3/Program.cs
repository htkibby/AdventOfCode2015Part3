using AdventOfCode2015Part3;

string filePath =@"AdventOfCode2015Part3\\Directions.txt";
StreamReader directions = new(filePath);
List<Coordinate> coordinates = [];

while (!directions.EndOfStream)
{
    int x = 0;
    int y = 0;
    string cardinalDirections = directions.ReadLine();

    foreach (char direction in cardinalDirections)
    {
        if (direction == '^')
        {
            coordinates.Add(new Coordinate { x = x, y = y++ });
        }
        else if (direction == 'v')
        {
            coordinates.Add(new Coordinate { x = x, y = y-- });
        }
        else if (direction == '>')
        {
            coordinates.Add(new Coordinate { x = x++, y = y });
        }
        else if (direction == '<') 
        {
            coordinates.Add(new Coordinate { x = x--, y = y });
        }
    }
}

List<Coordinate> distinctCoordinates = coordinates.DistinctBy(c => new {c.x, c.y}).ToList();

Console.WriteLine($"{distinctCoordinates.Count}");