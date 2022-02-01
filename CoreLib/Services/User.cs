using CoreLib.Models;
using Dapper;

namespace CoreLib.Services;

public class UserService{
    public static IEnumerable<User>GetAll(){
        return Db.LoadData<User,dynamic>( sp:"spUser_Get", new{ pr_id = 2 } );
    }
}