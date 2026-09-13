Weapon weapon = new Weapon(30, 30, 5, FireMode.Single);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("0 - Information");
    Console.WriteLine("1 - Shoot");
    Console.WriteLine("2 - Fire");
    Console.WriteLine("3 - Get Remaining Bullet Count");
    Console.WriteLine("4 - Reload");
    Console.WriteLine("5 - Change Fire Mode");
    Console.WriteLine("6 - Exit");
    Console.WriteLine("7 - Edit");
    Console.Write("Choose: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "0":
            Console.WriteLine($"Bullet Capacity: {weapon.BulletCapacity}");
            Console.WriteLine($"Bullet Count: {weapon.BulletCount}");
            Console.WriteLine($"Seconds To Empty: {weapon.SecondsToEmpty}");
            Console.WriteLine($"Fire Mode: {weapon.fireMode}");
            break;

        case "1":
            weapon.Shoot();
            break;

        case "2":
            weapon.Fire();
            break;

        case "3":
            Console.WriteLine($"Remaining bullets needed: {weapon.GetRemainBulletCount()}");
            break;

        case "4":
            weapon.Reload();
            Console.WriteLine("Weapon reloaded.");
            break;

        case "5":
            weapon.ChangeFireMode();
            Console.WriteLine($"Fire mode changed to: {weapon.fireMode}");
            break;

        case "6":
            Console.WriteLine("Program stopped.");
            return;

        case "7":
            Console.WriteLine();
            Console.WriteLine("T - Change Bullet Capacity");
            Console.WriteLine("S - Change Bullet Count");
            Console.WriteLine("D - Change Seconds To Empty");
            Console.Write("Choose: ");

            string editChoice = Console.ReadLine();

            switch (editChoice?.ToUpper())
            {
                case "T":
                    Console.Write("New capacity: ");
                    weapon.BulletCapacity = int.Parse(Console.ReadLine());
                    break;

                case "S":
                    Console.Write("New bullet count: ");
                    weapon.BulletCount = int.Parse(Console.ReadLine());
                    break;

                case "D":
                    Console.Write("New seconds: ");
                    weapon.SecondsToEmpty = double.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}