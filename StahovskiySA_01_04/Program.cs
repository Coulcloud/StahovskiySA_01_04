using StahovskiySA_01_04.Models;
using System;

//Создание объекта базового класса
Cabel cabel = new Cabel("Медный",15,150);
cabel.PrintInformation();
Console.WriteLine( $"Качество объекта:{cabel.CalculateQuality()}");

Console.WriteLine();
Console.WriteLine();

//Создание объекта дочернего класса
CabelChild cabelChild = new CabelChild("Алюминеневый",20,200,true);
cabelChild.PrintInformation();
Console.WriteLine($"Качество объекта:{cabelChild.CalculateQuality()}"); 


