public class Weapon(string name, int weight, int damage, int durability, int hands, string dmgType)
    : Item(name, weight)
{
    protected int _damage = damage;
    private int _durability = durability;
    private int _hands = hands;
    private string _dmgType = dmgType;

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Gör en Basic Attack
    public virtual int BasicAttack()
    {
        int randomDmg = Random.Shared.Next(_damage / 2, _damage);
        Console.WriteLine("You swing your weapon for " + randomDmg);
        return randomDmg;
    }

    public virtual int SpecialAttack()
    {
        int randomDmg = Random.Shared.Next(_damage / 4, _damage*2);
        Console.WriteLine("You try to swing your weapon extra hard for " + randomDmg);
        return randomDmg;
    }
}
