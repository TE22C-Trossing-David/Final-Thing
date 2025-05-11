public class Knight : Enemy
{
    private string name = "Knight";
    private int hp = 40;

    public Knight()
    {
        _name = name;
        _hp = hp;
    }

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public override void Attack()
    {
        Console.WriteLine("The Knight swings his sword at you");
    }
}
