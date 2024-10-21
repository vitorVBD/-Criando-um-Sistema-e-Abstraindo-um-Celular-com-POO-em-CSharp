
using terceiroDesafioCSharp.Models;

Iphone iphone = new Iphone("21123456789", "Iphone 15 pro", "ABC123", 512);
Nokia nokia = new Nokia("21987654321", "Nokia C21", "XYZ098", 128);

Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");