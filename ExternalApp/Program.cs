﻿// See https://aka.ms/new-console-template for more information

using ExternalApp;

Console.WriteLine("Press any key to continue...");
Console.ReadLine();
Console.WriteLine("Hello, World!");
int i = 25;
int rnd = new Random().Next(1,10);
for (int k = 0; k < i; k++)
{
    Console.WriteLine(i*k);
    Thread.Sleep(100);
}

Console.WriteLine("Finished");

new Printer().Print("qqq");
TestClass obj = new TestClass();
Console.WriteLine(obj.name);