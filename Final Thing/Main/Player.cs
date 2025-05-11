public class Player
{
    string name;
    int hp;
    public bool isBlocking = false;
    private List<Item> _inventory = new List<Item>();
    Weapon _weaponBeingUsed;

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Fighting
    public void BasicAttack()
    {
        Console.WriteLine("you attack");
    }

    public void SpecialAttack() { }

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

    public void CheckFullInv()
    {
        for (int i = 0; i < _inventory.Count; i++)
        {
            Console.WriteLine(_inventory[i]);
        }
    }

    public void CheckInvSpace(int position)
    {
        Console.WriteLine(_inventory[position - 1]);
    }

    //Other

    public string GetWeaponBeingUsed()
    {
        return _weaponBeingUsed.ToString();
    }
}
