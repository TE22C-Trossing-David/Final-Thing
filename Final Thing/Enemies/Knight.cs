public class Knight : Enemy
{

    public Knight()
    {

        _name = "Knight";
        _hp = 40;
    }

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public override void Attack()
    {
        Console.WriteLine("The Knight swings his sword at you");
    }
}
