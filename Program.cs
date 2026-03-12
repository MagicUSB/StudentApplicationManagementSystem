using StudentApplicationManagementSystem.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentApplicationManagementSystem.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<StudentApplicationManagementSystemContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("StudentApplicationManagementSystemContext") ?? throw new InvalidOperationException("Connection string 'StudentApplicationManagementSystemContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
