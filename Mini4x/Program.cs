// Program.cs
class Program
{
    static Map gameMap;
    static bool gameRunning = true;

    static void Main(string[] args)
    {
        Console.Title = "Mini-4X C# Simulation";
        
        // 1. Spiel initialisieren
        Initialize();

        // 2. Die Spielschleife (Game Loop)
        while (gameRunning)
        {
            // 2a. Karte zeichnen
            Render();

            // 2b. Auf Spieler-Input warten
            GetInput();

            // 2c. Spiel-Logik aktualisieren (noch leer)
            Update();
        }
    }

    static void Initialize()
    {
        // Erstelle eine kleine Karte (z.B. 20x10)
        gameMap = new Map(20, 10);
    }

    static void Render()
    {
        Console.Clear(); // Bildschirm löschen für Neuzeichnung
        
        for (int y = 0; y < gameMap.Height; y++)
        {
            for (int x = 0; x < gameMap.Width; x++)
            {
                Tile tile = gameMap.Tiles[x, y];
                Console.ForegroundColor = tile.Color;
                Console.Write(tile.Symbol + " "); // Schreibe das Symbol der Kachel
            }
            Console.WriteLine(); // Nächste Zeile
        }
        Console.ResetColor();
        Console.WriteLine("\nDrücke 'Q' zum Beenden.");
    }

    static void GetInput()
    {
        // Warte auf einen Tastendruck
        ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true = Taste nicht anzeigen
        if (keyInfo.Key == ConsoleKey.Q)
        {
            gameRunning = false;
        }
    }

    static void Update()
    {
        // Hier kommt später die KI-Logik, Ressourcen-Berechnung etc.
        // Fürs Erste bleibt das leer.
    }
}