using CatchE;
using Serilog;

try
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Host
        .UseAutofac()
        .UseSerilog();
    builder.Services.AddApplication<CatchEModule>(
        options =>
        {
            options.Services.ReplaceConfiguration(builder.Configuration);
        });
    var app = builder.Build();
    app.InitializeApplication();
    await app.RunAsync();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly!");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}