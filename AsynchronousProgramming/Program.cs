// See https://aka.ms/new-console-template for more information

using AsynchronousProgramming;

Console.WriteLine("Cooking started");
var turkey = new Turkey();
await turkey.Cook();
var gravy = new Gravy();
await  gravy.Cook();
Console.WriteLine("ready to eat");