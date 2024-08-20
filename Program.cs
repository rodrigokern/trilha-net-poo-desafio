using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123-456-789", "Modelo 1", "987654321", 512);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.DebugInfo();

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("987-654-321", "Modelo 2", "123456789", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
iphone.DebugInfo();
