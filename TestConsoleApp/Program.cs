// See https://aka.ms/new-console-template for more information
var filesStr = XmlToCsvService.ConvertXmlsToCsvs(Environment.CurrentDirectory + "\\working", Environment.CurrentDirectory + "\\schema.xml");
Console.WriteLine($"Csv files created: {filesStr}");
Console.WriteLine("Please any key to close console.");
Console.ReadLine();