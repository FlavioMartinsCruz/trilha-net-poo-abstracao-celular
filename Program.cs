using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();

System.Console.WriteLine("<<< Celular Nokia >>>");
Nokia n1 = new Nokia(numero: "(31)99999-9999", modelo: "Lumia NK01", imei: "101110110", memoria: 128);
n1.Ligar();
n1.InstalarAplicativo("Pottencial");

System.Console.WriteLine("\n");
System.Console.WriteLine("<<< Celular Iphone >>>");
Iphone i1 = new Iphone(numero: "(31)98888-8888", modelo: "Iphone IP10", imei: "1000111101", memoria: 256);
i1.ReceberLigacao();
i1.InstalarAplicativo("DIO");