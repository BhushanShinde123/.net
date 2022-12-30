namespace HR;


public abstract class Employee
{
    //Data member with getter setter
    public int ID{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string ContactNumber{get;set;}
    public string Location{get;set;}
    public DateTime BirthDate{get;set;}
    public float DA{get;set;}
    public float HRA{get;set;}
    public float BasicSalary{get;set;}

    //constructor chaining
    //default constructor
    public Employee():this(12,"Bhushan","Shinde","bhushanshinde222@gmail.com",
                            "888822","Nashik",new DateTime(1998,12,30),1000,10000,15000){

    }

    //parametarized constructor
    public Employee(int id,string firstName,string lastname,string email,string contactNumber,
                    string location,DateTime bDate,float da,float hra,float bsal){

        this.ID=id;
        this.FirstName=firstName;
        this.LastName=lastname;
        this.Email=email;
        this.ContactNumber=contactNumber;
        this.Location=location;
        this.BirthDate=bDate;
        this.DA=da;
        this.HRA=hra;
        this.BasicSalary=bsal;
    }

    public abstract void DoWork();

    public virtual float ComputePay(){
        float pay=(DA * 25) + BasicSalary + HRA;
        return pay;
    }

    public override string ToString(){
        string str=string.Format("{0},{1},{2},{3},{4},{5}",ID,FirstName,LastName,Email,ContactNumber,Location);
        return str;
    }






    

}
