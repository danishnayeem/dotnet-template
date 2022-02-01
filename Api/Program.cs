using CoreLib.Services;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
CoreLib.Db.Config( builder.Configuration.GetSection("ConnectionStrings:Dev").Value );

app.MapGet("/", () =>{
    return UserService.GetAll();
});

app.Run();