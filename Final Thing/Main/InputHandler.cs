using System.Linq.Expressions;

public class InputHandler
{
    private Player _player;

    public InputHandler(Player player)
    {
        _player = player;
    }

    string CurrentMenue = "main";

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
            { "special attack", SpecialAttack},
            { "special atack", SpecialAttack},
            { "special", SpecialAttack},
            { "2", SpecialAttack},
            { "s", SpecialAttack}
        };
    }

    //
    public void OpenMenus()
    {
        bool correctInput = false;
        string _playerInput;
        //Frågar vad spelaren vill göra och repetar tills spelaren skriver något som finns i dictionaryn.
        while (!correctInput)
        {
            //tar spelarens input och 
            if (CurrentMenue == "main")
            {
                Console.WriteLine("What action do you want to do?\nAttack\nBlock");

                _playerInput = Console.ReadLine().ToLower();
                Console.Clear();


                if (_mainMenus.ContainsKey(_playerInput))
                {
                    _mainMenus[_playerInput]();
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("That is not an action");
                }
            }
            if (CurrentMenue == "attack")
            {
                Console.WriteLine("What action do you want to do?\nBasic Attack\nSpecial Attack");
                _playerInput = Console.ReadLine().ToLower();
                Console.Clear();
                if (_attackMenus.ContainsKey(_playerInput))
                {
                    _attackMenus[_playerInput]();
                    correctInput = true;
                }
                else
                {
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
        CurrentMenue = "attack";
    }

    void BasicAttack()
    {
        _player.BasicAttack();
    }

    void SpecialAttack()
    {
        _player.SpecialAttack();
    }
}
