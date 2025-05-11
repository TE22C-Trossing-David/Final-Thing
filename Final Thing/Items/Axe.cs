public class Axe(string name, int weight, int damage, int durability, int hands, string dmgType)
    : Weapon(name, weight, damage, durability, hands, dmgType)
{
    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Kalkulerar damagen för Axe Swing attacken
    public override int BasicAttack()
    {
        int randomDmg = Random.Shared.Next(_damage / 2, _damage);
        Console.WriteLine("You swing your axe for " + randomDmg);
        return _damage;
    }

    //Kalkulerar damagen för Cleave attacken med weapons damage som variabel
    public int Cleave()
    {
        int randomDmg = Random.Shared.Next(_damage / 4, _damage * 2);
        if (randomDmg < _damage / 2.5)
        {
            Console.WriteLine("You swing and miss");
            randomDmg = 0;
        }
        else
        {
            Console.WriteLine("You swing your axe for " + randomDmg);
        }
        return _damage;
    }
}
