class Program
{
    static void Main()
    {
        Bullet bullet = new Bullet(30);

        Enemy enemy = new Enemy(50);
        BreakableWall wall = new BreakableWall(40);

        Console.WriteLine("=== Початок атаки ===");
        bullet.HitTarget(enemy);
        bullet.HitTarget(wall);
    }
}