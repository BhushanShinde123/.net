namespace Memebership;
public class AuthManager
{
    public static bool Validate(string email,string password){
        bool status=false;

        if(email=="bhushanshinde222@gmail.com" && password=="xyzabc"){
            status=true;
        }
        return status;
    }

    // public static bool Register(string firstName,string lastname,string email,
    //                             string location,string contactNumber){
    //         bool status=false;

    //         try{
    //             User obj=new User();
    //             obj.FirstName=firstName;
    //             obj.Lastname=lastname;
    //             obj.Email=email;
    //             obj.Location=location;
    //             obj.ContactNumber=contactNumber;
    //             status=true;
    //             }
    //         catch(Exception e){

    //         }
    //         finally{

    //         }
    //         return status;
    //     }
}
