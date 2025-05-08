public class Player
{
    private List<Item> _inventory = new List<Item>();

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
}
