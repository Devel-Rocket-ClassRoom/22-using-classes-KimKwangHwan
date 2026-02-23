using System;
using System.Runtime.InteropServices;

ClassName.MemberName();

string square = Square.GetName();
Console.WriteLine(square);

MyFirstClass.StaticMethod();

MyFirstClass my = new MyFirstClass();
my.InstanceMethod();

Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.Age = 30;
person2.Introduce();

Point point1 = new Point();
point1.X = 10;
point1.Y = 20;

Point point2 = point1;
point2.X = 100;

Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");

PointStruct ps1 = new PointStruct();
ps1.X = 10;
PointStruct ps2 = new PointStruct();
ps2.X = 100;
Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");

PointClass pc1 = new PointClass();
pc1.X = 10;
PointClass pc2 = pc1;
pc2.X = 100;
Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");

Calculator calc = new Calculator();
Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
Console.WriteLine($"3 * 5 = {calc.Multiply(3, 5)}");

Player player1 = new Player();
player1.ShowInfo();

Player player2 = new Player("용사", 150);
player2.ShowInfo();

Stock stock = new Stock();
stock.CurrentPrice = 30;
Console.WriteLine($"주가: {stock.CurrentPrice}");

Product product = new Product();
product.Name = "노트북";
product.Price = 1500000;
Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");

Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:F2}");

Monster monster1 = new Monster();
monster1.Name = "고블린";
monster1.Health = 50;

Monster monster2 = new Monster
{
    Name = "오크", Health = 100
};

monster1.Attack();
monster2.Attack();

Character hero = new Character
{
    Name = "용사",
    Level = 10,
    Job = "전사"
};

Console.WriteLine($"{hero.Name} - Lv.{hero.Level} {hero.Job}");

Random random = new Random();
Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(5)}");
Console.WriteLine($"1 ~ 9: {random.Next(1, 10)}");
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");

Console.WriteLine("주사위를 5번 굴립니다:");
for (int i = 0; i < 5; i++)
{
    int dice = random.Next(1, 7);
    Console.WriteLine($"  {i + 1}번째: {dice}");
}

PersonD alice = new PersonD("Alice", 25);
PersonD bob = new PersonD("Bob", 30);
alice.SetFriend(bob);

class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

class Square
{
    public static string GetName()
    {
        return "정사각형";
    }
}

class MyFirstClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살입니다.");
    }
}

class Point
{
    public int X;
    public int Y;
}

struct PointStruct
{
    public int X;
    public int Y;
}

class PointClass
{
    public int X;
    public int Y;
}

class BankAccount
{
    private static decimal s_interestRate;
    private readonly string _accountNumber;
    private decimal _balance;

    public BankAccount(string number)
    {
        _accountNumber = number;
    }
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b) => a * b;
}

class Player
{
    private string _name;
    private int _health;

    public Player()
    {
        _name = "Unknown";
        _health = 100;
    }

    public Player(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {_name}, 체력: {_health}");
    }
}

class Resource
{
    private string _name;

    public Resource(string name)
    {
        _name = name;
        Console.WriteLine($"{_name} 생성됨");
    }

    ~Resource()
    {
        Console.WriteLine($"{_name} 소멸됨");
    }
}

class Stock
{
    private decimal _currentPrice;

    public decimal CurrentPrice
    {
        get { return _currentPrice; }
        set { _currentPrice = value; }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;
}

class Circle
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;
}

class Monster
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다!");
    }
}

class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Job { get; set; }
}

class PersonD
{
    private string _name;
    private int _age;

    public PersonD(string name, int age)
    {
        this._name = name;
        this._age = age;
    }

    public void SetFriend(PersonD friend)
    {
        friend.PrintFriendInfo(this);
    }

    public void PrintFriendInfo(PersonD person)
    {
        Console.WriteLine($"{_name}의 친구는 {person._name}입니다.");
    }
}