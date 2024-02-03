var builder = WebApplication.CreateBuilder(args);

// MVC şablonu builder objesinin servis deposundan projeye eklenir. MVC yapısında geliştirme yapacağım için bunu projeye ekledim.
builder.Services.AddControllersWithViews();

// Web API geliştirirken, builder objesinin servis deposundan projeye eklenir.
// builder.Services.AddControllers();

// Razor Pages şablonu builder objesinin servis deposundan projeye eklenir.
// builder.Services.AddRazorPages();


var app = builder.Build();

// statik dosyaların kullanılması. wwwroot dizini altındaki css, js dosyaları dışarı açılmış olur.
app.UseStaticFiles();

// eğer wwwroot dışında farklı bir dizini statik dosya dizini olarak dışarı açmak istersek alttaki tanımı eklemeliyiz.

// app.UseStaticFiles(new StaticFileOptions
// {
//     FileProvider = new PhysicalFileProvider(
//            Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
//     RequestPath = "/StaticFiles"
// });


// yönlendirmenin aktif edilmesi
app.UseRouting();

// yukarı app nesnesini kullanan middleware lerin route yapısından önce tanıtılması gerekiyor.

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
