public class Bullet : Projectile
{
    public Bullet(int damage) : base(damage) { }

    public override void HitTarget(IDamageable target)
    {
        Console.WriteLine("Куля влучила в ціль.");
        target.TakeDamage(damage);
    }
}