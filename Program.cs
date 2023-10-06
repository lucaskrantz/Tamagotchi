﻿using System;
using System.Runtime.InteropServices;

Console.WriteLine("Welcome to Tamagotchi");

Tamagotchi Tama = new Tamagotchi();

Console.WriteLine("What would you like your Tamagotchi to be called?");

Tama.name = Console.ReadLine();

Console.WriteLine($"Okay, your Tamagotchi is called {Tama.name}");

while (Tama.GetAlive())
{
    Console.Clear();
    Tama.PrintStats();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine($"1. Teach {Tama.name} a new word");
    Console.WriteLine($"2. Feed {Tama.name}");
    Console.WriteLine($"3. Talk to {Tama.name}");
    Console.WriteLine($"What would you like to do?");

}