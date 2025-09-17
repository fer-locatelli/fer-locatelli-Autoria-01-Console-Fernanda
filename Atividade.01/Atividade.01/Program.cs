// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o cateto oposto:");
double oposto = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o cateto adjacente:");
double adjacente = double.Parse(Console.ReadLine());
double resultado = (oposto*oposto) + (adjacente*adjacente);
double hipotenusa = Math.Sqrt(resultado);
    Console.WriteLine($"A hipotenusa é de aprox: {hipotenusa:F1}");
