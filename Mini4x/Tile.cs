public enum TileType
{
    Grassland,
    Water,
    Forest,
    Mountain
}

public class Tile
{
    public TileType Type { get; set; }
    public ConsoleColor Color { get; private set; }
    public char Symbol { get; private set; }

    public Tile(TileType type)
    {
        Type = type;
        
        switch (type)
        {
            case TileType.Grassland:
                Symbol = '.';
                Color = ConsoleColor.Green;
                break;
            case TileType.Water:
                Symbol = '~';
                Color = ConsoleColor.Blue;
                break;
            case TileType.Forest:
                Symbol = 'T';
                Color = ConsoleColor.DarkGreen;
                break;
            case TileType.Mountain:
                Symbol = '^';
                Color = ConsoleColor.Gray;
                break;
        }
    }
}