namespace Memebership;

public class User{

    private string firstName;

    //Normal getter setter
    private string FirstName{
        get{return firstName;}
        set{firstName=value;}
    }

    //auto getter setter
    public string Lastname{get;set;}
    public string Email{get;set;}
    public string ContactNumber{get;set;}
    public string Location{get;set;}



}