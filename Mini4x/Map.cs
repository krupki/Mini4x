public class Map
{
    public Tile[,] Tiles { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Map(int width, int height)
    {
        Width = width;
        Height = height;
        Tiles = new Tile[width, height];
        GenerateMap();
    }

    private void GenerateMap()
    {
        Random rand = new Random();
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                int r = rand.Next(10);
                if (r < 1)
                    Tiles[x, y] = new Tile(TileType.Water);
                else if (r < 3)
                    Tiles[x, y] = new Tile(TileType.Forest);
                else
                    Tiles[x, y] = new Tile(TileType.Grassland);
            }
        }
    }
}