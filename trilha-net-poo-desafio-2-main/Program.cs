using System.ComponentModel;
using DesafioPOO.Models;

// FEITO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero:"4002-8922", modelo:"2600", imei:"35 929 10 25 31 68 00 00", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone(numero:"0800-777", modelo:"14", imei:"86 012 34 56 78 90 00 01", memoria: 128);
iphone.ReceberLigacao();
Console.WriteLine($"De {nokia.Numero}");
iphone.InstalarAplicativo("Telegram");