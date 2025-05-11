public class EnemyList()
{
    private List<Enemy> _enemies = new();
    private Enemy _currentEnemy = new();
    private Queue<Enemy> _enemiesQueue = new();
    private List<Enemy> _toKill = new();
    private Stack<Enemy> _deadEnemies = new();

    //-----------//Methods\\-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public void AddEnemy(Enemy enemy)
    {
        _enemies.Add(enemy);
        _enemiesQueue.Enqueue(enemy);
    }

    public Enemy CurrentEnemy()
    {
            return _currentEnemy;

    }
    public void PrintEnemyList()
    {
        foreach (Enemy e in _enemies)
        {
            Console.WriteLine(e._name + ": Hp:" + e._hp);
        }
    }
    //Tar bort enemyn högst i kö och säger vad för enemy man fightar nu.
    public void Next()
    {
        if (_enemiesQueue.Count > 0)
        {
            _currentEnemy = _enemiesQueue.Dequeue();
            Console.WriteLine(
                "You are now fighing a "
                    + _currentEnemy._name
                    + " With "
                    + _currentEnemy._hp
                    + " Hp\n"
            );
        }
        else
        {
            Console.WriteLine("There are no enemies left");
        }
    }

    //Lägger till alla enemies med 0 hp i "_toKill". Sen tar bort alla enemies som är i "_toKill" från _enemies listan och lägger in i _deadEnemies listan.
    public void KillDeadEnemies()
    {
        for (int i = 0; i < _enemies.Count; i++)
        {
            if (_enemies[i]._hp <= 0)
            {

                _toKill.Add(_enemies[i]);
            }
        }

        foreach (Enemy e in _toKill)
        {

            Console.WriteLine(e._name + " has died");
            _enemies.Remove(e);
            _deadEnemies.Push(e);
            Next();
        }
    }


    public bool isEnemiesDead()
    {
        if (_enemies.Count() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }




    public void EnemyAttack()
    {
        _currentEnemy.Attack();
    }

}
