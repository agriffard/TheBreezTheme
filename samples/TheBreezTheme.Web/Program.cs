var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOrchardCms()
    // Enable the AutoSetup feature so the Default tenant is provisioned
    // automatically from the OrchardCore_AutoSetup section in appsettings.json.
    .AddSetupFeatures("OrchardCore.AutoSetup");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseOrchardCore();

app.Run();
