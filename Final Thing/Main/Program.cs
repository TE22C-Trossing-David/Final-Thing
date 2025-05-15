//Adding everything--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Player player = new();
EnemyList enemyList = new();
BattleHandler battleHandler = new(player, enemyList);

player.AddWeapon(new Axe("Cool Axe", 10, 10, 3, 2, "Slashing"));
player.AddWeapon(new Axe("Cooler Axe", 15, 15, 3, 2, "Slashing"));

battleHandler.MakeMenus();
player.SetCurrentWeapon(player.GetWeapon(1));

//-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Start of Game\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Main game loop
while (true)
{
    Console.Clear();
    Console.WriteLine(
        "Welcome to RPGLandia, here you will fight enemy after enemy until you have defeated all enemies.\nPress enter to start your adventure!"
    );
    Console.ReadLine();
    while (true)
    {
        battleHandler.StartBattle();
    }
}
