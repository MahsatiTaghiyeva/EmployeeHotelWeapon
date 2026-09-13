public class Weapon
{
    public int BulletCapacity;
    public int BulletCount;
    public double SecondsToEmpty;
    public FireMode fireMode;
    public void Shoot()
    {
        if(BulletCount>0){
            BulletCount--;
            Console.WriteLine("1 bullet fired.");
        }
        else 
            Console.WriteLine("Can't shoot! No bullets left!");
    }
    public void Fire()
    {
        if(BulletCount == 0){
            System.Console.WriteLine("Can't fire! No bullets left!");
            return;}
        Console.WriteLine($"Firing {BulletCount} bullets...");
        BulletCount = 0;
        Console.WriteLine($"Magazine emptied in {SecondsToEmpty} seconds.");
        
    }
    public int GetRemainBulletCount()
    {
        return BulletCapacity - BulletCount;
    }
    public void Reload()
    {
        BulletCount += GetRemainBulletCount();
    }
    public void ChangeFireMode()
    {
        if (fireMode == FireMode.Automatic)
            fireMode = FireMode.Single;
        else 
            fireMode = FireMode.Automatic;
    }
    public Weapon(int bulletCapacity, int bulletCount, double secondsToEmpty, FireMode fireMode)
{
    BulletCapacity = bulletCapacity;
    BulletCount = bulletCount;
    SecondsToEmpty = secondsToEmpty;
    this.fireMode = fireMode;
}
}