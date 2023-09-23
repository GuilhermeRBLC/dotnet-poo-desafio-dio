using DesafioPOO.Models;

Console.WriteLine("\n");

Console.WriteLine("Testando Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "124567", modelo: "Modelo 1", imei: "111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Testando Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "8765432", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");
