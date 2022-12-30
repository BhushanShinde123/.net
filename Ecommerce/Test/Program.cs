using Memebership;
using HR;

Console.WriteLine("TFL store");

Console.WriteLine("Enter email ID");
string email=Console.ReadLine();

Console.WriteLine("Enter Password");
string password=Console.ReadLine();

if(AuthManager.Validate(email,password))
{
    Console.WriteLine("Welcome");
    Employee emp=new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("Salary = " + salary);
}
else{
    Console.WriteLine("Invalid User");

}