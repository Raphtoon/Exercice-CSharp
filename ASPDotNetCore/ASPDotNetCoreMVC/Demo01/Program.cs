using Microsoft.AspNetCore.Mvc;

// Builder => sert à construire et configurer l'application

var builder = WebApplication.CreateBuilder(args);

// Ajout de services
// Des classes qui donnent des fonctionnalités réutilisables dans l'application
// Ex: pour la BDD, pour EfCore, Repositories, ......
builder.Services.AddControllersWithViews();

// Permet de build l'application fait passer le statut de en creation à => créée
var app = builder.Build();


// Ajout de middlewares et configurations Post Build
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ajout de la configuration par défault du routing (default)
// Elle définit un pattern de base pour l'accès a nos controller => /Home/Privacy
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Ajout d'une deuxième configuration avec une route "/test" qui redirige vers Privacy
app.MapControllerRoute(
    "customRoute",
    pattern: "test",
    new
    {
        Controller = "Home",
        Action = "Privacy",
    });
app.MapControllerRoute(
    name: "Contact",
    pattern: "{controller=Contact}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Contacts",
    pattern: "{controller=Contacts}/{action=Index}/{id?}");
app.Run();
