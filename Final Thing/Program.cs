Player hero = new();

// hero.inventory.Add();

List<Enemy> enemies = new();

enemies.Add(new());
enemies.Add(new());
enemies.Add(new());
enemies.Add(new());
enemies.Add(new());
enemies.Add(new());
enemies.Add(new());

List<Enemy> toKill = new();

for (int i = 0; i < enemies.Count; i++)
{
    if (enemies[i]._hp <= 0)
    {
        // enemies.RemoveAt(i);
        toKill.Add(enemies[i]);
    }
}

foreach (Enemy e in toKill)
{
    enemies.Remove(e);
}

toKill.Clear();

enemies.RemoveAll(e => e._hp <= 0);
