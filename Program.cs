// See https://aka.ms/new-console-template for more information


using EfCoreDataModeling;
using Microsoft.Extensions.Hosting;


Console.WriteLine("Hello, World!");


///
/// basic code to get migration going
/// 
var builder = Host.CreateDefaultBuilder(args);

string connectionString = "Host=localhost;Database=bank_accounts;Username=postgres;Password=postgrespw";

StartupHelper.ConfigureDatabase(builder, connectionString);


var app = builder.Build();
app.RunAsync().Wait();


