﻿// See https://aka.ms/new-console-template for more information

using apbd_tut3;

internal class Program
{
    public static void Main(string[] args)
    {
        RefrigeratorContainer container = new RefrigeratorContainer(10, 450, 200.0, 50.0, 500);
        Console.WriteLine(container.SerialNumber);
    }
}