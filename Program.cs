using blazorApp2.Components;
// Entry point of the application

var builder = WebApplication.CreateBuilder(args); // creates a new instance of web app builder by invoking static method

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // adding razor components + interactive components

var app = builder.Build();

// Configure the HTTP request pipeline. (This is all middleware)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();

// Mapping app componenets as razor components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
