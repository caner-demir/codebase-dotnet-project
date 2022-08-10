using Autofac;
using Autofac.Extensions.DependencyInjection;
using Codebase.BL.Abstract;
using Codebase.BL.Concrete;
using Codebase.BL.DependencyResolvers.Autofac;
using Codebase.DAL.Abstract;
using Codebase.DAL.Concrete.EntityFramework;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(configuratin =>
{
    configuratin.RegisterValidatorsFromAssemblyContaining<AutofacBusinessModule>();
});
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
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
