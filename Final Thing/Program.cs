using System.Runtime.InteropServices;

Player player = new();
EnemyList enemyList = new();
InputHandler inputHandler = new(player);

//Adding everything--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
player.AddItem(new Axe("Cool Axe", 10, 10, 3, 2, "Slashing"));
player.AddItem(new Axe("Cooler Axe", 15, 15, 3, 2, "Slashing"));

enemyList.AddEnemy(new Knight());
enemyList.AddEnemy(new Goblin());
enemyList.AddEnemy(new Knight());


inputHandler.MakeMenus();


//Debug ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
enemyList.CheckEnemyList();
enemyList.PrintEnemyList();
player.CheckFullInv();

//Start of Game\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

while (true)
{
    inputHandler.OpenMenus();
    Console.ReadLine();
}









// hero.inventory.Add();

// toKill.Clear();

// enemies.RemoveAll(e => e._hp <= 0);
