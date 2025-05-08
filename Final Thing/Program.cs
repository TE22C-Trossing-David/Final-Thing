using System.Runtime.InteropServices;

Player hero = new();
EnemyList enemyList = new();

hero.AddItem(new Axe("Cool Axe", 10, 10, 3, 2, "Slashing"));
hero.AddItem(new Axe("Cooler Axe", 15, 15, 3, 2, "Slashing"));

enemyList.AddEnemy(new Knight());
enemyList.AddEnemy(new Goblin());
enemyList.AddEnemy(new Knight());

enemyList.CheckEnemyList();
enemyList.PrintEnemyList();
hero.CheckFullInv();

while (true)
{
    enemyList.Next();

    Console.ReadLine();
}









// hero.inventory.Add();

// toKill.Clear();

// enemies.RemoveAll(e => e._hp <= 0);
