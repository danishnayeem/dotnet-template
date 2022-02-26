using MySql.Data.MySqlClient;
using Dapper;
namespace CoreLib;
public class Db
{
    public static MySqlConnection con;
    public static string ProjectAuth;
    public static string ConnectionString;
    public static void Config(string connectionString){
        Db.ConnectionString = connectionString;
    }
    public static void Connect(){
        Db.con = new( Db.ConnectionString );
    }
    public static IEnumerable<T>LoadData<T,U>( string sp,U pr ){
        Db.Connect();
        return Db.con.Query<T>( sp, pr, commandType:System.Data.CommandType.StoredProcedure ).ToList();
    }
}
