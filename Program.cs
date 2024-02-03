var builder = WebApplication.CreateBuilder(args);

// MVC şablonu builder objesinin servis deposundan projeye eklenir. MVC yapısında geliştirme yapacağım için bunu projeye ekledim.
builder.Services.AddControllersWithViews();

// Web API geliştirirken, builder objesinin servis deposundan projeye eklenir.
// builder.Services.AddControllers();

// Razor Pages şablonu builder objesinin servis deposundan projeye eklenir.
// builder.Services.AddRazorPages();


var app = builder.Build();

// default controller route kullanımı
// app.MapDefaultControllerRoute();

// {controller=Home}/{action=Index}/id?
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


//app.MapGet("/", () => "Hello World!");
//app.MapGet("/test", () => "Test."); // test sayfasına yönlenir.

app.Run();
