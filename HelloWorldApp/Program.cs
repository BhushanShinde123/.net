using Banking;

int a=10;
int b=20;
int c;
c=a+b;
Console.WriteLine(c);

var p=new{
    FirstName="Bhushan",
    LastName="Shinde"
};

Console.WriteLine(p.FirstName + " " + p.LastName);

Account acc1=new Account(6000);
acc1.Deposit(15000);
float currentBalance1=acc1.GetBalance();

List<Account> accounts=new List<Account>();
accounts.Add(acc1);

foreach(Account theAccount in accounts){
    float result=theAccount.GetBalance();
    Console.WriteLine("Current Balance={0}",result);
}