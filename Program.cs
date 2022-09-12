using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando o smartphone Nokia");
var nokia = new Nokia("11988778877", "M2002", "AEAS32378230ZXY", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("Testando o smartphone iPhone");
var iphone = new Iphone("21977668844", "iPhone 15", "ZXASEWE323237897", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");