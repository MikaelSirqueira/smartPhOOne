using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Smartphone Nokia");
Nokia nokia = new Nokia(numero: "99223344", modelo: "Tijolão", imei: "111144", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Teste Smartphone Iphone");
Iphone iphone = new Iphone(numero: "88776655", modelo: "15 Pro Max", imei: "00003", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");