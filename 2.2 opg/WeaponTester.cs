
public class WeaponTester
{
    public void Run()
    {
        Console.WriteLine("Running Axe Test...");
        TestAxe();

        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Running Wand Test...");
        TestWand();
    }

    private void TestWand()
    {
        Wand myWand = new Wand("Dragonhair");
        UseWand(myWand, 5);

        myWand.IsEnchanted = true;
        Console.WriteLine("Enchanted Wand...");
        UseWand(myWand, 5);

        myWand.IsEnchanted = false;
        Console.WriteLine("Disenchanted Wand...");
        UseWand(myWand, 5);
    }

    private void TestAxe()
    {
        Axe myaxe = new Axe("redeemer");
        UseAxe(myaxe, 10);

        myaxe.Sharpen();
        Console.WriteLine("sharpened axe...");
        UseAxe(myaxe, 10);
    }

    private void UseWand(Wand theWand, int noOfUses)
    {
        Console.WriteLine($"Testing Wand {theWand.Description}");
        for (int i = 0; i < noOfUses; i++)
        {
            Console.WriteLine($"Damage dealt by {theWand.Description}: {theWand.DamageFromWand()}");
        }
        Console.WriteLine();
    }

    private void UseAxe(Axe theAxe, int noOfUses)
    {
        Console.WriteLine($"Testing Axe {theAxe.Description}");
        for (int i = 0; i < noOfUses; i++)
        {
            Console.WriteLine($"Damage dealt by {theAxe.Description}: {theAxe.DamageFromAxe()}");
        }
        Console.WriteLine();
    }
}
