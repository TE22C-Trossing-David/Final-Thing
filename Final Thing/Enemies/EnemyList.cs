public class EnemyList
{
    private List<Enemy> _enemies = new();
    private Enemy _currentEnemy;
    private Queue<Enemy> _enemiesQueue = new();
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

    public void Next()
    {
        if (_enemiesQueue.Count > 0)
        {
            _currentEnemy = _enemiesQueue.Dequeue();
            Console.WriteLine(
                "You are now fighing a "
                    + _currentEnemy.GetName()
                    + " With "
                    + _currentEnemy.GetHp()
                    + " Hp"
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
        if (_currentEnemy.GetHp() <= 0)
        {
            Console.WriteLine(_currentEnemy.GetName() + " has died");
            _enemies.Remove(_currentEnemy);
            Next();
        }
    }

    public bool AreEnemiesDead()
    {
        return _enemies.Count() == 0;
    }

    public void EnemyAttack()
    {
        _currentEnemy.Attack();
    }
}
