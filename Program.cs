using Microsoft.EntityFrameworkCore;
using Pop_Anca_LAb2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Pop_Anca_LAb2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pop_Anca_LAb2Context") ?? throw new InvalidOperationException("Connection string 'Nume_Pren_Lab2Context' not found.")));
;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
