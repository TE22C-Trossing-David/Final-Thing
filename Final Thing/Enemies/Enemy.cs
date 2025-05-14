public class Enemy
{
    protected string _name;
    protected int _hp;

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public virtual void Attack()
    {
        Console.WriteLine("The enemy attacks");
    }

    public void Damage(int damage)
    {
        _hp -= damage;
        System.Console.WriteLine(_name + " now has " + Math.Clamp(_hp, 0, int.MaxValue) + " HP");
    }

    //Getters\\
    public int GetHp()
    {
        return _hp;
    }
    public string GetName()
    {
        return _name;
    }
}
