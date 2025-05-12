public class Player
{
    string name;
    int hp;
    public bool isBlocking = false;
    private List<Item> _inventory = new();
    private List<Weapon> _weapons = new();

    Weapon _weaponBeingUsed = null;

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void SetCurrentWeapon(Weapon weapon)
    {
        _weaponBeingUsed = weapon;
    }

    //Fighting
    public void BasicAttack(Enemy enemy)
    {
        enemy._hp -= _weaponBeingUsed.BasicAttack();
        System.Console.WriteLine(enemy._name + " now has " + enemy._hp + " HP");
    }

    public void SpecialAttack(Enemy enemy)
    {
        enemy._hp -= _weaponBeingUsed.SpecialAttack();
    }

    public void Block()
    {
        Console.WriteLine("you block");
        isBlocking = true;
    }

    //Inventory
    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }

    public void AddWeapon(Weapon weapon)
    {
        _weapons.Add(weapon);
    }

    public void CheckFullInv()
    {
        for (int i = 0; i < _inventory.Count; i++)
        {
            Console.WriteLine(_inventory[i]);
        }
    }

    public Item GetInvSpace(int position)
    {
        return _inventory[position - 1];
    }

    public Weapon GetWeapon(int position)
    {
        return _weapons[position - 1];
    }

    //Other

    public string GetWeaponBeingUsed()
    {
        if (_weaponBeingUsed != null)
        {
            return _weaponBeingUsed.ToString();
        }
        else
        {
            return "No weapon is equiped";
        }
    }
}
