// See https://aka.ms/new-console-template for more information

using AsynchronousProgramming;

Console.WriteLine("Cooking started");
var turkey = new Turkey();
turkey.Cook().ContinueWith(a =>
{
    var gravy = new Gravy();
    gravy.Cook();
});

Console.ReadLine();