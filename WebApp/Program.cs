using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Plugins.DataStore.InMemory;
using UseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;
using WebApp.Data;

using Havit.Blazor.Components.Web;        // <------ ADD THIS LINE
using Havit.Blazor.Components.Web.Bootstrap;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHxServices();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


// Dependency Injection In Memory Data Store
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Dependency Injection for UseCases and Repositories
//DI categories
builder.Services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


