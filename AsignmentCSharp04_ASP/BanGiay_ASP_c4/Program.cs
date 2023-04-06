using BanGiay_ASP_c4.Services;
using BanGiay_ASP_c4.iServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<iColor, ColorSer>() ;
builder.Services.AddTransient<iMetarial, MetarialSer>() ;   
builder.Services.AddTransient<iRole, RoleSer>() ;
builder.Services.AddTransient<iUser, UserSer>() ;
builder.Services.AddTransient<iProduct, ProductSer>() ; 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
