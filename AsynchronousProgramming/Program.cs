// See https://aka.ms/new-console-template for more information

using AsynchronousProgramming;

Console.WriteLine("Cooking started");
var turkey = new Turkey();
var gravy = new Gravy();
await Task.WhenAll(turkey.Cook(),gravy.Cook());
// await turkey.Cook();
// await  gravy.Cook();
Console.WriteLine("ready to eat");