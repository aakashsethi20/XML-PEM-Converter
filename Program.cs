using XmlPemConverter;

while (true)
{
    Console.WriteLine("Welcome to XML key converter! Please select an option:");
    Console.WriteLine("1. XML to PEM\n2. PEM to XML\n\nAny other key to exit...");

    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("\nReading from file: xmlFile.xml");
            string wholeXml = File.ReadAllText("xmlFile.xml");
            if (string.IsNullOrWhiteSpace(wholeXml))
            {
                Console.WriteLine("Enter something next time, dumbass!\n\n");
                break;
            }

            Console.WriteLine($"\n{RsaKeyConverter.XmlToPem(wholeXml)}\n\n");
            break;

        case ConsoleKey.D2:
            Console.WriteLine("\nReading from file: pemFile.pem");
            string wholePem = File.ReadAllText("pemFile.pem");
            if (string.IsNullOrWhiteSpace(wholePem))
            {
                Console.WriteLine("Enter something next time, dumbass!\n\n");
                break;
            }

            Console.WriteLine($"\n{RsaKeyConverter.PemToXml(wholePem)}\n\n");
            break;

        default:
            Console.WriteLine("\nExiting");
            return;
    }
}
