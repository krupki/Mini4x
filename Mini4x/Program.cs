class Program
{
    static Map gameMap;
    static Player player;
    static AIPlayer aiPlayer;
    static bool gameRunning = true;

    static void Main(string[] args)
    {
        Console.Title = "Mini-4X C# Simulation";
        
        Initialize();

        while (gameRunning)
        {
            Render();
            GetInput();
            Update();
        }
    }

    static void Initialize()
    {
        gameMap = new Map(20, 10);
        
        player = new Player("Hero", '@', ConsoleColor.Yellow, 0, 0);
        aiPlayer = new AIPlayer("Goblin", 'G', ConsoleColor.Red, gameMap.Width - 1, gameMap.Height - 1);
    }

    static void Render()
    {
        Console.Clear();
        
        for (int y = 0; y < gameMap.Height; y++)
        {
            for (int x = 0; x < gameMap.Width; x++)
            {
                Tile tile = gameMap.Tiles[x, y];
                Console.ForegroundColor = tile.Color;
                Console.Write(tile.Symbol + " ");

                bool unitOnTile = false;

                if (player.X == x && player.Y == y)
                {
                    Console.SetCursorPosition(x * 2, y); 
                    Console.ForegroundColor = player.Color;
                    Console.Write(player.Symbol);
                    unitOnTile = true;
                }
                
                if (aiPlayer.X == x && aiPlayer.Y == y)
                {
                    if (!unitOnTile) 
                    {
                        Console.SetCursorPosition(x * 2, y);
                        Console.ForegroundColor = aiPlayer.Color;
                        Console.Write(aiPlayer.Symbol);
                    }
                }
            }
            Console.WriteLine(); 
        }
        Console.ResetColor();
        Console.WriteLine($"\n{player.Name} @ ({player.X},{player.Y}) | {aiPlayer.Name} @ ({aiPlayer.X},{aiPlayer.Y})");
        Console.WriteLine("Bewege dich mit Pfeiltasten, 'Q' zum Beenden.");
    }

    static void GetInput()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
        
        int dx = 0, dy = 0;

        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                dy = -1;
                break;
            case ConsoleKey.DownArrow:
                dy = 1;
                break;
            case ConsoleKey.LeftArrow:
                dx = -1;
                break;
            case ConsoleKey.RightArrow:
                dx = 1;
                break;
            case ConsoleKey.Q:
                gameRunning = false;
                break;
            default:
                Console.WriteLine("\nUngültige Eingabe. Bitte Pfeiltasten benutzen oder 'Q' drücken.");

                return;
        }
        
        player.Move(dx, dy, gameMap);
    }

    static void Update()
    {
        aiPlayer.Move(0, 0, gameMap);
    }
}