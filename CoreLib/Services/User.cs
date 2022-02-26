using CoreLib.Models;
using Dapper;

namespace CoreLib.Services;

public class UserService{
    public static IEnumerable<User>GetAll<U>(
        U args 
    ){
        
        return Db.LoadData<User,dynamic>( 
            sp:"spUser_BasicInfo_Filter", 
            args
        );
    }
}