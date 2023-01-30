global using System.ComponentModel.DataAnnotations;
global using Report_Web.Model;
global using Report_Web.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddScoped<IMemberService, MemberService>();
//builder.Services.AddScoped<IProjectManageService, ProjectManageService>();
//builder.Services.AddScoped<IDailyService, DailyService>();

builder.Services.AddTelerikBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
