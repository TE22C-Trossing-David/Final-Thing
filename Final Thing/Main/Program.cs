using System.Runtime.InteropServices;
//Inastaciating everything------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Player player = new();
EnemyList enemyList = new();
InputHandler inputHandler = new(player, enemyList);

//Adding everything--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
player.AddWeapon(new Axe("Cool Axe", 10, 10, 3, 2, "Slashing"));
player.AddWeapon(new Axe("Cooler Axe", 15, 15, 3, 2, "Slashing"));

inputHandler.MakeMenus();
player.SetCurrentWeapon(player.GetWeapon(1));

void StartBattle()
{
    Console.Clear();
    bool battleOver = false;
    enemyList.AddEnemy(new Goblin());
    enemyList.AddEnemy(new Goblin());
    enemyList.AddEnemy(new Knight());

    Console.WriteLine("Enemies loaded");

    enemyList.Next();
    while (!battleOver)
    {
        inputHandler.OpenMenus();
        Console.Clear();
        enemyList.PrintEnemyList();
        enemyList.EnemyAttack();
        enemyList.KillDeadEnemies();
        if (enemyList.isEnemiesDead())
        {
            battleOver = true;
        }
    }
}

//Debug ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
enemyList.KillDeadEnemies();
enemyList.PrintEnemyList();
player.CheckFullInv();

//Start of Game\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Main game loop
while (true)
{
    Console.WriteLine("Welcome to RPGLandia, here you will fight enemy after enemy untill you have defeted all enemies. Press enter to start your adventure!");
    Console.ReadLine();

    while (true)
    {
        StartBattle();
        break;
    }
    System.Console.WriteLine("congrats you have won the battle");
    Console.ReadLine();
}