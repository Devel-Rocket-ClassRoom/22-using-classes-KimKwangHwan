using System;

BankAccount account = new BankAccount("123-456-789", "홍길동");
account.ShowInfo();

account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);

account.ShowInfo();


class BankAccount
{
    private string _accountNumber;
    private string _ownerName;
    private int _balance;

    public BankAccount(string accountNumber, string ownerName)
    {
        _accountNumber = accountNumber;
        _ownerName = ownerName;
    }

    public string AccountNumber
    {
        get { return _accountNumber; }
    }

    public string OwnerName
    {
        get { return _ownerName; } 
    }

    public int Balance
    {
        get { return _balance; }
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("입금 금액은 0보다 커야 합니다.");
            return;
        }
        _balance += amount;
        Console.WriteLine($"{amount}원 입금 완료. 잔액: {_balance}원");
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("출금 금액은 0보다 커야 합니다.");
            return;
        }
        if (amount > _balance)
        {
            Console.WriteLine("잔액이 부족합니다.");
            return;
        }
        _balance -= amount;
        Console.WriteLine($"{amount}원 출금 완료. 잔액: {_balance}원");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"[계좌 정보] {AccountNumber} ({_ownerName}) - 잔액: {_balance}원");
    }
}