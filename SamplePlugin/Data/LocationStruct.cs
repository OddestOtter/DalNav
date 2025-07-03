namespace SamplePlugin.Data;
public class Location
{
    public string Name { get; set; }
    public List<Connection> Connections { get; set; }

    public Location(string name)
    {
        Name = name;
        Connections = new List<Connection>();
    }
}

public class Connection
{
    public string Destination { get; set; }
    public string Type { get; set; }
    public (float X, float Y) Coordinates { get; set; }
    public string RelativeDirection { get; set; } // New property for relative direction

    public Connection(string destination, string type, (float X, float Y) coordinates, string relativeDirection)
    {
        Destination = destination;
        Type = type;
        Coordinates = coordinates;
        RelativeDirection = relativeDirection;
    }
}