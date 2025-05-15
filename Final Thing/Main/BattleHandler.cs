public class BattleHandler
{
    private Player _player;
    private EnemyList _enemyList;

    public BattleHandler(Player player, EnemyList enemyList)
    {
        _player = player;
        _enemyList = enemyList;
    }

    private string _currentMenu = "main";
    Dictionary<string, Action> _mainMenus;
    Dictionary<string, Action> _attackMenus;

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Skapar allt i dictionaryn
    public void MakeMenus()
    {
        _mainMenus = new Dictionary<String, Action>
        {
            { "attack", EnterAttackMenu },
            { "atack", EnterAttackMenu },
            { "a", EnterAttackMenu },
            { "1", EnterAttackMenu },
            { "block", Block },
            { "b", Block },
            { "2", Block },
        };

        _attackMenus = new Dictionary<string, Action>
        {
            { "basic attack", BasicAttack },
            { "basic atack", BasicAttack },
            { "basic", BasicAttack },
            { "1", BasicAttack },
            { "b", BasicAttack },
            { "special attack", SpecialAttack },
            { "special atack", SpecialAttack },
            { "special", SpecialAttack },
            { "2", SpecialAttack },
            { "s", SpecialAttack },
        };
    }

    public void StartBattle()
    {
        Console.Clear();
        bool battleOver = false;
        bool validInput = false;
        int numberOfEnemies = 0;
        //Skapar Goblins
        while (!validInput)
        {
            Console.WriteLine("How many Goblins do you want to fight?");
            string input = Console.ReadLine();

            validInput = int.TryParse(input, out numberOfEnemies);

            if (validInput && numberOfEnemies > 0)
            {
                for (int i = 0; i < numberOfEnemies; i++)
                {
                    _enemyList.AddEnemy(new Goblin());
                }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid positive number.");
                validInput = false;
            }
        }
        //Skapar Knights
        validInput = false;
        while (!validInput)
        {
            Console.WriteLine("How many Knights do you want to fight?");
            string input = Console.ReadLine();

            validInput = int.TryParse(input, out numberOfEnemies);

            if (validInput && numberOfEnemies > 0)
            {
                for (int i = 0; i < numberOfEnemies; i++)
                {
                    _enemyList.AddEnemy(new Knight());
                }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid positive number.");
                validInput = false;
            }
        }

        _enemyList.Next();
        while (!battleOver)
        {
            OpenMenus();
            if (_enemyList.CurrentEnemy().GetHp() >= 0)
            {
                _enemyList.EnemyAttack();
            }
            _enemyList.KillDeadEnemies();
            if (_enemyList.AreEnemiesDead())
            {
                battleOver = true;
            }
        }
        Console.WriteLine(
            "\nCongrats you have won the battle\nPress Enter to start the next battle or type EXIT to exit the game"
        );
        try
        {
            string input = Console.ReadLine()?.ToUpper();
            if (input == "EXIT")
            {
                Environment.Exit(0);
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void OpenMenus()
    {
        _currentMenu = "main";

        bool correctInput = false;
        string playerInput;
        while (!correctInput)
        {
            if (_currentMenu == "main")
            {
                Console.WriteLine("\nWhat action do you want to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Block");
                Console.Write("Enter choice: ");
                playerInput = Console.ReadLine().ToLower();

                if (_mainMenus.ContainsKey(playerInput))
                {
                    Console.Clear();
                    _mainMenus[playerInput]();
                    correctInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That is not an action\n");
                }
            }
            if (_currentMenu == "attack")
            {
                correctInput = false;
                Console.WriteLine("What attack do you want to do?");
                Console.WriteLine("1. Basic Attack");
                Console.WriteLine("2. Special Attack");
                Console.Write("Enter choice: ");
                playerInput = Console.ReadLine().ToLower();

                if (_attackMenus.ContainsKey(playerInput))
                {
                    Console.Clear();
                    _attackMenus[playerInput]();
                    correctInput = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That is not an action");
                }
            }
        }
    }

    // Alla actions i menyerna ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    void Block()
    {
        _player.Block();
    }

    void EnterAttackMenu()
    {
        _currentMenu = "attack";
    }

    void BasicAttack()
    {
        _player.BasicAttack(_enemyList.CurrentEnemy());
    }

    void SpecialAttack()
    {
        _player.SpecialAttack(_enemyList.CurrentEnemy());
    }
}
