using Eshop.Application.Services.Implementations;
using Eshop.Application.Services.Interfaces;
using Eshop.Data.Context;
using Eshop.Data.Repository;
using GoogleReCaptcha.V3;
using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Eshop.Web.Areas.User.Services;

var builder = WebApplication.CreateBuilder(args);

//DI
builder.Services.AddHttpClient<ICaptchaValidator , GoogleReCaptchaValidator>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<IUserService , UserService>();
builder.Services.AddScoped<ISmsService , SmsService>();
builder.Services.AddScoped<IProductService , ProductService>();
builder.Services.AddScoped<IOrderService , OrderService>();
builder.Services.AddScoped<IPaymentService , PaymentService>();
builder.Services.AddScoped<ICategoryService , CategoryService>();
builder.Services.AddScoped<ICommonService , CommonService>();
builder.Services.AddScoped<IPermissionService , PermissionService>();

//Db Configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add Optional Services
builder.Services.AddMemoryCache();

// Data Protection
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(Directory.GetCurrentDirectory() + "//wwwroot/Auth//"))
    .SetApplicationName("Eshop")
    .SetDefaultKeyLifetime(TimeSpan.FromDays(7));

//Authentication Configuration
builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/register";
    options.LogoutPath = "/log-out";
    options.ExpireTimeSpan = TimeSpan.FromDays(7);
    options.SlidingExpiration = true;
});

//Encoder 
builder.Services.AddSingleton<HtmlEncoder>(HtmlEncoder
    .Create(allowedRanges: new[] { UnicodeRanges.BasicLatin, UnicodeRanges.Arabic }));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
