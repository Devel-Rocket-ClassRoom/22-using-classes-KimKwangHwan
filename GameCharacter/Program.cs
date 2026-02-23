using System;

GameCharacter hero = new GameCharacter("용사", 5);
GameCharacter monster = new GameCharacter("고블린", 3);

hero.ShowStatus();
monster.ShowStatus();

Console.WriteLine("\n=== 전투 시작 ===");

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

class GameCharacter
{
    private string _name;
    private int _level;
    private int _current_hp;

    public string Name
    {
        get { return _name; }
    }
    public int Level
    {
        get { return _level; }
    }

    public int MaxHp
    {
        get { return _level * 100; }
    }

    public int CurrentHp
    {
        get { return _current_hp; }
    }

    public int AttackPower
    {
        get { return _level * 10; }
    }
    public bool IsAlive
    {
        get { return _current_hp > 0; }
    }

    public GameCharacter(string name, int level)
    {
        _name = name;
        _level = level;
        _current_hp = MaxHp;
    }

    public void Attack(GameCharacter target)
    {
        target.TakeDamage(AttackPower);

        Console.WriteLine($"{this.Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다!");
    }

    public void TakeDamage(int damage)
    {
        _current_hp -= damage;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{_name}] Lv.{_level} - HP: {_current_hp}/{MaxHp}, 공격력: {AttackPower}");
    }
}