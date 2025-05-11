public class Goblin : Enemy
{
    private string name = "Goblin";
    private int hp = 10;

    public Goblin()
    {
        _name = "Goblin";
        _hp = 10;
    }

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public override void Attack()
    {
        Console.WriteLine("The Goblin throws a rock");
    }
}
