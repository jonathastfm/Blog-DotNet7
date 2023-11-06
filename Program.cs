using Microsoft.EntityFrameworkCore;
using SlifioHub.Data;

var builder = WebApplication.CreateBuilder(args);
string mySqlConnection = "server=212.192.29.71;user=seusitep_jonathas;database=seusitep_jhonathas;port=3306;password=MyPass@wordMyPass@word";
builder.Services.AddDbContext<DataContext>
    (option => option.UseMySQL(mySqlConnection));
    
    
    
// Add services to the container.
builder.Services.AddControllersWithViews();

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