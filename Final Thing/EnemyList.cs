public class EnemyList()
{
    private Queue<Enemy> _enemiesQueue = new();
    private Enemy _currentEnemy = new();
    private List<Enemy> _enemies = new();
    private List<Enemy> _toKill = new();
    private Stack<Enemy> _deadEnemies = new();

    public void CheckEnemyList()
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
            _enemies.Remove(e);
            _deadEnemies.Push(e);
        }
    }

    public void PrintEnemyList()
    {
        foreach (Enemy e in _enemies)
        {
            Console.WriteLine(e._name + ": Hp:" + e._hp);
        }
    }

    public void AddEnemy(Enemy enemy)
    {
        _enemies.Add(enemy);
        _enemiesQueue.Enqueue(enemy);
    }

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
                    + " Hp"
            );
        }
        else
        {
            Console.WriteLine("There are no enemies left");
        }
    }
}
