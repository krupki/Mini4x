public class Unit
{
    public string Name { get; set; }
    public char Symbol { get; set; }
    public ConsoleColor Color { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Unit(string name, char symbol, ConsoleColor color, int startX, int startY)
    {
        Name = name;
        Symbol = symbol;
        Color = color;
        X = startX;
        Y = startY;
    }
    public virtual void Move(int dx, int dy, Map map)
    {
        int newX = X + dx;
        int newY = Y + dy;
        
        if (newX >= 0 && newX < map.Width &&
            newY >= 0 && newY < map.Height)
        {
            X = newX;
            Y = newY;
        }
        else
        {
            Console.WriteLine($"\n{Name} kann sich nicht außerhalb der Karte bewegen.");
        }
    }
}