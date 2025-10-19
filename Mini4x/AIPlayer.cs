public class AIPlayer : Unit
{
    private static Random _rand = new Random();

    public AIPlayer(string name, char symbol, ConsoleColor color, int startX, int startY) 
        : base(name, symbol, color, startX, startY)
    {
    }

    public override void Move(int dx, int dy, Map map)
    {
        int randomDx = _rand.Next(-1, 2);
        int randomDy = _rand.Next(-1, 2);
        
        base.Move(randomDx, randomDy, map);
    }
}