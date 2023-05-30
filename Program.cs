// See https://aka.ms/new-console-template for more information


using EfCoreDataModeling;
using Microsoft.Extensions.Hosting;


Console.WriteLine("Hello, World!");


///
/// basic code to pget migration going
/// 
var builder = Host.CreateDefaultBuilder(args);

string connectionString = "Host=localhost;Database=XXXXXXXXX;Username=XXXXXXXXXXXXXX;Password=XXXXXXXXXXXX";

StartupHelper.ConfigureDatabase(builder, connectionString);


var app = builder.Build();
app.RunAsync().Wait();


